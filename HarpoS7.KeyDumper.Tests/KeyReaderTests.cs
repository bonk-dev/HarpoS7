using System.Reflection;
using HarpoS7.KeyDumper.Models;

namespace HarpoS7.KeyDumper.Tests;

public class KeyReaderTests
{
    public static IEnumerable<TestCaseData> SingleKeyFileCases
    {
        get
        {
            const string file64 = @"eF6dVEuvskgQ3d/k/hIyw0MQXNxFtzSvtnkjj50gIiCKCrTw68d7v2Qm+TKLySxOdaXqLE6qTjX/
                        +bFGgSzw/B88QCL3B5dA7vNjL/75joIkf36s7hzkRQ9JvEsrxHmOM/m5wyQ1WdSXeE92Vkkkhg3H
                        KQK7HWBCRfQx+Pr6/CCmqR7D7RZchApQE4LKhNsF2LBq7+e21jeUg8CLNKDCmnhPuvVSde95OqIW
                        8kMUEAh0wEcIvogVXvdzFvN1llhX4hOKfnExon14iPdDFkuLiTSDeBzd0p/eDlHfMtEFEv9J9V98
                        Fb2sf/iab3kBVN+ISWhS41zY7/f1hkRUQL8R/9TIizQ/4J0wkuIGdv9B76Xo/q9ehRp/681+1+vl
                        K4tLY1rtGzS/ZwzN5veZIg0AZws8BXz3txV+5whMIyO2rjvxi6ayj8dGjZcmPnu2hhJ/DegQuZnh
                        BYZCFgx9JVx14hTPcnnfpYrnzKXcyUZs00WdUyjETno9lHnP8eTk9GOSvjbp2BYVzvZypupdGqp8
                        485cwNMRJt1NHmbGtoLw7LvwWYVXBjXqs+pvAZL59eDkbNO4G32FnlmibHw3LyxrdV+JhsrnJGOJ
                        ZR4GgeJ1WqBD6WJghk4v3UY/850rB1taPSDdR9m+Rb3TzI4dzA8caC/Xz+O4F/ynNdmAX/Virm09
                        384Bmrj+bafyuGOECY9H7XAQ2QNnzeflShTDXt9VQ2NXEwZ1yGRZqndDJczaqXgAiYsufjgdpKOs
                        zsnGM1XgAXhbzG+/WLCy94ZPEGgAIED89sNRpQiy9L0AahqVCsIfThAhVQUYVm/pFdKgV6jg327j
                        Z48IRK+rGLvQlPPsWnpkt+mWPG70puwWHLq6XuGncsrK3G5EEGGrI9h0yENiZ72P9y13Hy9H1egz
                        qPA5Zz5Xgs9MQWGz53sMhPpuHNdJBOQjE2ED01Q/mk9GYoMNfvCK6CTWEM9qqNUJtoQSjfFBs6Uz
                        M6BDNXtuGNXEaAcMu+pG5JZUZFi24nOOLMKn29twF9j5wJUWYFmwDt2hrc1z/M6HpIdFjHhV23Cn
                        29nSxKyK5ueRELnvdsew3j6EiZ6O9zvNObj3u+dj1DpTm85B2uzg1WChGD0izO2VluPiY/EUaCPt
                        mM0NuDyrTN5mN2V5AutD+Dro7Uavu0C4TuQa8o9Hj8NjNvz8Un03LhRXfikgLZ1b0Ka7cbO5TueI
                        XPuxAJt6HAyLa7xUXq2arjr3zMXkYcNJxlTfqqtyDioFRH1qsUlH1nbdsy91L86M2qRyOZWVfT0p
                        oM5C5Li9MmuUPE7ztNoGt5GjYvcCrX5v1tgZWYyfjoOt6vQqqoKKcFyYczOJffgQhwd6pDE646Ej
                        /hFjdxu0llumEnCldMjxvXIcztoKOl9f3s7ojduhFTKdn3ZnE+yvXr/HwoX4ac3TnVw0hsdHh2QF
                        mWmQo7U0ylYiRENAEWvlBWB1lOQXx0zhWg3abFfoyowOrJY1aZJadlsIQ/ncLPZltLDZbddYzo+r
                        ZuaX0hdNdjFGOldfX38BGu8PIw==";
            var expected = new KeyData(
                1,
                "6ES7211-1AE40-0XB0",
                "V4.0", 
                EKeyType.CpuKey, 
                EKeyFamilyType.S71200, 
                "3q0B14QE51PwgE0QOOvRbO+XiMzDx4qXLJeM5+/TuvUALLA+T84RKA==",
                "MIIDdTCCAl2gAwIBAgIBCzANBgkqhkiG9w0BAQUFADBiMQswCQYDVQQGEwJERTESMBAGA1UEBxMJTnVyZW1iZXJnMRMwEQYDVQQKEwpTaWVtZW5zIEFHMQ0wCwYDVQQLEwRJIElBMRswGQYDVQQDExJTaWVtZW5zIFRJQSBDQSBWMTIwHhcNMTIxMTI5MDAwMDAwWhcNMTMxMjMxMjM1OTU5WjBmMQswCQYDVQQGEwJERTESMBAGA1UEBxMJTnVlcm1iZXJnMRMwEQYDVQQKEwpTaWVtZW5zIEFHMQ0wCwYDVQQLEwRJIElBMR8wHQYDVQQDExZTaWVtZW5zIFRJQSBQb3J0YWwgVjEyMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvu+4kPPv1zFD/rr9DWzjWhQNFEXR6AwtUPZHQSH8MzKBR8T3m4vWy7eqLY8QOye7m7HWNwzDyYB2WOYnaebp01MfOpuXYx9YukcgKZV7ZDGmYTD1jPy0S1wuBXmo7ty+NJSThRPBsgTn+EjDsgpoSE716tOb/jjP9G3EsZX89RPbcJJ3q34HD1bMZ/MJIat2wK6YcEaePKAITOp5ouRZROn0BkwgrBwVUZVkEpOjyONSyrKSFxPRbWWp2RsJvNA13p4bFCQRNbAEv0pZW1edL+2vKudFaa4/a0JyhznM8HN6qDHF/3vKAiT+ZZYGmtg2yFfcrA50UlRTva5d7DyX9QIDAQABozIwMDAJBgNVHRMEAjAAMA4GA1UdDwEB/wQEAwIHgDATBgNVHSUEDDAKBggrBgEFBQcDAzANBgkqhkiG9w0BAQUFAAOCAQEAUxn4WPBI7bZneQML9mzbWjGjemzKTPGGgKs8fZebNj4AUKJmMKIOMr5/yGpWVk0quldDHpZB81b0Is32R+vScN/hqWA2iqHd6XUA7d+UKHKwYGdIs+5/S9Kr184OXJtWyDTFiXKJ2eEuWaFN5h+tEagyQPTUiMHktKBmgoM7kMgMtzC4syUJM1YCotq2/ya0eJA//A6TPtkiIhW//AtXpBcWE1DF90fohJF4ZgUysdMM7pmLdTiCr2vwfdqqwb0BVRmsruFmIFvhSYjLBnH/B4UrUK0V8k00Wdcs2wj5L+9oAP1/8vQ9LvZbXBiaTxaGk9GimS2nvMnT1rrpKTdZtA==",
                "pmuzwKgRe2EFYykAkYLu99nvhUMnpucA9iutHJ0jQY733jmghp+lI1Bj05Hviogn8hSg8AUpYJ/XmM6Nip/xDV4y+DjY7evegNnf8AiZTEOPp8yFwMrfyv3CSou0w4mxAkGqj6KOu/KKsOOKJgfxcgcw4Buz+hjv4pTr4trErYWEhKtmMRdKKPCSkJPeY5AP5YtbKqgOO0JC2G1ilmzbpHoak2ZG1vLhIAVnQpVK2lMRYi1wL7cjHQ1UaX3B+vt7U65u7JX2UtSwE/JbcA/GEXblOIYB6DSkZLcG8yEa/FZjYXYJNkc2tes9zNluJKImC6K7bd3jy1zeR4I/zHuwyg==");
            yield return new TestCaseData(file64, expected);
        }
    }

