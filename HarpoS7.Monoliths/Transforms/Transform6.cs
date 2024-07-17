namespace HarpoS7.Monoliths.Transforms;

public static class Transform6
{
    public const int DestinationSize = 0x3C;
    public const int PublicKeyLength = 0x28;
    public const int Transform1Size = Transform1.DestinationSize;
    
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> publicKey, ReadOnlySpan<byte> transform1)
    {
        Span<byte> workBuffer1 = stackalloc byte[0x14];
        throw new NotImplementedException();
    }
}