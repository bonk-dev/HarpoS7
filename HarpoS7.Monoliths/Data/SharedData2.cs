namespace HarpoS7.Monoliths.Data;

/// <summary>
/// Data used in transforms which utilize both the <see cref="Monoliths.Impl.Monolith9"/> and the <see cref="Monoliths.Impl.Monolith10"/>
/// </summary>
public static class SharedData2
{
    public static ReadOnlyMemory<uint> Data { get; } = new uint[]
    {
        0xbc8864fd, 0xeffcb975, 0xf0433f14, 0x20b6407a, 0xe0358644, 0x610806ef, 0xc660cedc, 0xff78c6d5, 0x01af4ae1, 
        0xc5e88fdb, 0x7c0d93f6, 0x2ae2ba51
    };
}