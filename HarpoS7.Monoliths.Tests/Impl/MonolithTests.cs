using System.Reflection;
using HarpoS7.Monoliths.Impl;
using HarpoS7.Monoliths.Tests.Utils;
using HarpoS7.Monoliths.Utils;

namespace HarpoS7.Monoliths.Tests.Impl;

public class MonolithTests
{
    [Test]
    public void Execute()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetSourcePath(1));
        var dstBytes = File.ReadAllBytes(BlobUtils.GetDestinationPath(1));

        Span<byte> actualDst = stackalloc byte[MonolithBufferSizes.GetDestinationBufferSize(1)];
        var result = Monolith1.Execute(actualDst, srcBytes.AsSpan());
        
        Assert.That(result, Is.EqualTo(0));
        Assert.That(actualDst.ToArray(), Is.EqualTo(dstBytes));
    }

    [Test]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    [TestCase(5)]
    [TestCase(6)]
    public void ExecuteNoReturn(int monolithIndex)
    {
        var type = typeof(Monolith1)
            .Assembly
            .ExportedTypes
            .SingleOrDefault(t => t.Name == "Monolith" + monolithIndex);
        Assert.That(type, Is.Not.Null);

        var executeMethod = type.GetMethod("Execute", BindingFlags.Public | BindingFlags.Static);
        Assert.That(executeMethod, Is.Not.Null);

        var expectedSrcBytes = File.ReadAllBytes(BlobUtils.GetSourcePath(monolithIndex));
        var expectedDstBytes = File.ReadAllBytes(BlobUtils.GetDestinationPath(monolithIndex));
        Span<byte> destinationBuffer = stackalloc byte[MonolithBufferSizes.GetDestinationBufferSize(monolithIndex)];

        var executeDelegate = executeMethod.CreateDelegate<MonolithExecuteMethodNoReturn>();
        executeDelegate(destinationBuffer, expectedSrcBytes.AsSpan());
        
        // Arrays work better with Is.EqualTo than Span<T> (shows the error index) 
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }

    private delegate void MonolithExecuteMethodNoReturn(Span<byte> destination, ReadOnlySpan<byte> source);
}