    public static IEnumerable<TestCaseData> MpkTestCases
    {
        get
        {
            var assembly = Assembly.GetExecutingAssembly();

            // cant dispose when yielding
            var stream = assembly.GetManifestResourceStream("HarpoS7.KeyDumper.Tests.MpkSamples.sample.mpk")!;
            var expected = new KeyData[]
            {
                new(
                    1,
                    "6ES7211-1AE40-0XB0",
                    "V4.0",
                    EKeyType.CpuKey,
                    EKeyFamilyType.S71200,
                    "3q0B14QE51PwgE0QOOvRbO+XiMzDx4qXLJeM5+/TuvUALLA+T84RKA==",
                    "MIIDdTCCAl2gAwIBAgIBCzANBgkqhkiG9w0BAQUFADBiMQswCQYDVQQGEwJERTESMBAGA1UEBxMJTnVyZW1iZXJnMRMwEQYDVQQKEwpTaWVtZW5zIEFHMQ0wCwYDVQQLEwRJIElBMRswGQYDVQQDExJTaWVtZW5zIFRJQSBDQSBWMTIwHhcNMTIxMTI5MDAwMDAwWhcNMTMxMjMxMjM1OTU5WjBmMQswCQYDVQQGEwJERTESMBAGA1UEBxMJTnVlcm1iZXJnMRMwEQYDVQQKEwpTaWVtZW5zIEFHMQ0wCwYDVQQLEwRJIElBMR8wHQYDVQQDExZTaWVtZW5zIFRJQSBQb3J0YWwgVjEyMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvu+4kPPv1zFD/rr9DWzjWhQNFEXR6AwtUPZHQSH8MzKBR8T3m4vWy7eqLY8QOye7m7HWNwzDyYB2WOYnaebp01MfOpuXYx9YukcgKZV7ZDGmYTD1jPy0S1wuBXmo7ty+NJSThRPBsgTn+EjDsgpoSE716tOb/jjP9G3EsZX89RPbcJJ3q34HD1bMZ/MJIat2wK6YcEaePKAITOp5ouRZROn0BkwgrBwVUZVkEpOjyONSyrKSFxPRbWWp2RsJvNA13p4bFCQRNbAEv0pZW1edL+2vKudFaa4/a0JyhznM8HN6qDHF/3vKAiT+ZZYGmtg2yFfcrA50UlRTva5d7DyX9QIDAQABozIwMDAJBgNVHRMEAjAAMA4GA1UdDwEB/wQEAwIHgDATBgNVHSUEDDAKBggrBgEFBQcDAzANBgkqhkiG9w0BAQUFAAOCAQEAUxn4WPBI7bZneQML9mzbWjGjemzKTPGGgKs8fZebNj4AUKJmMKIOMr5/yGpWVk0quldDHpZB81b0Is32R+vScN/hqWA2iqHd6XUA7d+UKHKwYGdIs+5/S9Kr184OXJtWyDTFiXKJ2eEuWaFN5h+tEagyQPTUiMHktKBmgoM7kMgMtzC4syUJM1YCotq2/ya0eJA//A6TPtkiIhW//AtXpBcWE1DF90fohJF4ZgUysdMM7pmLdTiCr2vwfdqqwb0BVRmsruFmIFvhSYjLBnH/B4UrUK0V8k00Wdcs2wj5L+9oAP1/8vQ9LvZbXBiaTxaGk9GimS2nvMnT1rrpKTdZtA==",
                    "pmuzwKgRe2EFYykAkYLu99nvhUMnpucA9iutHJ0jQY733jmghp+lI1Bj05Hviogn8hSg8AUpYJ/XmM6Nip/xDV4y+DjY7evegNnf8AiZTEOPp8yFwMrfyv3CSou0w4mxAkGqj6KOu/KKsOOKJgfxcgcw4Buz+hjv4pTr4trErYWEhKtmMRdKKPCSkJPeY5AP5YtbKqgOO0JC2G1ilmzbpHoak2ZG1vLhIAVnQpVK2lMRYi1wL7cjHQ1UaX3B+vt7U65u7JX2UtSwE/JbcA/GEXblOIYB6DSkZLcG8yEa/FZjYXYJNkc2tes9zNluJKImC6K7bd3jy1zeR4I/zHuwyg=="
                ),
                new(
                    1,
                    "s71200",
                    string.Empty,
                    EKeyType.FamilyKey,
                    EKeyFamilyType.S71200,
                    "bHHtj8wa6UFyBAoUuLGvdQG4Hky5mTdJFpEHUQkwCGZVcTbIroSMrQ==",
                    "MIIDdTCCAl2gAwIBAgIBCzANBgkqhkiG9w0BAQUFADBiMQswCQYDVQQGEwJERTESMBAGA1UEBxMJTnVyZW1iZXJnMRMwEQYDVQQKEwpTaWVtZW5zIEFHMQ0wCwYDVQQLEwRJIElBMRswGQYDVQQDExJTaWVtZW5zIFRJQSBDQSBWMTIwHhcNMTIxMTI5MDAwMDAwWhcNMTMxMjMxMjM1OTU5WjBmMQswCQYDVQQGEwJERTESMBAGA1UEBxMJTnVlcm1iZXJnMRMwEQYDVQQKEwpTaWVtZW5zIEFHMQ0wCwYDVQQLEwRJIElBMR8wHQYDVQQDExZTaWVtZW5zIFRJQSBQb3J0YWwgVjEyMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvu+4kPPv1zFD/rr9DWzjWhQNFEXR6AwtUPZHQSH8MzKBR8T3m4vWy7eqLY8QOye7m7HWNwzDyYB2WOYnaebp01MfOpuXYx9YukcgKZV7ZDGmYTD1jPy0S1wuBXmo7ty+NJSThRPBsgTn+EjDsgpoSE716tOb/jjP9G3EsZX89RPbcJJ3q34HD1bMZ/MJIat2wK6YcEaePKAITOp5ouRZROn0BkwgrBwVUZVkEpOjyONSyrKSFxPRbWWp2RsJvNA13p4bFCQRNbAEv0pZW1edL+2vKudFaa4/a0JyhznM8HN6qDHF/3vKAiT+ZZYGmtg2yFfcrA50UlRTva5d7DyX9QIDAQABozIwMDAJBgNVHRMEAjAAMA4GA1UdDwEB/wQEAwIHgDATBgNVHSUEDDAKBggrBgEFBQcDAzANBgkqhkiG9w0BAQUFAAOCAQEAUxn4WPBI7bZneQML9mzbWjGjemzKTPGGgKs8fZebNj4AUKJmMKIOMr5/yGpWVk0quldDHpZB81b0Is32R+vScN/hqWA2iqHd6XUA7d+UKHKwYGdIs+5/S9Kr184OXJtWyDTFiXKJ2eEuWaFN5h+tEagyQPTUiMHktKBmgoM7kMgMtzC4syUJM1YCotq2/ya0eJA//A6TPtkiIhW//AtXpBcWE1DF90fohJF4ZgUysdMM7pmLdTiCr2vwfdqqwb0BVRmsruFmIFvhSYjLBnH/B4UrUK0V8k00Wdcs2wj5L+9oAP1/8vQ9LvZbXBiaTxaGk9GimS2nvMnT1rrpKTdZtA==",
                    "ANPpxffqe6zm5EJiuwg7hfzYAgQ+N/cl0Alz7on+nOpuYd3D/IQDKcppejbQVlEflNUc0b8PH72qCHpYyrIRBlWPSRgXRulu96csET9JRbek6ZCx7VpKe+xJsgh4xGMN2M6GdkCbp/S1psBY/9CRxviA+hmZ76Mnv5C/zPxcJsvxpr4POv2/BPrRiGddXjFAeJOdbkR3kWdDLqvQZLXOQWHvYQrMOvo7kRxUN0lZE4wQPaOInY3bGUmuKEarpPUu8JT08StBeZLDY2tB0XpICg2ekrRXsYzU4y1j7u0dCAvqvte8KmvIuryvogR1eiS+R8InxNm4B2zmEY6SrS0ckA=="
                )
            };

            yield return new TestCaseData(stream, expected);
        }
    }
    
