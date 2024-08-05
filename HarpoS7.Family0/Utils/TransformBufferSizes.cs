using HarpoS7.Family0.Transforms;

namespace HarpoS7.Family0.Utils;

internal static class TransformBufferSizes
{
    public static int[] SrcSizes { get; } = 
    [
        Transform1.SourceSize,
        Transform2.SourceSize,
        Transform3.SourceSize,
        0x00,
        0x00,
        0x00,
        0x00,
        0x00,
        0x00,
        Transform10.SourceSize,
        0x00,
        0x00,
        Transform13.SourceSize
    ];
    public static int[] DstSizes { get; } = 
    [
        Transform1.DestinationSize,
        Transform2.DestinationSize,
        Transform3.DestinationSize,
        Transform4.DestinationSize,
        0x00,
        Transform6.DestinationSize,
        0x00,
        Transform8.DestinationSize,
        Transform9.DestinationSize,
        Transform10.DestinationSize,
        Transform11.DestinationSize,
        0x00,
        Transform13.DestinationSize
    ];
}