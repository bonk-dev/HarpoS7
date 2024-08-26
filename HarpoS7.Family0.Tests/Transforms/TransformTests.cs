using System.Reflection;
using HarpoS7.Family0.Tests.Utils;
using HarpoS7.Family0.Transforms;
using HarpoS7.Family0.Utils;
using HarpoS7.Utilities.Extensions;

namespace HarpoS7.Family0.Tests.Transforms;

public class TransformTests
{
    [Test]
    [TestCase(nameof(PreSeedTransform), 1)]
    [TestCase(nameof(KeyDerivationTransform), 2)]
    [TestCase(nameof(LutGenerator), 3)]
    [TestCase(nameof(BigIntSquare), 10)]
    [TestCase(nameof(BigIntSquare), 10, 2)]
    [TestCase(nameof(Transform13), 13)]
    public void Execute(string className, int blobIndex, int? subIndex = null)
    {
        var type = typeof(PreSeedTransform)
            .Assembly
            .ExportedTypes
            .SingleOrDefault(t => t.Name == className);
        Assert.That(type, Is.Not.Null);

        var executeMethod = type.GetMethod("Execute", BindingFlags.Public | BindingFlags.Static);
        Assert.That(executeMethod, Is.Not.Null);

        var expectedSrcPath = BlobUtils.GetTransformSourcePath(blobIndex, subIndex);
        var expectedSrcBytes = File.ReadAllBytes(expectedSrcPath);

        var expectedDstPath = BlobUtils.GetTransformDestinationPath(blobIndex, subIndex);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);

        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[blobIndex - 1]];
        
        var executeDelegate = executeMethod.CreateDelegate<TransformExecuteMethodNoReturn>();
        executeDelegate(destinationBuffer, expectedSrcBytes.AsSpan());
        
        // Arrays work better with Is.EqualTo than Span<T> (shows the error index) 
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }

    [Test]
    public void ChecksumTransform()
    {
        var expectedKeyPath = BlobUtils.GetTransformFilePath(4, "key");
        var expectedKeyBytes = File.ReadAllBytes(expectedKeyPath);

        var expectedDstPath = BlobUtils.GetTransformDestinationPath(4);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);
        
        var expectedLutPath = BlobUtils.GetTransformFilePath(4, "lut");
        var expectedLutBytes = File.ReadAllBytes(expectedLutPath);
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[4 - 1]];
        
        Family0.Transforms.ChecksumTransform.Execute(destinationBuffer, expectedKeyBytes.AsSpan(), expectedLutBytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    public void SeedTransform()
    {
        SpanExtensions.StaticFillSequence = [0x2D];
        
        var expectedDstPath = BlobUtils.GetTransformDestinationPath(6);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);
        
        var publicKeyPath = BlobUtils.GetTransformFilePath(6, "publicKey");
        var publicKeyBytes = File.ReadAllBytes(publicKeyPath);
        
        var transform1Path = BlobUtils.GetTransformFilePath(6, "t1");
        var transform1Bytes = File.ReadAllBytes(transform1Path);
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[6 - 1]];
        
        Family0.Transforms.SeedTransform.Execute(destinationBuffer, publicKeyBytes.AsSpan(), transform1Bytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    [TestCase(null)]
    [TestCase(2, Description = "Generic test case")]
    public void ExecuteTransform7(int? subIndex)
    {
        var prng1Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(7, "prng1", subIndex));
        var prng2Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(7, "prng2", subIndex));
        var srcBytes = File.ReadAllBytes(BlobUtils.GetTransformSourcePath(7, subIndex));
        
        var destination = new byte[Transform7.DestinationSize];
        Transform7.Execute(destination.AsSpan(), prng1Bytes.AsSpan(), prng2Bytes.AsSpan(), srcBytes.AsSpan());
        
        var expectedDstBytes = File.ReadAllBytes(BlobUtils.GetTransformDestinationPath(7, subIndex));
        Assert.That(destination, Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    [TestCase(null)]
    [TestCase(2)]
    public void BigIntAddition(int? subIndex)
    {
        var expectedDstPath = BlobUtils.GetTransformDestinationPath(8, subIndex);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);

        var source1Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(8, "source1", subIndex));
        var source2Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(8, "source2", subIndex));
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[8 - 1]];
        destinationBuffer.Clear();
        
        Family0.Transforms.BigIntAddition.Execute(destinationBuffer, source1Bytes.AsSpan(), source2Bytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    [TestCase(null)]
    [TestCase(2)]
    [TestCase(3, Description = "Resulting BigInteger is 19 bytes long, not 20")]
    public void BigIntMultiplication(int? subIndex)
    {
        var expectedDstPath = BlobUtils.GetTransformDestinationPath(9, subIndex);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);

        var source1Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(9, "source1", subIndex));
        var source2Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(9, "source2", subIndex));
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[9 - 1]];
        
        Family0.Transforms.BigIntMultiplication.Execute(destinationBuffer, source1Bytes.AsSpan(), source2Bytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    [TestCase(null)]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    public void BigIntSubtraction(int? subIndex)
    {
        var expectedDstPath = BlobUtils.GetTransformDestinationPath(11, subIndex);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);

        var source1Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(11, "source1", subIndex));
        var source2Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(11, "source2", subIndex));
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[11 - 1]];
        
        Family0.Transforms.BigIntSubtraction.Execute(destinationBuffer, source1Bytes.AsSpan(), source2Bytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    [TestCase(0, 0x772A, 0x7E)]
    [TestCase(0x29, 0xC2B0, 0x67)]
    public void ExecuteTransform12(int blobIndex, int dwordIndex, int count)
    {
        var initialCtx = File.ReadAllBytes(BlobUtils.GetTransformFilePath(12, "ctx", $"0x{blobIndex:X}"));
        Transform12.Execute(initialCtx, dwordIndex, count);
        
        var expectedCtx = File.ReadAllBytes(BlobUtils.GetTransformFilePath(12, "ctx-expected", $"0x{blobIndex:X}"));
        Assert.That(initialCtx, Is.EqualTo(expectedCtx));
    }
    
    private delegate void TransformExecuteMethodNoReturn(Span<byte> destination, ReadOnlySpan<byte> source);
}