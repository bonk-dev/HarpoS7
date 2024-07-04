using HarpoS7.Monoliths.Impl;
using HarpoS7.Monoliths.Tests.Utils;

namespace HarpoS7.Monoliths.Tests.Impl;

public class Monolith1Tests
{
    [Test]
    public void Execute()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetSourcePath(1));
        var dstBytes = File.ReadAllBytes(BlobUtils.GetDestinationPath(1));

        Span<byte> actualDst = stackalloc byte[Monolith1.BufferSize];
        var result = Monolith1.Execute(actualDst, srcBytes.AsSpan());
        
        Assert.That(result, Is.EqualTo(0));
        Assert.That(actualDst.ToArray(), Is.EqualTo(dstBytes));
    }
}