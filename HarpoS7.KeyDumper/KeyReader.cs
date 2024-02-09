using System.IO.Compression;
using HarpoS7.KeyDumper.Exceptions;
using HarpoS7.KeyDumper.Extensions;
using HarpoS7.KeyDumper.Models;

namespace HarpoS7.KeyDumper;

public class KeyReader : IDisposable, IAsyncDisposable
{
    private readonly Stream _mpkFileStream;

    public KeyReader(Stream mpkFileStream)
    {
        _mpkFileStream = mpkFileStream;
    }

    public async IAsyncEnumerable<KeyData> EnumerateKeysFromMpkAsync()
    {
        var archive = new ZipArchive(_mpkFileStream, ZipArchiveMode.Read, leaveOpen: true);
        foreach (var keyEntry in archive.Entries)
        {
            await using var keyStream = keyEntry.Open();
            yield return await ReadKeyDataAsync(keyStream);
        }
    }

    internal static async Task<KeyData> ReadKeyDataAsync(Stream uncompressedStream)
    {
        await using var zStream = new ZLibStream(uncompressedStream, CompressionMode.Decompress, leaveOpen: true);
        var reader = new StreamReader(zStream);

        var version = await reader.ReadLineAsIntAsync("version");
        var orderNumber = await reader.ReadLineAsync() ?? throw new MalformedKeyFile("Order number was null");
        
        // this can be empty, but can't be null
        var firmware = await reader.ReadLineAsync() ?? throw new MalformedKeyFile("Firmware version was null");

        const int keyTypeMask = 0b1111_1111;
        const int keyFamilyTypeMask = 0b1111_1111_0000_0000;
        var typeField = (uint)await reader.ReadLineAsIntAsync("type");
        var type = (EKeyType)(typeField & keyTypeMask);
        var familyType = (EKeyFamilyType)((typeField & keyFamilyTypeMask) >> 8);

        var keyData64 = await reader.ReadLineAsync() ?? throw new MalformedKeyFile("Key data was null");
        var certificate64 = await reader.ReadLineAsync() ?? throw new MalformedKeyFile("Cert data was null");
        var signature64 = await reader.ReadLineAsync() ?? throw new MalformedKeyFile("Signature was null");

        return new KeyData(version, orderNumber, firmware, type, familyType, keyData64, certificate64, signature64);
    }

    public void Dispose() => _mpkFileStream.Dispose();

    public async ValueTask DisposeAsync() => await _mpkFileStream.DisposeAsync();
}