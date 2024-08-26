using HarpoS7.Family0.Transforms;

namespace HarpoS7.Family0.Utils;

internal static class TransformBufferSizes
{
    public static int[] SrcSizes { get; } = 
    [
        PreSeedTransform.SourceSize,
        KeyDerivationTransform.SourceSize,
        LutGenerator.SourceSize,
        0x00,
        0x00,
        0x00,
        0x00,
        0x00,
        0x00,
        BigIntSquare.SourceSize,
        0x00,
        0x00,
        Transform13.SourceSize
    ];
    public static int[] DstSizes { get; } = 
    [
        PreSeedTransform.DestinationSize,
        KeyDerivationTransform.DestinationSize,
        LutGenerator.DestinationSize,
        ChecksumTransform.DestinationSize,
        0x00,
        SeedTransform.DestinationSize,
        0x00,
        BigIntAddition.DestinationSize,
        BigIntMultiplication.DestinationSize,
        BigIntSquare.DestinationSize,
        BigIntSubtraction.DestinationSize,
        0x00,
        Transform13.DestinationSize
    ];
}