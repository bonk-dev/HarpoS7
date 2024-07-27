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
    [TestCase(10)]
    [TestCase(10, 2)]
    public void Execute(int transformIndex, int? subIndex = null)
    {
        var type = typeof(Transform1)
            .Assembly
            .ExportedTypes
            .SingleOrDefault(t => t.Name == "Transform" + transformIndex);
        Assert.That(type, Is.Not.Null);

        var executeMethod = type.GetMethod("Execute", BindingFlags.Public | BindingFlags.Static);
        Assert.That(executeMethod, Is.Not.Null);

        var expectedSrcPath = BlobUtils.GetTransformSourcePath(transformIndex, subIndex);
        var expectedSrcBytes = File.ReadAllBytes(expectedSrcPath);

        var expectedDstPath = BlobUtils.GetTransformDestinationPath(transformIndex, subIndex);
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
    
    [Test]
    [TestCase(null)]
    [TestCase(2)]
    public void ExecuteTransform8(int? subIndex)
    {
        var expectedDstPath = BlobUtils.GetTransformDestinationPath(8, subIndex);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);

        var source1Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(8, "source1", subIndex));
        var source2Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(8, "source2", subIndex));
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[8 - 1]];
        destinationBuffer.Clear();
        
        Transform8.Execute(destinationBuffer, source1Bytes.AsSpan(), source2Bytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    [TestCase(null)]
    [TestCase(2)]
    public void ExecuteTransform9(int? subIndex)
    {
        var expectedDstPath = BlobUtils.GetTransformDestinationPath(9, subIndex);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);

        var source1Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(9, "source1", subIndex));
        var source2Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(9, "source2", subIndex));
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[9 - 1]];
        
        Transform9.Execute(destinationBuffer, source1Bytes.AsSpan(), source2Bytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    public void ExecuteTransform11()
    {
        var expectedDstPath = BlobUtils.GetTransformDestinationPath(11);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);

        var source1Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(11, "source1"));
        var source2Bytes = File.ReadAllBytes(BlobUtils.GetTransformFilePath(11, "source2"));
        
        Span<byte> destinationBuffer = stackalloc byte[TransformBufferSizes.DstSizes[11 - 1]];
        
        Transform11.Execute(destinationBuffer, source1Bytes.AsSpan(), source2Bytes.AsSpan());
        
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    [TestCase(0, 0x772A, 0x7E)]
    public void ExecuteTransform12(int blobIndex, int dwordIndex, int count)
    {
        var initialCtx = File.ReadAllBytes(BlobUtils.GetTransformFilePath(12, "ctx"));
        Transform12.Execute(initialCtx, dwordIndex, count);
        
        var expectedCtx = File.ReadAllBytes(BlobUtils.GetTransformFilePath(12, "ctx-expected"));
        Assert.That(initialCtx, Is.EqualTo(expectedCtx));
    }
    
    private delegate void TransformExecuteMethodNoReturn(Span<byte> destination, ReadOnlySpan<byte> source);
}