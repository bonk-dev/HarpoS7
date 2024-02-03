using System.Buffers;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Text;

namespace HarpoS7.Transport;

/// <summary>
/// A very primitive stream that wraps the written data into a COTP (pdu: DT Data) over TPKT packet.
/// <para>Warning: It does not support COTP fragmentation.</para>
/// </summary>
public class CotpStream : Stream
{
    private const int ExpectedCotpConConfirmLength = 36;
    private const int HeaderLength = 7;
    private const int MinCotpConRequestLength = 16;
    private const string BufferLengthExceptionMessage = "The buffer length must be either 0 or at least 7";
    private const string InvalidHeaderReadExceptionMessage = "Could not read enough bytes to read the TPKT/COTP header (read: {0}, required: {1})";
    
    private static readonly byte[] EmptyDtDataCotpPacket =
    [
        0x03, 0x00, 0x00, 0x07, 0x02, 0xF0, 0x00
    ];

    private readonly Stream _underlyingStream;
    
    public override bool CanRead => _underlyingStream.CanRead;
    public override bool CanSeek => _underlyingStream.CanSeek;
    public override bool CanWrite => _underlyingStream.CanWrite;
    public override long Length => _underlyingStream.Length;

    public override long Position
    {
        get => _underlyingStream.Position;
        set => _underlyingStream.Position = value;
    }

    public CotpStream(Stream underlyingStream)
    {
        _underlyingStream = underlyingStream;
    }

    internal async Task WriteConnectionRequestAsync(string destinationTsap)
    {
        var length = 4 + MinCotpConRequestLength + Encoding.ASCII.GetByteCount(destinationTsap);
        var header = ArrayPool<byte>.Shared.Rent(length);
        try
        {
            WriteTpktHeader(header, length, doNotAddHeaderLength: true);
            SerializeConnectionRequest(header.AsSpan()[4..], destinationTsap);

            await _underlyingStream.WriteAsync(header[..length]);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(header);
        }
    }

    /// <summary>
    /// Reads bytes from the underlying stream and checks if the packet is a COTP Connect Confirm.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <exception cref="Exception"></exception>
    internal async Task ReadConnectionConfirmAsync(CancellationToken cancellationToken = default)
    {
        // If the destination TSAP was different than the default one, the buffer length will be different.
        var header = ArrayPool<byte>.Shared.Rent(ExpectedCotpConConfirmLength);

        try
        {
            var read = await _underlyingStream.ReadAsync(header.AsMemory()[..ExpectedCotpConConfirmLength], cancellationToken);
            Debug.WriteLine($"COTP CC: Read {read} bytes");
            if (read < 6)
            {
                throw new Exception("Could not read enough bytes");
            }

            var remainingBytes = BinaryPrimitives.ReadUInt16BigEndian(header.AsSpan()[2..]) - read;
            
            if (header[5] != 0xD0)
            {
                throw new Exception("Invalid Connect Confirm packet (PDU Type != 0x0D)");
            }
            
            // discard remaining bytes
            while (remainingBytes > 0)
            {
                Debug.WriteLine($"COTP CC: discarding {remainingBytes}");
                remainingBytes -= await _underlyingStream.ReadAsync(header.AsMemory()[..remainingBytes], cancellationToken);
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(header);
        }
    }

    internal async Task WriteEmptyDtDataAsync() => await _underlyingStream.WriteAsync(EmptyDtDataCotpPacket);

    public override async ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = new())
    {
        switch (buffer.Length)
        {
            case <= 0:
                return await _underlyingStream.ReadAsync(buffer, cancellationToken);
            case < HeaderLength:
                throw new ArgumentException(BufferLengthExceptionMessage, nameof(buffer));
        }

        var read = await _underlyingStream.ReadAsync(buffer[..HeaderLength], cancellationToken);
        if (read != HeaderLength)
        {
            throw new Exception(string.Format(InvalidHeaderReadExceptionMessage, read, HeaderLength));
        }

        var tpktLength = BinaryPrimitives.ReadUInt16BigEndian(buffer[2..].Span);
        var packetLength = tpktLength - 7;
        return await _underlyingStream.ReadAsync(buffer[..packetLength], cancellationToken);
    }

    public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
    {
        switch (buffer.Length)
        {
            case <= 0:
                return await _underlyingStream.ReadAsync(buffer, offset, count, cancellationToken);
            case < HeaderLength:
                throw new ArgumentException(BufferLengthExceptionMessage, nameof(buffer));
        }

        var read = await _underlyingStream.ReadAsync(buffer.AsMemory(0, HeaderLength), cancellationToken);
        if (read != HeaderLength)
        {
            throw new Exception(string.Format(InvalidHeaderReadExceptionMessage, read, HeaderLength));
        }
        
        var tpktLength = BinaryPrimitives.ReadUInt16BigEndian(buffer.AsSpan()[2..]);
        var packetLength = tpktLength - HeaderLength;
        return await _underlyingStream.ReadAsync(buffer, 0, packetLength, cancellationToken);
    }
    
