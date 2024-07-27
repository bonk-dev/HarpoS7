using System.Numerics;
using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Exceptions;
using HarpoS7.Monoliths.Utils;

namespace HarpoS7.Monoliths.Transforms;

public static class Transform10
{
    public const int DestinationSize = BitOperation2.DestinationSize;
    public const int SourceSize = BitOperation1.SourceSize;
    
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> source)
    {
        if (destination.Length < DestinationSize)
        {
            throw new BufferLengthException(
                nameof(destination), false, DestinationSize, destination.Length);
        }
        if (source.Length < SourceSize)
        {
            throw new BufferLengthException(
                nameof(source), true, SourceSize, source.Length);
        }
        
        Span<byte> op1Buffer = stackalloc byte[BitOperation1.DestinationSize];
        BitOperation1.Execute(op1Buffer, source);

        var baseInt = new BigInteger(op1Buffer, isUnsigned: true, isBigEndian: false);
        var result = BigInteger.Pow(baseInt, 2);

        var length = result.GetByteCount();
        Span<byte> productBuffer = stackalloc byte[length];
        _ = result.TryWriteBytes(productBuffer, out _, isUnsigned: true, isBigEndian: false);

        if (BigIntegerCompressor.Compress(productBuffer[..length], out length) && 
            BigIntegerCompressor.Compress(productBuffer[..length], out length))
        {
            BigIntegerCompressor.FinalCompress(productBuffer[..length]);
        }
        
        BitOperation2.Execute(destination, productBuffer[..length]);
    }
}