using HarpoS7.Integrity;

namespace HarpoS7.Tests.Integrity;

public class HarpoCrc32Tests
{
    [Test]
    public void TestCrc32String()
    {
        string text = "Tag_12";
        var crc = new HarpoCrc32();
            
        crc.Update(text);

        Assert.That(crc.Result, Is.EqualTo(0x0CDF926DU));
    }
}