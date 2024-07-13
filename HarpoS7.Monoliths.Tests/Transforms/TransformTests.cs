using System.Reflection;
using HarpoS7.Monoliths.Tests.Utils;
using HarpoS7.Monoliths.Transforms;
using HarpoS7.Monoliths.Utils;

namespace HarpoS7.Monoliths.Tests.Transforms;

public class TransformTests
{
    [Test]
    [TestCase(1)]
    [TestCase(2)]
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
    
    private delegate void TransformExecuteMethodNoReturn(Span<byte> destination, ReadOnlySpan<byte> source);
}