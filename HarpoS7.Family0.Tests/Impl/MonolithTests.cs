using System.Reflection;
using HarpoS7.Family0.Impl;
using HarpoS7.Family0.Tests.Utils;
using HarpoS7.Family0.Utils;

namespace HarpoS7.Family0.Tests.Impl;

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
    public void Monolith1Loop()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetMonolithLoopSourcePath(1));
        var dstBytes = File.ReadAllBytes(BlobUtils.GetMonolithLoopDestinationPath(1));

        var actualDst = new byte[MonolithBufferSizes.GetDestinationBufferSize(1)];
        Monolith1.Loop(actualDst.AsSpan(), srcBytes.AsSpan());

        Assert.That(actualDst.ToArray(), Is.EqualTo(dstBytes));
    }

    [Test]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    [TestCase(5)]
    [TestCase(6)]
    [TestCase(7)]
    [TestCase(8)]
    [TestCase(9)]
    [TestCase(10)]
    [TestCase(11)]
    public void ExecuteNoReturn(int monolithIndex)
    {
        var type = typeof(Monolith1)
            .Assembly
            .ExportedTypes
            .SingleOrDefault(t => t.Name == "Monolith" + monolithIndex);
        Assert.That(type, Is.Not.Null);

        var executeMethod = type.GetMethod("Execute", BindingFlags.Public | BindingFlags.Static);
        Assert.That(executeMethod, Is.Not.Null);

        var expectedSrcPath = BlobUtils.GetSourcePath(monolithIndex);
        var expectedSrcBytes = File.ReadAllBytes(expectedSrcPath);

        var expectedDstPath = BlobUtils.GetDestinationPath(monolithIndex);
        var expectedDstBytes = File.ReadAllBytes(expectedDstPath);

        var expectedSrcSize = MonolithBufferSizes.GetSourceBufferSize(monolithIndex);
        Assert.That(
            expectedSrcBytes, Has.Length.EqualTo(expectedSrcSize),
            () => $"The test source blob ({expectedSrcPath}) length was different than expected");
        
        var expectedDstSize = MonolithBufferSizes.GetDestinationBufferSize(monolithIndex);
        Assert.That(
            expectedDstBytes, Has.Length.EqualTo(expectedDstSize),
            () => $"The test destination blob ({expectedDstPath}) length was different than expected");
        
        Span<byte> destinationBuffer = stackalloc byte[MonolithBufferSizes.GetDestinationBufferSize(monolithIndex)];

        var executeDelegate = executeMethod.CreateDelegate<MonolithExecuteMethodNoReturn>();
        executeDelegate(destinationBuffer, expectedSrcBytes.AsSpan());
        
        // Arrays work better with Is.EqualTo than Span<T> (shows the error index) 
        Assert.That(destinationBuffer.ToArray(), Is.EqualTo(expectedDstBytes));
    }

    private delegate void MonolithExecuteMethodNoReturn(Span<byte> destination, ReadOnlySpan<byte> source);
}