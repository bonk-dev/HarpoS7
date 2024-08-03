namespace HarpoS7.Monoliths.Utils;

public static class MonolithBufferSizes
{
    internal static readonly int[] SrcSizes =
    [
        0x12 * sizeof(uint),
        0x12 * sizeof(uint),
        0x2A * sizeof(uint),
        0x24 * sizeof(uint),
        0x36 * sizeof(uint),
        0x36 * sizeof(uint),
        0x18 * sizeof(uint),
        0x12 * sizeof(uint),
        0xC5 * sizeof(uint),
        0x12 * sizeof(uint),
        0x1E * sizeof(uint)
    ];
    
    internal static readonly int[] DstSizes =
    [
        0x12 * sizeof(uint),
        0x05 * sizeof(uint),
        0x24 * sizeof(uint),
        0x12 * sizeof(uint),
        0x0C * sizeof(uint),
        0x24 * sizeof(uint),
        0x24 * sizeof(uint),
        0x0F * sizeof(uint),
        0x06 * sizeof(uint),
        0xC0 * sizeof(uint),
        0x05 * sizeof(uint)
    ];

    public static int GetSourceBufferSize(int monolithIndex) => SrcSizes[monolithIndex - 1];
    public static int GetDestinationBufferSize(int monolithIndex) => DstSizes[monolithIndex - 1];
}