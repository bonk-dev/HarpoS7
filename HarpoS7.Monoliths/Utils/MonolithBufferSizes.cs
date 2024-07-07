namespace HarpoS7.Monoliths.Utils;

public static class MonolithBufferSizes
{
    private static readonly int[] SrcSizes =
    [
        0x12 * sizeof(uint),
        0x12 * sizeof(uint)
    ];
    
    private static readonly int[] DstSizes =
    [
        0x12 * sizeof(uint),
        0x5 * sizeof(uint)
    ];

    public static int GetSourceBufferSize(int monolithIndex) => SrcSizes[monolithIndex - 1];
    public static int GetDestinationBufferSize(int monolithIndex) => DstSizes[monolithIndex - 1];
}