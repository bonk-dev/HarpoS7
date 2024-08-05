using System.Diagnostics;
using System.Runtime.InteropServices;
using HarpoS7.Family0.BitOperations;
using HarpoS7.Family0.Tests.Utils;

namespace HarpoS7.Family0.Tests.BitOperations;

public class BigIntOperationsTests
{
    [Test]
    public void PrepareTest()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath("prep", false));
        var expectedDstBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath("prep", true));

        var destinationBuffer = new byte[BigIntOperations.PrepareDestinationSize]; 
        BigIntOperations.Prepare(destinationBuffer.AsSpan(), srcBytes.AsSpan());
        
        Assert.That(destinationBuffer, Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    public void FinalizeTest()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath("finalize", false));
        var expectedDstBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath("finalize", true));

        var destinationBuffer = new byte[BigIntOperations.FinalizeDestinationSize]; 
        BigIntOperations.Finalize(destinationBuffer.AsSpan(), srcBytes.AsSpan());
        
        Assert.That(destinationBuffer, Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    public void PrepareFinalizeMixTest()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath("mixed", false));
        var expectedDstBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath("mixed", true));

        BigIntOperations.PrepareFinalize(srcBytes.AsSpan());
        
        Assert.That(srcBytes, Is.EqualTo(expectedDstBytes));
    }

    [Test]
    [TestCase(
        new byte[]
        {
            0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25,
        },
        new byte[]
        {
            0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0x92, 0xF3
        }
    )]
    public void RotateLeft31Test(byte[] dwords, byte[] expectedRotatedBytes)
    {
        BigIntOperations.RotateLeft31(dwords.AsSpan());
        Assert.That(dwords, Is.EqualTo(expectedRotatedBytes));
    }
}