using HarpoS7.Monoliths.Transforms;

namespace HarpoS7.Monoliths.Utils;

internal static class TransformBufferSizes
{
    public static int[] SrcSizes { get; } = 
    [
        Transform1.SourceSize
    ];
    public static int[] DstSizes { get; } = 
    [
        Transform1.DestinationSize
    ];
}