using System.Runtime.InteropServices;
using HarpoS7.Monoliths.Exceptions;

namespace HarpoS7.Monoliths.Impl;

public static class Monolith9
{
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> source)
    {
        BufferLengthException.ThrowIfBufferTooSmall(
            nameof(destination), destination, 9);
        BufferLengthException.ThrowIfBufferTooSmall(
            nameof(source), source, 9);
        
        // It was so big that I had to split it into multiple files (original file was over 22k lines, 1.4 MB)
        Span<uint> locals = stackalloc uint[831];
        Nine.Part1.Execute(source, locals);
        Nine.Part2.Execute(source, locals);
        Nine.Part3.Execute(locals);
        Nine.Part4.Execute(locals);
        Nine.Part5.Execute(locals);
        Nine.Part6.Execute(locals);
        Nine.Part7.Execute(locals);
        Nine.Part8.Execute(locals);
        Nine.Part9.Execute(locals);
        Nine.Part10.Execute(locals);
        Nine.Part11.Execute(destination, locals);
    }
}