using HarpoS7.Monoliths.Transforms;

namespace HarpoS7.Monoliths.Utils;

internal static class TransformBufferSizes
{
    public static int[] SrcSizes { get; } = 
    [
        Transform1.SourceSize,
        Transform2.SourceSize,
        Transform3.SourceSize
    ];
    public static int[] DstSizes { get; } = 
    [
        Transform1.DestinationSize,
        Transform2.DestinationSize,
        Transform3.DestinationSize
    ];
}