    public override int Read(byte[] buffer, int offset, int count)
    {
        switch (buffer.Length)
        {
            case <= 0:
                return _underlyingStream.Read(buffer, offset, count);
            case < HeaderLength:
                throw new ArgumentException(BufferLengthExceptionMessage, nameof(buffer));
        }

        var read = _underlyingStream.Read(buffer, 0, HeaderLength);
        if (read != HeaderLength)
        {
            throw new Exception(string.Format(InvalidHeaderReadExceptionMessage, read, HeaderLength));
        }

        var tpktLength = BinaryPrimitives.ReadUInt16BigEndian(buffer.AsSpan()[2..]);
        var packetLength = tpktLength - HeaderLength;
        return _underlyingStream.Read(buffer, 0, packetLength);
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        var cotpBuffer = ArrayPool<byte>.Shared.Rent(HeaderLength + count);
        try
        {
            WriteTpktHeader(cotpBuffer, buffer.Length);
            WriteCotpHeader(cotpBuffer);
            
            Buffer.BlockCopy(buffer, 0, cotpBuffer, HeaderLength, count);

            _underlyingStream.Write(cotpBuffer, 0, HeaderLength + count);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(cotpBuffer);
        }
    }

    public override async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => 
        await WriteAsync(buffer.AsMemory(offset, count), cancellationToken);

    public override async ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = new())
    {
        var cotpBuffer = ArrayPool<byte>.Shared.Rent(HeaderLength + buffer.Length);
        try
        {
            WriteTpktHeader(cotpBuffer, buffer.Length);
            WriteCotpHeader(cotpBuffer);
            
            // Siemens PLCs hate TCP fragmentation
            // the only way to ensure that the TCP payload does not get fragmented is to combine the header buffer
            // and data into one buffer
            buffer.CopyTo(cotpBuffer.AsMemory(HeaderLength));

            await _underlyingStream.WriteAsync(cotpBuffer.AsMemory(0, HeaderLength + buffer.Length), cancellationToken);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(cotpBuffer);
        }
    }

    private void WriteTpktHeader(Span<byte> header, int dataLength, bool doNotAddHeaderLength = false)
    {
        header[0] = 0x03; // TPKT Version 3
        header[1] = 0x00; // Reserved (always 0)

        var length = dataLength;
        if (!doNotAddHeaderLength)
        {
            length += HeaderLength;
        }
        
        BinaryPrimitives.WriteUInt16BigEndian(header[2..], (ushort)length); // TCP payload length
    }
    
    private void WriteCotpHeader(Span<byte> header)
    {
        header[4] = 0x02; // COTP DT Data length (always 2)
        header[5] = 0xF0; // DT-Data
        header[6] = 0x80; // last data unit: true
    }
    
    private void SerializeConnectionRequest(Span<byte> span, string destinationTsap)
    {
        // span[0] = Encoding.Get // packet length - tpkt header - cotp length byte
        span[1] = 0xE0; // Connection Request
        span.Slice(2, 2).Clear(); // destination ref
        span[5] = 0x55; // random source ref
        span[6] = 0x00; // COTP class
        
        // param 1 (Source TSAP)
        span[7] = 0xC1; // src-tsap
        span[8] = 0x02; // param length
        span[9] = 0x06;
        span[10] = 0x00;
        
        // param 2 (Dest. TSAP)
        span[11] = 0xC2; // dst-tsap
        var stringLength = Encoding.ASCII.GetBytes(destinationTsap, span[13..]);
        span[12] = (byte)(stringLength);

        // param 3. (TPDU size)
        span[13 + stringLength] = 0xC0; // t
                                        // pdu-size
        span[13 + stringLength + 1] = 0x01; // param length
        span[13 + stringLength + 2] = 0x0A; // 1024

        span[0] = (byte)(15 + stringLength);
    }
    
    public override async Task FlushAsync(CancellationToken cancellationToken) => 
        await _underlyingStream.FlushAsync(cancellationToken);

    public override void Flush() => _underlyingStream.Flush();

    public override long Seek(long offset, SeekOrigin origin) => _underlyingStream.Seek(offset, origin);

    public override void SetLength(long value) => _underlyingStream.SetLength(value);
    
    protected override void Dispose(bool disposing) => _underlyingStream.Dispose();

    public override async ValueTask DisposeAsync() => await _underlyingStream.DisposeAsync();
}