using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Tests.Utils;

namespace HarpoS7.Monoliths.Tests.BitOperations;

public class BitOperationsTests
{
    [Test]
    public void BitOperation1Execute()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath(1, false));
        var expectedDstBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath(1, true));

        var destinationBuffer = new byte[BitOperation1.DestinationSize]; 
        BitOperation1.Execute(destinationBuffer.AsSpan(), srcBytes.AsSpan());
        
        Assert.That(destinationBuffer, Is.EqualTo(expectedDstBytes));
    }
    
    [Test]
    public void BitOperation2Execute()
    {
        var srcBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath(2, false));
        var expectedDstBytes = File.ReadAllBytes(BlobUtils.GetBitOperationBlobPath(2, true));

        var destinationBuffer = new byte[BitOperation2.DestinationSize]; 
        BitOperation2.Execute(destinationBuffer.AsSpan(), srcBytes.AsSpan());
        
        Assert.That(destinationBuffer, Is.EqualTo(expectedDstBytes));
    }
}