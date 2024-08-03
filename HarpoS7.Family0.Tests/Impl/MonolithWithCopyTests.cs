using HarpoS7.Monoliths.Impl;
using HarpoS7.Monoliths.Tests.Utils;

namespace HarpoS7.Monoliths.Tests.Impl;

public class MonolithWithCopyTests
{
    [Test]
    public void Monolith3WithCopyTest()
    {
        var in1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(3, false, 1));
        var in2Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(3, false, 2));
        var in3Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(3, false, 3));
        
        var expectedOut1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(3, true, 1));
        var expectedOut2Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(3, true, 2));

        Span<byte> out1Buffer = stackalloc byte[Monolith3.WithCopyOut1Size];
        Span<byte> out2Buffer = stackalloc byte[Monolith3.WithCopyOut2Size];
        Monolith3.WithCopy(
            out1Buffer,
            out2Buffer, 
            in1Bytes.AsSpan(), 
            in2Bytes.AsSpan(),
            in3Bytes.AsSpan()
        );

        var out1Array = out1Buffer.ToArray();
        var out2Array = out2Buffer.ToArray();
        Assert.Multiple(() =>
        {
            Assert.That(out1Array, Is.EqualTo(expectedOut1Bytes));
            Assert.That(out2Array, Is.EqualTo(expectedOut2Bytes));
        });
    }
    
    [Test]
    public void Monolith4WithCopyTest()
    {
        var in1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(4, false, 1));
        var in2Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(4, false, 2));
        
        var expectedOut1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(4, true, 1));

        Span<byte> out1Buffer = stackalloc byte[Monolith3.WithCopyOut1Size];
        Monolith4.WithCopy(
            out1Buffer,
            in1Bytes.AsSpan(), 
            in2Bytes.AsSpan()
        );

        Assert.That(out1Buffer.ToArray(), Is.EqualTo(expectedOut1Bytes));
    }
    
    [Test]
    public void Monolith5WithCopyTest()
    {
        var in1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(5, false, 1));
        var in2Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(5, false, 2));
        var in3Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(5, false, 3));
        
        var expectedOut1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(5, true, 1));
        var expectedOut2Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(5, true, 2));

        Span<byte> out1Buffer = stackalloc byte[Monolith5.WithCopyOut1Size];
        Span<byte> out2Buffer = stackalloc byte[Monolith5.WithCopyOut2Size];
        Monolith5.WithCopy(
            out1Buffer,
            out2Buffer, 
            in1Bytes.AsSpan(), 
            in2Bytes.AsSpan(),
            in3Bytes.AsSpan()
        );

        var out1Array = out1Buffer.ToArray();
        var out2Array = out2Buffer.ToArray();
        Assert.Multiple(() =>
        {
            Assert.That(out1Array, Is.EqualTo(expectedOut1Bytes));
            Assert.That(out2Array, Is.EqualTo(expectedOut2Bytes));
        });
    }
    
    [Test]
    public void Monolith6WithCopyTest()
    {
        var in1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(6, false, 1));
        var in2Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(6, false, 2));
        var in3Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(6, false, 3));
        
        var expectedOut1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(6, true, 1));
        var expectedOut2Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(6, true, 2));

        Span<byte> out1Buffer = stackalloc byte[Monolith6.WithCopyOut1Size];
        Span<byte> out2Buffer = stackalloc byte[Monolith6.WithCopyOut2Size];
        Monolith6.WithCopy(
            out1Buffer,
            out2Buffer, 
            in1Bytes.AsSpan(), 
            in2Bytes.AsSpan(),
            in3Bytes.AsSpan()
        );

        var out1Array = out1Buffer.ToArray();
        var out2Array = out2Buffer.ToArray();
        Assert.Multiple(() =>
        {
            Assert.That(out1Array, Is.EqualTo(expectedOut1Bytes));
            Assert.That(out2Array, Is.EqualTo(expectedOut2Bytes));
        });
    }
    
    [Test]
    public void Monolith7WithCopyTest()
    {
        var in1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(7, false, 1));
        var in2Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(7, false, 2));
        
        var expectedOut1Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(7, true, 1));
        var expectedOut2Bytes = File.ReadAllBytes(BlobUtils.GetWithCopyBlobPath(7, true, 2));

        Span<byte> out1Buffer = stackalloc byte[Monolith7.WithCopyOut1Size];
        Span<byte> out2Buffer = stackalloc byte[Monolith7.WithCopyOut2Size];
        Monolith7.WithCopy(
            out1Buffer,
            out2Buffer, 
            in1Bytes.AsSpan(), 
            in2Bytes.AsSpan()
        );

        var out1Array = out1Buffer.ToArray();
        var out2Array = out2Buffer.ToArray();
        Assert.Multiple(() =>
        {
            Assert.That(out1Array, Is.EqualTo(expectedOut1Bytes));
            Assert.That(out2Array, Is.EqualTo(expectedOut2Bytes));
        });
    }
}