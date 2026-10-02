using HarpoS7.Fingerprint;

namespace HarpoS7.Tests.Fingerprint;

public class FingerprintSpnTests
{
    [Test]
    public void MatchesOriginalNetworkForRandomAndBoundaryChallenges()
    {
        var random = new Random(28);
        for (var sample = 0; sample < 1000; sample++)
        {
            var challenge = new byte[20];
            if (sample == 1) challenge.AsSpan().Fill(255);
            else if (sample > 1) random.NextBytes(challenge);
            var expected = new byte[8];
            var result = new byte[12];
            result.AsSpan().Fill(0xA5);
            HarpoFingerprint.FingerprintChallengeLegacy(expected, challenge);
            HarpoFingerprint.FingerprintChallenge(result, challenge);
            Assert.That(result.Take(8), Is.EqualTo(expected), $"challenge {sample}");
            Assert.That(result.Skip(8), Is.All.EqualTo(0xA5));
        }
    }
}
