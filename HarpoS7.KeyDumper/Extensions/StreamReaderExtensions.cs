using HarpoS7.KeyDumper.Exceptions;

namespace HarpoS7.KeyDumper.Extensions;

public static class StreamReaderExtensions
{
    public static async Task<int> ReadLineAsIntAsync(this StreamReader reader, string fieldName = "value")
    {
        var intString = await reader.ReadLineAsync();
        if (!int.TryParse(intString, out var value))
        {
            throw new MalformedKeyFile($"Could not parse {fieldName} as int ({fieldName} string: {intString})");
        }

        return value;
    }
}