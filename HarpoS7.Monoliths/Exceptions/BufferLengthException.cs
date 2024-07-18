using HarpoS7.Monoliths.Utils;

namespace HarpoS7.Monoliths.Exceptions;

public class BufferLengthException : Exception
{
    public override string Message { get; }

    public BufferLengthException(string argumentName, bool isSourceBuffer, int minimalLength, int actualLength)
    {
        var bufferTypeStr = isSourceBuffer ? "source" : "destination";
        Message = $"The {bufferTypeStr} ({argumentName}) buffer must be at least {minimalLength} bytes long (actual length: {actualLength})";
    }

    public static void ThrowIfBufferTooSmall(string argumentName, ReadOnlySpan<byte> buffer, int monolithIndex)
    {
        var isSourceBuffer = argumentName == "source";
        var minimalLength = isSourceBuffer
            ? MonolithBufferSizes.GetSourceBufferSize(monolithIndex)
            : MonolithBufferSizes.GetDestinationBufferSize(monolithIndex);
        
        if (buffer.Length < minimalLength)
        {
            throw new BufferLengthException(argumentName, isSourceBuffer, minimalLength, buffer.Length);   
        }
    }
}