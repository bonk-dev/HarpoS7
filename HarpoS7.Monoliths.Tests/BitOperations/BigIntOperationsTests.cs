using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Tests.Utils;

namespace HarpoS7.Monoliths.Tests.BitOperations;

public class BigIntOperationsTests
{
    [Test]
    public void PrepareTest()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath(1, false));
        var expectedDstBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath(1, true));

        var destinationBuffer = new byte[BigIntOperations.PrepareDestinationSize]; 
        BigIntOperations.Prepare(destinationBuffer.AsSpan(), srcBytes.AsSpan());
        
        Assert.That(destinationBuffer, Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    public void FinalizeTest()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath(2, false));
        var expectedDstBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath(2, true));

        var destinationBuffer = new byte[BigIntOperations.FinalizeDestinationSize]; 
        BigIntOperations.Finalize(destinationBuffer.AsSpan(), srcBytes.AsSpan());
        
        Assert.That(destinationBuffer, Is.EqualTo(expectedDstBytes));
    }
}