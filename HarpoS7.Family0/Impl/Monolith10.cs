using HarpoS7.Monoliths.Exceptions;

namespace HarpoS7.Monoliths.Impl;

public static class Monolith10
{
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> source)
    {
        BufferLengthException.ThrowIfBufferTooSmall(
            nameof(destination), destination, 10);
        BufferLengthException.ThrowIfBufferTooSmall(
            nameof(source), source, 10);
        
        Span<uint> locals = stackalloc uint[301];
        Ten.Part1.Execute(source, locals);
        Ten.Part2.Execute(locals);
        Ten.Part3.Execute(destination, locals);
    }
}