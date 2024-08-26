using HarpoS7.Family0.Monoliths;

namespace HarpoS7.Family0.Data;

/// <summary>
/// Data used in transforms which utilize both the <see cref="Monolith9"/> and the <see cref="Monolith10"/>
/// </summary>
public static class SharedData
{
    public static ReadOnlyMemory<uint> Data { get; } = new uint[36]
    {
        0xbc8864fd, 0xeffcb975, 0xf0433f14, 0x20b6407a, 0xe0358644, 0x610806ef, 0xc660cedc, 0xff78c6d5, 0x01af4ae1, 
        0xc5e88fdb, 0x7c0d93f6, 0x2ae2ba51, 0xCBDF8EF1, 0xF5EA1E69, 0xC1C01D1A, 0xF4C52FEB, 0x56A724DE, 0xADF36021,
        0x5ada17af, 0x186de2ba, 0xc32ed8da, 0x9d91eca1, 0x532f0abd, 0x036c7b10, 0xdc07f934, 0x12894e28, 0x43e241d1, 
        0x4252390e, 0x08e98e1a, 0xf3a6c97b, 0xfcdf3515, 0x3269c61c, 0x473ac474, 0x1bdd4082, 0x596be29e, 0x8730edfb
    };
}