    [Test]
    [TestCaseSource(nameof(SingleKeyFileCases))]
    public async Task ReadKeyDataAsyncTest(string singleKeyFileBase64, KeyData expected)
    {
        var buffer = Convert.FromBase64String(singleKeyFileBase64);
        using var stream = new MemoryStream(buffer);
        var actual = await KeyReader.ReadKeyDataAsync(stream);
        
        CompareKeyData(actual, expected);
    }

    [Test]
    [TestCaseSource(nameof(MpkTestCases))]
    public async Task EnumerateKeysFromMpkAsyncTest(Stream mpkFileStream, KeyData[] expected)
    {
        var reader = new KeyReader(mpkFileStream);

        await foreach (var data in reader.EnumerateKeysFromMpkAsync())
        {
            var expectedData = expected.FirstOrDefault(e => e.Signature64 == data.Signature64);
            Assert.That(expectedData, Is.Not.Null, "Deserialized key data was not found in the expected set");
            
            CompareKeyData(data, expectedData!);
        }
    }

    private static void CompareKeyData(KeyData actual, KeyData expected)
    {
        Assert.Multiple(() =>
        {
            Assert.That(actual.Version, Is.EqualTo(expected.Version), "Key versions are not equal");
            Assert.That(actual.OrderNumber, Is.EqualTo(expected.OrderNumber), "Order numbers are not equal");
            Assert.That(actual.FirmwareVersion, Is.EqualTo(expected.FirmwareVersion), "Firmware versions are not equal");
            Assert.That(actual.Type, Is.EqualTo(expected.Type), "Key types are not equal");
            Assert.That(actual.FamilyType, Is.EqualTo(expected.FamilyType), "Key family types are not equal");
            Assert.That(actual.KeyData64, Is.EqualTo(expected.KeyData64), "Keys' data are not equal");
            Assert.That(actual.Certificate64, Is.EqualTo(expected.Certificate64), "Keys' certificate data are not equal");
            Assert.That(actual.Signature64, Is.EqualTo(expected.Signature64), "Keys' signature data are not equal");
        });
    }
}