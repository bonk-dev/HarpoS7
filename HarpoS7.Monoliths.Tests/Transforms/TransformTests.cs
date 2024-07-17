using System.Reflection;
using HarpoS7.Utilities.Extensions;
using HarpoS7.Monoliths.Tests.Utils;
using HarpoS7.Monoliths.Transforms;
using HarpoS7.Monoliths.Utils;

namespace HarpoS7.Monoliths.Tests.Transforms;

public class TransformTests
{
    [Test]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void Execute(int transformIndex)
    {
        var type = typeof(Transform1)
            .Assembly
            .ExportedTypes
            .SingleOrDefault(t => t.Name == "Transform" + transformIndex);
        Assert.That(type, Is.Not.Null);

        var executeMethod = type.GetMethod("Execute", BindingFlags.Public | BindingFlags.Static);
        Assert.That(executeMethod, Is.Not.Null);

        var expectedSrcPath = BlobUtils.GetTransformSourcePath(transformIndex);
        var expectedSrcBytes = File.ReadAllBytes(expectedSrcPath);

        var expectedDstPath = BlobUtils.GetTransformDestinationPath(transformIndex);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);

        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[transformIndex - 1]];
        
        var executeDelegate = executeMethod.CreateDelegate<TransformExecuteMethodNoReturn>();
        executeDelegate(destinationBuffer, expectedSrcBytes.AsSpan());
        
        // Arrays work better with Is.EqualTo than Span<T> (shows the error index) 
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }

    [Test]
    public void ExecuteTransform4()
    {
        var expectedKeyPath = BlobUtils.GetTransformFilePath(4, "key");
        var expectedKeyBytes = File.ReadAllBytes(expectedKeyPath);

        var expectedDstPath = BlobUtils.GetTransformDestinationPath(4);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);
        
        var expectedLutPath = BlobUtils.GetTransformFilePath(4, "lut");
        var expectedLutBytes = File.ReadAllBytes(expectedLutPath);
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[4 - 1]];
        
        Transform4.Execute(destinationBuffer, expectedKeyBytes.AsSpan(), expectedLutBytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    public void ExecuteTransform6()
    {
        SpanExtensions.StaticFillSequence = [0x2D];
        
        var expectedDstPath = BlobUtils.GetTransformDestinationPath(6);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);
        
        var publicKeyPath = BlobUtils.GetTransformFilePath(6, "publicKey");
        var publicKeyBytes = File.ReadAllBytes(publicKeyPath);
        
        var transform1Path = BlobUtils.GetTransformFilePath(6, "t1");
        var transform1Bytes = File.ReadAllBytes(transform1Path);
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[6 - 1]];
        
        Transform6.Execute(destinationBuffer, publicKeyBytes.AsSpan(), transform1Bytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    private delegate void TransformExecuteMethodNoReturn(Span<byte> destination, ReadOnlySpan<byte> source);
}