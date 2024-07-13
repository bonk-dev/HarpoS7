namespace HarpoS7.Monoliths.Data;

/// <summary>
/// Data used in transforms which utilize both the <see cref="Monoliths.Impl.Monolith9"/> and the <see cref="Monoliths.Impl.Monolith10"/>
/// </summary>
public static class SharedData3
{
    public static ReadOnlyMemory<uint> Data { get; } = new uint[]
    {
        0x5ada17af, 0x186de2ba, 0xc32ed8da, 0x9d91eca1, 0x532f0abd, 0x036c7b10, 0xdc07f934, 0x12894e28, 0x43e241d1, 
        0x4252390e, 0x08e98e1a, 0xf3a6c97b, 0xfcdf3515, 0x3269c61c, 0x473ac474, 0x1bdd4082, 0x596be29e, 0x8730edfb
    };
}