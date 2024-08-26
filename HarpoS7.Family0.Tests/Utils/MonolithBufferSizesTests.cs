using System.Reflection;
using HarpoS7.Family0.Utils;

namespace HarpoS7.Family0.Tests.Utils;

public class MonolithBufferSizesTests
{
    [Test]
    public void HaveSrcSizesAndDstSizesSameLength()
    {
        var fieldSrcSizes = typeof(MonolithBufferSizes)
            .GetField(nameof(MonolithBufferSizes.SrcSizes), BindingFlags.Static | BindingFlags.NonPublic);
        Assert.That(fieldSrcSizes, Is.Not.Null);
        
        var fieldDstSizes = typeof(MonolithBufferSizes)
            .GetField(nameof(MonolithBufferSizes.DstSizes), BindingFlags.Static | BindingFlags.NonPublic);
        Assert.That(fieldDstSizes, Is.Not.Null);
        
        var srcSizesArray = fieldSrcSizes.GetValue(null) as int[];
        Assert.That(srcSizesArray, Is.Not.Null);
        
        var dstSizesArray = fieldDstSizes.GetValue(null) as int[];
        Assert.That(dstSizesArray, Is.Not.Null);
        
        Assert.That(
            srcSizesArray, Has.Length.EqualTo(dstSizesArray.Length), 
            () => $"{nameof(MonolithBufferSizes.SrcSizes)} array and " +
                  $"{nameof(MonolithBufferSizes.DstSizes)} in {nameof(MonolithBufferSizes)} must have the same length");
    }
}