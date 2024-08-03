using System.Runtime.InteropServices;

namespace HarpoS7.Monoliths.Impl.Ten;

/// <summary>
/// Ends at line 2200
/// </summary>
internal static class Part1
{
    public static void Execute(ReadOnlySpan<byte> source, Span<uint> locals)
    {
        var src = MemoryMarshal.Cast<byte, uint>(source);
        locals[11] = src[0xe];
        locals[7] = src[0xd];
        locals[103] = src[0xc];
        locals[12] = src[8];
        locals[8] = src[1];
        locals[178] = (((locals[11] & 0x59520000 ^ 0x1b4f0000) & locals[7] ^ locals[11] & 0x35650000 ^ 0xaeaaffff) &
                       locals[103] ^ (locals[11] & 0x686f0000 ^ 0xc6d8ffff) & locals[7] ^ locals[11] & 0x400000 ^
                       0x1d9a0000)
                      >> 0x10;
        locals[24] = src[5];
        locals[9] = src[0];
        locals[179] = ((locals[24] & 0xe4b0d496 ^ 0x70086866) & src[4] ^ locals[24] & 0xc9180942 ^ 0x59002022) &
                      src[3];
        locals[140] = (locals[24] & 0x75aa3baa ^ 0x60002362) & src[4];
        locals[13] = (src[7] & 0x86d79411 ^ locals[12] & 0x86771499 ^ 0x84b29498) & src[6] ^
                     (locals[12] & 0x4e79499 ^ 0x86d01411) & src[7] ^ locals[12] & 0x420089 ^ 0x4928011;
        locals[99] = ((~(src[7] & 0xdfdfff77) ^ src[8] & 0xb77f3dfb) & src[6] ^ src[8] & 0x2008a ^ 0xc92c210)
            & 0xecb2d69e ^ (src[8] & 0x6ca2d69e ^ 0xc4905414) & src[7];
        locals[12] = ~((src[1] & locals[13] ^ locals[24] & 0x4880d21c ^ locals[140] ^ locals[179] ^ 0x49004a24) &
                       locals[9]) ^
                     locals[99] & locals[24] & locals[8];
        locals[233] = src[9];
        locals[234] = src[0x10];
        locals[23] = src[0x11];
        locals[100] = (((locals[11] & 0xffffaaca ^ 0xffffff34) & locals[7] ^ locals[11] & 0xffff8a8b ^ 0xffffd6ae) &
                       locals[103] ^ (locals[11] & 0xffffaba9 ^ 0xffffeb51) & locals[7] ^ locals[11] & 0x74fe ^
                       0xffffeb51) <<
                      0x10;
        locals[1] = (locals[233] & 0x86b5ffff ^ 0x2500000) & locals[23];
        locals[22] = src[0xf];
        locals[14] =
            (((locals[233] ^ 0x62100000) & locals[234] ^ (locals[233] ^ 0xeb5affff) & 0x54a50000) & 0xf6bdffff ^
             (locals[233] & 0xa6bdffff ^ 0x22500000) & locals[23]) & locals[22];
        locals[2] = locals[23] & 0xffb0000;
        locals[104] = src[0xb];
        locals[15] = (locals[234] & 0x56b90000 ^ locals[2] ^ 0x5da30000) & locals[22];
        locals[3] = locals[104] >> 0x10;
        locals[4] = locals[233] & 0x56b90000 ^ 0x42500000;
        locals[60] = src[10];
        locals[232] = locals[233] >> 0x10;
        locals[101] = locals[23] >> 0x10;
        locals[180] = locals[234] >> 0x10;
        locals[102] = (locals[233] ^ 0x6f30000) & locals[23] & 0xffb0000;
        locals[141] = (((locals[232] ^ 0xffffdff7) & locals[180] & 0xfffff6bd ^
                        (locals[232] ^ 0xffffd6f7) & locals[101] ^
                        0x4a7) & 0xafff ^ locals[233] >> 0x10 & 0xda7) & locals[22] >> 0x10;
        locals[16] = ~locals[232] & locals[101] & 0x86f7;
        locals[17] = locals[233] & 0xd210ffff ^ locals[2];
        locals[59] = ((((locals[101] ^ 0xffffe254) & locals[180] ^ 0xffffef37) & 0x5ffb ^
                       (locals[23] & 0x6f30000 ^ locals[15]) >> 0x10) & locals[3] ^
                      (~(locals[232] & 0xffffffbf) & 0x6250 ^ (locals[4] & locals[23]) >> 0x10) & locals[180] ^
                      ((locals[233] ^ 0x42100000) & 0xc631ffff ^ locals[1] ^ locals[14]) >> 0x10) & locals[60] >> 0x10 ^
                     (((locals[17] ^ 0x3b960000) & locals[234] ^ (locals[233] & 0x8b50ffff ^ 0x20cc0000) & locals[23] ^
                       locals[233] & 0x59000000 ^ 0x10840000) & locals[22] ^
                      (locals[233] & 0x8250ffff ^ 0xc40000) & locals[23] ^ locals[233] & 0x4de70000) >> 0x10 ^
                     ((((locals[233] ^ 0x2500000) & 0x22500000 ^ locals[102]) & locals[234] ^
                       (locals[233] ^ 0xf6ffffff) & 0x8f33ffff) >> 0x10 ^ locals[16] ^ locals[141]) & locals[3] ^
                     (((locals[233] & 0x5b500000 ^ 0x49c00000) & locals[23]) >> 0x10 ^
                      ~(locals[232] & 0xffffcf77) & 0x72d8) & locals[180];
        locals[18] = (((locals[11] & 0xffffaaca ^ 0x3d30) & locals[7] ^ locals[11] & 0xffff8321 ^ 0x30) & locals[103] ^
                      (locals[11] & 0xffff8a41 ^ 0x4073) & locals[7] ^ locals[11] & 0x7555) << 0x10;
        locals[19] = (((locals[11] & 0x4926 ^ 0x1412) & locals[7] ^ locals[11] & 0x5414 ^ 0x3dfb) & locals[103] ^
                      (locals[11] & 3 ^ 0xffff9f04) & locals[7] ^ locals[11] & 0xffffcb72) << 0x10;
        locals[20] = (((locals[11] & 0x808fffff ^ 0xfdb7ffff) & locals[7] ^ locals[11] & 0xa73fffff ^ 0xf5e8ffff) &
            locals[103] ^ (locals[11] & 0x79200000 ^ 0xc802ffff) & locals[7] ^ locals[11] & 0xd900000) >> 0x10;
        locals[10] = src[7];
        locals[61] = src[8];
        locals[6] = src[8];
        locals[5] = src[8];
        locals[21] = src[5];
        locals[13] = (((locals[10] & 0x8fdf4f57 ^ locals[61] & 0xa7770ddb ^ 0xacb2469e) & src[6] ^
                       (locals[61] & 0x2def4e9f ^ 0x86d84455) & locals[10] ^ locals[61] & 0x4a018b ^ 0xd9a4b51) &
                      src[5] ^
                      ((locals[61] & 0xa6353cf2 ^ locals[10] & 0xd69ddc76 ^ 0xe4b0d496) & src[6] ^
                       (src[8] & 0x74adfc96 ^ 0xc6987454) & locals[10] ^ src[8] & 0x100820a2 ^ 0x1498e850) &
                      src[4] ^ (locals[10] & 0x5d870432 ^ src[8] & 0x52724ba ^ 0x4ca2049a) & src[6] ^
                      ((locals[6] ^ 0xe6d8ff75) & locals[10] ^ 0x1d822010) & 0x5da7249a ^ locals[6] & 0x100220aa) &
                     src[3]
                     ^ (((locals[10] & 0x5fdbdb27 ^ locals[6] & 0x77339ab ^ 0x4cb2d28e) & src[6] ^
                         (locals[6] & 0x5debfa8f ^ 0x46d87005) & src[7] ^ locals[61] & 0x104a21ab ^ 0x1d9aeb01) &
                        src[5] ^ (locals[6] & 0x22502163 ^ src[7] & 0x42508363 ^ 0x60108202) & src[6] ^
                        (locals[5] & 0x6040a203 ^ 0x42502041) & src[7] ^ locals[5] & 0x402123 ^ 0x10a341) & src[4] ^
                     locals[21] & locals[13];
        locals[10] = (((src[7] & 0xcf134e25 ^ locals[5] & 0x87330ca1 ^ 0xcc324684) & src[6] ^
                       (locals[5] & 0x4d234e85 ^ 0xc6104405) & src[7] ^ locals[5] & 0x200a1 ^ locals[13] ^ 0xd124a01) &
                      src[1] ^ ((locals[24] & 0xe4b0d496 ^ 0x86b59490) & src[4] ^
                                (locals[21] ^ 0x4a70498) & 0x66e7469d) & src[3] ^
                      (locals[21] ^ 0x2508001) & src[4] & 0x2a51c005 ^ (locals[21] ^ 0xb7bbbdfb) & 0xce774685) & src[0]
                     ^ ((src[7] & 0xdfdfdf77 ^ src[8] & 0xa7773dfb ^ 0xecb2d69e) & src[6] ^
                        (src[8] & 0x7deffe9f ^ 0xc6d87455) & src[7] ^ locals[61] & 0x104a21ab ^ 0x1d9aeb51) &
                     locals[8];
        locals[61] = src[8];
        locals[6] = src[9];
        locals[99] = (((locals[61] & 0x1441838 ^ src[7] & 0x49c4da34 ^ 0x4880d21c) & src[6] ^
                       ((locals[61] ^ 0xf6fb75f7) & src[7] ^ 0x980ca10) & 0x49c4da1c ^ locals[61] & 0x400028 ^
                       locals[13])
                         & locals[8] ^ ~(locals[24] & 0x4880d21c) & 0xcff7debd ^ locals[140] ^ locals[179]) & src[0] ^
                     (locals[99] & locals[8] ^ 0xecb2d69e) & locals[21];
        locals[24] = src[0xb];
        locals[5] = ~(src[0] & locals[24]) ^ locals[8];
        locals[61] = src[2];
        locals[179] = (((locals[6] & 0x6210a062 ^ 0x29420349) & locals[24] ^ 0x400301) & src[10] ^
                       (locals[6] & 0x6b122068 ^ 0x40028229) & locals[24] ^ locals[6] & 0x9020008 ^ 0xf6fdfdfe) &
                      locals[61];
        locals[140] = ~locals[179];
        locals[21] = ((((locals[6] & 0xf6bdffff ^ locals[24]) >> 0x10 ^ 0xffffe254) & locals[60] >> 0x10 ^
                       locals[6] >> 0x10 & 0xfffffff7 ^ ~locals[232] & locals[101] & 0x6f3) & 0x5ffb ^
                      ((locals[233] ^ 0x6f30000) & locals[104]) >> 0x10 & 0xffb ^ 0x2000) & locals[180] ^
                     (((locals[2] ^ locals[233] & 0x86b5ffff ^ 0xfda7ffff) & locals[234]) >> 0x10 ^
                      ~(locals[232] & 0xffffd6f7) & locals[101] & 0xafff ^ ~(locals[232] & 0x4a7) & 0x5da7) &
                     locals[22] >> 0x10 ^
                     (((locals[104] & 0x6f30000 ^ 0x84e5ffff) & locals[60] ^ 0x4a70000) & locals[6] ^ 0xcf33ffff) >>
                     0x10
                     ^ locals[16];
        locals[2] = ((locals[23] & 0xffffe9be ^ 0x5924) & locals[234] ^ locals[23] & 0x68a5 ^ 0x6a0f) & locals[22] ^
                    (locals[23] & 0x1481 ^ 0x4c84) & locals[234] ^ locals[23] & 0xfffffa76;
        locals[6] = ~((locals[104] & 0x6250a363 ^ 0x9420309) & locals[61]);
        locals[13] = locals[2] << 0x10;
        locals[101] = ((locals[23] & 0xffffb273 ^ 0x2a1) & locals[234] ^ locals[23] & 0xffff90c2 ^ 0xfffffbaf) &
                      locals[22] ^
                      (locals[23] & 0x14c1 ^ 0x221) & locals[234] ^ locals[23] & 0x27c3;
        locals[24] =
            (((((locals[23] ^ 0x1dab0000) & locals[234] ^ (locals[23] ^ locals[233]) & 0x6f30000 ^ 0x10c80000) &
                  0x5ffb0000 ^ locals[15]) & locals[104] ^
              ((locals[233] ^ 0xeb56ffff) & 0x34a90000 ^ locals[4] & locals[23]) & locals[234] ^
              (locals[233] ^ 0x20400000) & 0xb469ffff ^ locals[1] ^ locals[14]) & locals[60] ^
             ((locals[17] ^ 0xcd2bffff) & locals[234] ^ (locals[233] & 0x8b50ffff ^ 0x8f33ffff) & locals[23] ^
              locals[233] & 0x59000000 ^ 0x4d230000) & locals[22] ^
             ((locals[233] & 0x5b500000 ^ 0x163b0000) & locals[23] ^ locals[233] & 0x1ff30000 ^ 0x5fbb0000) &
             locals[234] ^ (locals[233] & 0x8250ffff ^ 0x8633ffff) & locals[23] ^ locals[233] & 0x92d4ffff) >> 0x10 ^
            ((((locals[233] ^ 0x4a30000) & 0x2dab0000 ^ locals[102]) & locals[234] ^
              (locals[233] ^ 0xc40000) & 0x20cc0000) >> 0x10 ^ locals[16] ^ locals[141]) & locals[3];
        locals[3] = locals[101] << 0x10;
        locals[1] = ~((((locals[11] & 0xd9ddffff ^ 0xfdb7ffff) & locals[7] ^ locals[11] & 0x28a70000 ^ 0x8ed7ffff) &
                       locals[103]) >> 0x10) ^
                    ((locals[11] & 0x60320000 ^ 0x24b00000) & locals[7] ^ locals[11] & 0x1d9a0000) >> 0x10;
        locals[11] = ((~(locals[233] & 0xeb56a77b) & locals[60] & 0x76b9f8e6 ^ locals[233] & 0xc4ed6fb7 ^ 0xa4a5b5d3) &
                         locals[61] ^ 0x6250a363) & locals[104] ^
                     ((locals[233] ^ 0x6210a062) & locals[60] ^ locals[233] & 0x54a524b2 ^ 0xcf734fad) & locals[61] &
                     0xf6bdfcf6;
        locals[103] = (locals[24] ^ locals[59]) & locals[21];
        locals[7] = ~locals[59] & locals[24];
        locals[233] = ((locals[23] & 0xffffe9be ^ 0xffffef77) & locals[234] ^ locals[23] & 0xffffdfdc ^ 0x4eb5) &
                      locals[22] ^
                      (locals[23] & 0xffffed0f ^ 0xffffa142) & locals[234] ^ locals[23] & 0x327b ^ 0x4ea5;
        locals[234] = locals[233] << 0x10;
        locals[60] = (locals[7] ^ locals[103] ^ locals[18] ^ locals[59]) & locals[19] ^
                     (~locals[103] ^ locals[7] ^ locals[59]) & locals[18] ^
                     locals[21] ^ locals[59];
        locals[103] = (locals[9] ^ locals[8]) & locals[104] ^ locals[9];
        locals[7] = ~locals[234] ^ locals[3];
        locals[104] = (locals[9] ^ locals[104]) & locals[8] ^ locals[104];
        locals[22] = (locals[7] & locals[20] ^ locals[234] ^ locals[3]) & locals[1] ^
                     ~((locals[233] & locals[101]) << 0x10) & locals[13] ^
                     ~((locals[1] ^ locals[20]) & locals[7] & locals[178]);
        locals[8] = (((locals[233] ^ locals[101] ^ locals[2]) << 0x10 ^ locals[20]) & locals[1] ^
                     (locals[7] ^ locals[13]) & locals[20]) &
                    locals[178] ^
                    ((locals[101] ^ locals[2]) & locals[233] ^ locals[101] ^ locals[2]) << 0x10 & locals[1] ^
                    locals[234] ^
                    locals[3];
        locals[1] = (~locals[1] & locals[20] ^ (locals[1] ^ locals[20]) & locals[13]) & locals[178] ^
                    ((~locals[1] ^ locals[13]) & locals[234] ^ locals[1] ^ locals[13]) & locals[3] ^
                    ~((~locals[234] ^ locals[20]) & locals[1]) & locals[13] ^ locals[234] ^ locals[1];
        locals[234] = (~((~locals[19] ^ locals[18]) & locals[100]) ^ locals[18] ^ locals[59]) & locals[21] ^
                      locals[19] ^ locals[18];
        locals[9] = ~locals[24];
        locals[7] = (locals[9] ^ locals[100]) & locals[59];
        locals[100] = (~((locals[9] ^ locals[59] ^ locals[100]) & locals[19]) ^
                       (locals[24] ^ locals[59] ^ locals[100]) & locals[18] ^ locals[24]
                       ^ locals[100]) &
            locals[21] ^ ((locals[24] ^ locals[100]) & locals[59] ^ locals[24] ^ locals[18] ^ locals[100]) & locals[19]
                       ^ (locals[7] ^ locals[24] ^ locals[100]) & locals[18] ^ locals[7] ^ locals[24] ^ locals[100];
        locals[7] = (~locals[100] ^ locals[60]) & locals[103];
        locals[2] = (locals[104] ^ locals[103]) & locals[60];
        locals[3] = (locals[2] ^ locals[104] ^ locals[103]) & locals[5];
        locals[23] = (~((~locals[7] ^ locals[100] ^ locals[60]) & locals[104]) ^ locals[7] ^ locals[100] ^ locals[60]) &
                     locals[234] ^
                     ~(((~(~locals[60] & locals[104]) ^ locals[60]) & locals[103] ^ locals[3]) & locals[100]) ^
                     locals[104] ^ locals[103];
        locals[233] = ~locals[103] ^ locals[5];
        locals[7] = (~((~((~(locals[233] & locals[1]) ^ locals[103]) & locals[104]) ^ locals[1] & locals[5]) &
                       locals[22]) ^
                     (~locals[1] & locals[103] ^ locals[1]) & locals[104]) & locals[8] ^
                    (~((~(~locals[103] & locals[22]) ^ locals[103]) & locals[1]) ^ locals[22]) & locals[104] ^
                    locals[22];
        locals[61] = (~((~((~locals[100] ^ locals[60]) & locals[104]) ^ locals[100] ^ locals[60]) & locals[234]) ^
                      (~locals[60] & locals[104] ^ locals[60]) & locals[100] ^ locals[60]) & locals[103] ^
                     ((locals[100] ^ locals[60]) & (locals[104] ^ locals[103]) ^ locals[104] ^ locals[103]) &
                     locals[234] & locals[5] ^
                     (~(~locals[104] & locals[100]) ^ locals[104]) & locals[60] ^ locals[104];
        locals[13] = (~locals[104] & locals[60] ^ ~locals[3] ^ locals[103]) & locals[100] ^ locals[2] ^ locals[104] ^
                     locals[103];
        locals[60] = (~locals[13] ^ locals[61]) & locals[23];
        locals[60] = (locals[99] & locals[12] ^ locals[13] ^ locals[61] ^ locals[60]) & locals[10] ^
                     (~locals[60] ^ locals[13] ^ locals[61]) & locals[12] ^ locals[61] ^ locals[60];
        locals[234] = ((locals[9] ^ locals[21]) & locals[59] ^ locals[21]) & locals[11];
        locals[2] = ~((~(locals[9] & locals[6]) ^ locals[24]) & locals[11]);
        locals[3] = ~(((~(((~locals[11] ^ locals[24]) & locals[59] ^ locals[11]) & locals[21]) ^
                        locals[9] & locals[11] & locals[59]) & locals[6]
                       ^ locals[234] ^ locals[21]) & locals[140]) ^ (locals[2] & locals[21] ^ locals[6]) & locals[59] ^
                    locals[6] ^ locals[21];
        locals[2] =
            (~((~locals[59] & locals[21] ^ ~locals[234]) & locals[6]) ^ locals[234] ^ locals[21]) & locals[140] ^
            (locals[2] ^ locals[6] ^ locals[21]) & locals[59] ^ locals[6] ^ locals[21];
        locals[234] = (locals[99] ^ locals[12]) & locals[10];
        locals[4] = ~(((locals[23] ^ locals[99] ^ locals[12]) & locals[13] ^ locals[23] ^ locals[99] ^ locals[12]) &
                      locals[10]) ^
                    ((locals[13] ^ locals[10]) & locals[23] ^ locals[13] ^ locals[10]) & locals[61] ^ locals[13] ^
                    locals[12];
        locals[23] = (~(~locals[23] & locals[61]) ^ ~locals[99] & locals[10] ^ locals[23]) & locals[12] ^
                     ~(((locals[61] ^ locals[12]) & locals[23] ^ locals[61] ^ locals[234]) & locals[13]) ^ locals[10];
        locals[61] = ((~((~locals[8] ^ locals[22]) & locals[103]) ^ locals[8] ^ locals[22]) & locals[104] ^
                      (~((~locals[8] ^ locals[22]) & locals[104]) ^ locals[8] ^ locals[22]) & locals[5]) & locals[1] ^
                     locals[22] ^ locals[104];
        locals[104] = ~(((~(locals[233] & locals[104]) ^ locals[5]) & locals[8] ^ locals[104]) & locals[22]) ^
                      ((locals[103] ^ locals[5]) & locals[104] ^ locals[5]) & locals[8] ^ locals[104];
        locals[1] = (locals[4] & 0xff00 ^ 0xff000000) & locals[23];
        locals[14] = ((locals[4] ^ 0xffff00ff) & 0xff00ff00 ^ locals[1]) & locals[60] ^
                     locals[4] & ~locals[23] & 0xff00ff00;
        locals[1] = (((locals[23] ^ 0xff00) & locals[4] ^ 0xff00) & locals[60] ^ locals[4] & 0xff00) & 0xff00ff00 ^
                    locals[1];
        locals[15] = ~(((locals[4] ^ 0xff00) & locals[23] ^ 0xff00) & locals[60] & 0xff00ff00);
        locals[8] = locals[14] << 8;
        locals[101] = ~(~locals[8] & locals[15] << 8) & locals[1] << 8 ^ (locals[15] & locals[14]) << 8;
        locals[103] = ~((locals[14] ^ locals[1]) << 8) & 0xffffff00;
        locals[8] = ~(~(locals[1] << 8) & locals[8]) & locals[15] << 8 ^ locals[8];
        locals[59] =
            ~(((((locals[11] ^ locals[140]) & locals[24] ^ locals[140]) & locals[59] ^ locals[11]) & locals[21] ^
               ~(locals[9] & locals[59]) & locals[140] ^ locals[59]) & locals[6]) ^
            (~(locals[24] & locals[59]) & locals[11] ^ locals[140] ^ locals[59]) & locals[21] ^ locals[140] ^
            locals[59];
        locals[20] = ((locals[60] & ~locals[23] ^ locals[23]) & ~locals[4] & 0xffffff00 ^ locals[4]) & 0xff00ff;
        locals[9] = ~(locals[14] >> 0x18) & locals[15] >> 0x18 ^ ~(locals[1] >> 0x18);
        locals[233] = locals[9] & 0xff;
        locals[24] = ~locals[3];
        locals[22] = ~((locals[3] ^ locals[11] ^ locals[6]) & locals[140]);
        locals[16] = ((locals[24] ^ locals[140]) & locals[59] ^ locals[22] ^ locals[11]) & locals[2] ^
                     (locals[24] & locals[140] ^ locals[3]) & locals[59] ^ locals[179] & locals[11];
        locals[13] = (((locals[4] ^ 0xff) & locals[23] ^ ~locals[4] & 0xff) & locals[60] ^
                      (locals[4] ^ locals[23]) & 0xff ^ locals[23]) &
                     0xff00ff;
        locals[234] = ~locals[99] & locals[12] ^ locals[61] ^ locals[234];
        locals[100] = ~((locals[234] ^ locals[7] ^ locals[99]) & locals[104]) ^ (locals[234] ^ locals[99]) & locals[7] ^
                      locals[99];
        locals[5] = ((locals[3] ^ locals[140]) & locals[2] ^ locals[3] ^ locals[22] ^ locals[11]) & locals[59] ^
                    (locals[2] & locals[24] ^ locals[6]) & locals[140] ^ locals[2];
        locals[24] = (locals[11] ^ locals[6]) & locals[140];
        locals[140] = (locals[59] ^ locals[24] ^ locals[3] ^ locals[11]) & locals[2] ^
                      (locals[24] ^ locals[3] ^ locals[11]) & locals[59] ^
                      locals[140];
        locals[234] = (locals[14] & locals[1] ^ locals[15]) >> 0x18;
        locals[2] = ~(locals[140] & locals[5] & 0xffff) ^ locals[16] & 0xffff;
        locals[3] = ~locals[140] & locals[5] ^ ~locals[16];
        locals[19] = locals[3] & 0xffff;
        locals[23] = (~locals[60] & locals[4] & 0xff ^ 0xff0000) & locals[23];
        locals[59] = locals[23] << 0x18;
        locals[4] = ~((locals[13] & locals[20]) << 0x18 & ~locals[59]) ^ ~(locals[20] << 0x18) & locals[59];
        locals[22] = (locals[23] ^ locals[20]) >> 8;
        locals[24] = ~((~locals[7] & locals[99] ^ (locals[7] ^ locals[99]) & locals[12]) & locals[10]) ^
                     (~((locals[61] ^ locals[12]) & locals[99]) ^ locals[61] ^ locals[12]) & locals[7] ^
                     ~((locals[7] ^ locals[99]) & locals[61]) & locals[104];
        locals[21] = ~(locals[23] >> 8);
        locals[23] = ~(~(locals[20] >> 8 & locals[21]) & locals[13] >> 8) ^ locals[23] >> 8;
        locals[60] = locals[13] << 0x18;
        locals[11] = ~locals[59] ^ locals[60];
        locals[61] = (locals[140] ^ locals[16]) & locals[5] ^ ~locals[140];
        locals[6] = locals[61] & 0xffff;
        locals[5] = (~(locals[3] & 0xff00) & locals[2] ^ locals[3] & 0xff00) & locals[6];
        locals[21] = ~(locals[13] >> 8 & locals[21]) ^ locals[22];
        locals[99] = (~((~locals[104] ^ locals[7]) & locals[99]) ^ locals[104] ^ locals[7]) & locals[12] ^
                     ((locals[104] ^ locals[7]) & (locals[99] ^ locals[12]) ^ locals[99] ^ locals[12]) & locals[10] ^
                     locals[104] ^ locals[99];
        locals[17] = ~(locals[1] >> 0x18) & locals[14] >> 0x18 ^ ~(locals[15] >> 0x18);
        locals[18] = locals[17] & 0xff;
        locals[13] = (locals[103] ^ locals[101]) & locals[8];
        locals[1] = ~locals[11];
        locals[60] = ~(~(~locals[60] & locals[59]) & locals[20] << 0x18) ^ locals[60];
        locals[7] = ~((~((locals[11] ^ locals[101]) & locals[4]) ^ (locals[103] ^ locals[1]) & locals[101] ^
                       locals[11] ^ locals[13]) & locals[60]
                        ) ^ (~locals[103] & locals[8] ^ locals[4] & locals[1] ^ locals[103]) & locals[101] ^ locals[4] ^
                    locals[103];
        locals[104] = (~((locals[103] ^ locals[60] ^ locals[11] ^ locals[8]) & locals[101]) ^
                       (locals[60] ^ locals[8] ^ locals[1]) & locals[103])
                      & locals[4] ^
                      ((locals[103] ^ locals[8] ^ locals[1]) & locals[101] ^ locals[103] & (locals[11] ^ locals[8])) &
                      locals[60] ^
                      locals[103];
        locals[10] = (locals[3] & 0xff00 ^ 0xff) & locals[2];
        locals[12] = (~(~locals[2] & locals[19]) & locals[6] ^ locals[19]) & 0xff00 ^ locals[10];
        locals[6] = ~locals[19] & locals[2];
        locals[19] = ~((locals[61] & 0xff00 ^ locals[19]) & locals[2]) ^ locals[19];
        locals[60] =
            ((locals[101] ^ locals[1]) & locals[103] ^ (locals[11] ^ locals[103]) & locals[60] ^ locals[11] ^
             locals[13]) & locals[4] ^
            (~(~locals[101] & locals[8]) ^ locals[60] & locals[1] ^ locals[101]) & locals[103] ^ locals[101] ^
            locals[60];
        locals[8] = locals[24] & 0xff;
        locals[179] = locals[99] & 0xff;
        locals[59] = ((locals[8] ^ 0xff0000) & locals[99] ^ locals[24] & 0xff00ff) & locals[100] ^
                     ~locals[179] & locals[24] & 0xff00ff;
        locals[140] = locals[19] << 0x18;
        locals[11] = ~(~(~(locals[10] << 0x18) & locals[140]) & locals[5] << 0x18) ^ locals[140];
        locals[103] = ~(locals[2] & 0xff000000);
        locals[8] = ~((~locals[8] & locals[100] ^ locals[8]) & locals[99] & 0xff00ff);
        locals[10] = ~(~(locals[19] << 8) & locals[5] << 8) & locals[12] << 8;
        locals[61] = (locals[19] & locals[5]) << 8 ^ locals[10];
        locals[141] = ~locals[60];
        locals[101] = ~locals[23] & locals[21];
        locals[1] = ~(((locals[60] ^ locals[104] ^ locals[21]) & locals[7] ^ locals[104] & locals[141] ^ locals[101]) &
                      locals[22]) ^
                    (~(locals[23] & ~locals[7]) ^ locals[7]) & locals[21] ^
                    (locals[141] & locals[7] ^ locals[60]) & locals[104] ^ locals[7];
        locals[2] = (locals[19] ^ locals[12]) << 8;
        locals[178] = (locals[103] ^ locals[6] & 0xff000000) >> 8;
        locals[3] = (locals[100] & ~locals[24] ^ locals[24]) & 0xff0000;
        locals[4] = locals[3] ^ locals[179];
        locals[13] = ~locals[10] ^ locals[5] << 8;
        locals[102] = (locals[6] & 0xff000000) >> 8 & ~(locals[103] >> 8) ^ locals[103] >> 8 ^ 0xff000000;
        locals[16] = (locals[24] ^ locals[99]) & locals[100] ^ locals[24];
        locals[20] = locals[16] & 0xff00ff00;
        locals[14] = (locals[8] & locals[59] ^ locals[4]) >> 8;
        locals[10] = (locals[22] ^ ~locals[23]) & locals[21] ^ locals[60];
        locals[10] = ~((locals[10] ^ locals[104]) & locals[7]) ^ locals[10] & locals[104] ^ locals[22];
        locals[15] = locals[6] >> 0x18;
        locals[7] = ((locals[104] ^ locals[141]) & locals[7] ^ (locals[23] ^ locals[104]) & locals[21] ^
                     locals[60] & locals[104]) & locals[22] ^
                    (~(~locals[7] & locals[60]) ^ locals[101]) & locals[104] ^ locals[7];
        locals[3] = (~(locals[59] >> 8 & ~(locals[8] >> 8)) & locals[3] >> 8 ^ ~(locals[8] >> 8)) & 0xffffff;
        locals[141] = locals[10] ^ locals[1];
        locals[25] = ((locals[10] & 0xfd49efff ^ locals[234] & 0xdab6dbb7 ^ 0xeffffdfc) & locals[18] ^
                      (locals[141] & 0x27ff3448 ^ locals[234] & 0xdab6dbb7 ^ 0x3549264b) & locals[233] ^
                      (locals[10] & 0xdab6dbb7 ^ locals[18] ^ 0x1687abc) & locals[1] ^ locals[10] & 0x1687abc ^
                      0xe4138df2) &
                     locals[7] ^ ((locals[17] & 0xb7 ^ 0xfc219543) & locals[234] ^ locals[17] & 3 ^ 0xefacdbfc) &
                     locals[233] ^
                     (locals[9] & 0x48 ^ locals[18] ^ 0xdbdea10b) & locals[10] & locals[1] ^
                     (locals[234] & 0x26974ef4 ^ 0x18613eb1) & locals[18] ^ 0xb06f9d09;
        locals[23] = (locals[4] & locals[8]) << 0x18 ^ 0xffffff;
        locals[104] = ~locals[100] & locals[24] & locals[99] & 0xff00;
        locals[21] = (locals[4] ^ locals[8]) << 0x18;
        locals[101] = (locals[103] ^ locals[6]) >> 0x18;
        locals[16] = locals[16] >> 0x18;
        locals[60] = (~((locals[12] & locals[5]) << 0x18 & ~locals[140]) ^ ~(locals[5] << 0x18) & locals[140]) &
                     0xff000000;
        locals[103] = locals[6] >> 0x18 ^ 0xffffffff;
        locals[22] = (locals[4] ^ locals[59]) >> 8 ^ 0xff000000;
        locals[8] = ~(locals[59] << 0x18) & locals[179] << 0x18 ^ (locals[8] & locals[59]) << 0x18 ^ 0xffffff;
        locals[6] = ((locals[141] & 0x1281f9ee ^ locals[234] & 0xed7fa65d ^ 0xdf8a5db2) & locals[233] ^
                     (locals[10] & 0xfffe5fb3 ^ locals[234] & 0xed7fa65d ^ 0x32f5fbef) & locals[18] ^
                     (locals[10] & 0xed7fa65d ^ locals[17] & 0xb3 ^ 0xfdb3692f) & locals[1] ^ locals[10] & 0xfdb3692f ^
                     0x63663294) & locals[7] ^
                    ((locals[17] & 0x5d ^ 0x24d369c) & locals[234] ^ locals[17] & 0x5c ^ 0xff778ae9) & locals[233] ^
                    (locals[9] & 0xee ^ locals[17] & 0xb3 ^ 0x10cccf72) & locals[10] & locals[1] ^
                    (locals[234] & 0xef3290c1 ^ 0xaca9750e) & locals[18];
        locals[12] = (locals[19] ^ locals[12]) << 0x18 ^ 0xffffff;
        locals[62] = locals[6] ^ 0x283fae83;
        locals[63] = ((locals[10] & 0xbfbffe7e ^ locals[234] & 0x77df7def ^ 0xdfebb7db) & locals[18] ^
                      (locals[10] & 0x77df7def ^ locals[17] & 0x7e ^ 0xd22ca64a) & locals[1] ^
                      (locals[141] & 0xc8608391 ^ locals[234] & 0x77df7def ^ 0xa834ca34) & locals[233] ^
                      locals[10] & 0xd22ca64a ^ 0x3a89505d) & locals[7] ^
                     ((locals[17] & 0xef ^ 0x6d935834) & locals[234] ^ locals[17] & 0xa5 ^ 0x5fef35da) & locals[233] ^
                     (locals[9] & 0x91 ^ locals[17] & 0x7e ^ 0xa5f3dba5) & locals[10] & locals[1] ^
                     (locals[234] & 0x1a4c25db ^ 0xd71e8a68) & locals[18] ^ 0xe64e19bb;
        locals[26] = ((locals[6] ^ 0xd515dadd) & locals[25] & 0x43d58fa1 ^ locals[62] & 0x439c88a0 ^ 0xad7b035f) &
                     locals[63]
                     ^ (locals[25] & 0x28808a1 ^ 0xffe3fdbd) & locals[62];
        locals[7] = ~locals[12];
        locals[10] = (locals[7] ^ locals[13]) & locals[61];
        locals[9] = (locals[7] ^ locals[60] ^ locals[61]) & locals[11];
        locals[7] = (~((locals[7] ^ locals[61]) & locals[60]) ^ locals[10] ^ locals[12] ^ locals[13]) & locals[11] ^
                    (~locals[9] ^ locals[10] ^ locals[12] ^ locals[60] ^ locals[13]) & locals[2] ^
                    (locals[7] & locals[13] ^ locals[12] ^ locals[60]) & locals[61] ^
                    (locals[60] ^ locals[13]) & locals[12] ^ locals[60] ^ locals[13]
            ;
        locals[234] = (~((~locals[13] ^ locals[2] ^ locals[11]) & locals[61]) ^ locals[13] ^ locals[2] ^ locals[11]) &
                      locals[12] ^
                      ((locals[12] ^ locals[61]) & locals[11] ^ locals[12] ^ locals[61]) & locals[60] ^ locals[2] ^
                      locals[11];
        locals[10] = ((locals[62] & 0xfd4b7556 ^ 0x6130040b) & locals[25] ^ locals[62] & 0x885b7554 ^ 0x5059cf25) &
                     locals[63]
                     ^ (locals[25] & 0x8c22701d ^ 0x8bdf7df4) & locals[62];
        locals[11] = ((locals[2] ^ locals[11]) & locals[61] ^ locals[2] ^ locals[11]) & locals[13] ^
                     (locals[9] ^ locals[12] ^ locals[60] ^ locals[61]) & locals[2] ^ locals[12] ^ locals[61] ^
                     locals[11];
        locals[1] = ((locals[62] & 0xbe9efaf7 ^ 0x12c5fbe4) & locals[25] ^ locals[62] & 0x7561c54d ^ 0x590305) &
                    locals[63] ^
                    (locals[6] ^ 0xd7c0517f) & locals[25] & 0x5141cf67 ^ 0xec63f71e;
        locals[61] = ~(~(locals[26] >> 0x13) & locals[10] >> 0x13) ^ (locals[1] ^ locals[26]) >> 0x13;
        locals[60] = ~locals[11];
        locals[12] = (locals[60] ^ locals[234]) & locals[7];
        locals[9] = ~((locals[178] ^ locals[102]) & locals[234]) & locals[11] ^
                    (locals[178] ^ locals[102]) & (locals[60] ^ locals[234]) & locals[7] ^ locals[178];
        locals[2] =
            ((~locals[234] ^ locals[178]) & locals[11] ^ (locals[11] ^ locals[178]) & locals[178] ^ ~locals[12]) &
            locals[102] ^
            (~locals[7] & locals[234] ^ 0xffffffff ^ locals[178]) & locals[11] ^ locals[178];
        locals[6] = (~(locals[10] >> 0x13) & locals[26] >> 0x13 ^ ~(locals[1] >> 0x13)) & 0x1fff;
        locals[233] = ~(((locals[104] ^ locals[20]) &
                         ((~locals[99] & locals[100] ^ locals[99]) & ~locals[24] ^ locals[24]) & 0xff00) << 8
            ) ^ locals[20] << 8;
        locals[102] = (~((locals[60] ^ locals[102]) & locals[178]) ^ locals[60] & locals[102] ^ locals[11]) &
                      locals[178] ^
                      ((locals[234] ^ locals[102]) & locals[11] ^ locals[12]) & locals[178] ^
                      (~(locals[60] & locals[234]) ^ locals[11]) & locals[7] ^ locals[11] ^ locals[102];
        locals[5] = (locals[1] & locals[10] ^ locals[26]) >> 0x13;
        locals[11] = (locals[104] & locals[20]) << 8;
        locals[12] = (locals[1] ^ locals[26]) & 0x7ffff;
        locals[60] = ((~locals[1] ^ locals[26]) & locals[10] ^ ~(~locals[26] & locals[1])) & 0x7ffff;
        locals[4] = ~locals[9];
        locals[17] = ((locals[2] ^ locals[15]) & locals[103] ^ locals[4] & locals[102] ^
                      (locals[102] ^ locals[9]) & locals[2] ^ locals[9] ^
                      locals[15]) & locals[101] ^
                     (~locals[15] & locals[103] ^ locals[102] & locals[9] ^ locals[15]) & locals[2] ^ locals[9] ^
                     locals[15];
        locals[234] = (locals[102] ^ locals[9] ^ locals[103]) & locals[2];
        locals[24] = (locals[102] ^ locals[103]) & locals[9];
        locals[10] = ~locals[26] & locals[1] & 0x7ffff;
        locals[7] = (locals[60] ^ locals[12]) << 0xd;
        locals[1] = (~((locals[4] ^ locals[15]) & locals[102]) ^ locals[9] & locals[15]) & locals[2] ^
                    ~((~((locals[4] ^ locals[15]) & locals[101]) ^ locals[4] & locals[15] ^ locals[9]) & locals[103]) ^
                    (~(locals[4] & locals[15]) ^ locals[9]) & locals[102] ^ locals[9] ^ locals[101] ^ locals[15];
        locals[2] = (~locals[234] ^ locals[24] ^ locals[102]) & locals[101] ^
                    (locals[24] ^ locals[234] ^ locals[102]) & locals[15] ^
                    (locals[2] ^ locals[9]) & locals[103] ^ locals[2];
        locals[4] = ~(locals[104] << 8) ^ locals[20] << 8;
        locals[24] = ~locals[4] ^ locals[11];
        locals[13] = locals[24] & locals[233];
        locals[9] = ~((locals[1] ^ locals[17] ^ 0x3dce0000) & locals[2]) ^ (locals[1] ^ locals[17]) & 0x3dce0000 ^
                    locals[1];
        locals[234] = locals[9] >> 3;
        locals[24] = (~(locals[24] & locals[21]) ^ locals[4] ^ locals[11]) & locals[233] ^
                     (~locals[13] ^ locals[4] ^ locals[11]) & locals[23] ^
                     (locals[4] ^ locals[11]) & locals[21] ^ locals[11];
        locals[103] = locals[10] << 0xd;
        locals[104] = ~(~(locals[60] << 0xd) & locals[103]) & locals[12] << 0xd;
        locals[12] = (locals[10] & locals[60]) << 0xd ^ locals[104];
        locals[103] = ~locals[104] ^ locals[103];
        locals[60] = (locals[2] & 0x3dce0000 ^ 0xc231ffff) & locals[1] ^ ~locals[2] & locals[17] & 0x3dce0000 ^
                     0xc231ffff;
        locals[104] = locals[60] >> 3;
        locals[10] = (((locals[17] & 0xc231ffff ^ 0x3dce0000) & locals[1] ^ locals[17] & 0xc231ffff) & locals[2] ^
                      locals[1] & 0x3dce0000 ^ locals[17] ^ 0xc231ffff) >> 3;
        locals[15] = ~locals[104] ^ locals[234];
        locals[104] = ~(~(locals[104] & ~locals[234]) & locals[10]) ^ locals[234];
        locals[1] = ((locals[233] ^ locals[8]) & locals[4] ^ locals[233] ^ locals[8]) & locals[21] ^
                    (~((locals[4] ^ locals[21]) & locals[8]) ^ locals[4] ^ locals[21]) & locals[23] ^
                    ((locals[4] ^ locals[21]) & locals[233] ^ locals[4] ^ locals[21]) & locals[11] ^ locals[4];
        locals[21] = (~locals[233] & locals[11] ^ locals[8] & locals[21]) & locals[4] ^
                     ~(((~locals[4] ^ locals[21]) & locals[8] ^ locals[13] ^ locals[4] ^ locals[11]) & locals[23]) ^
                     locals[21];
        locals[11] = ~locals[1];
        locals[8] = ((locals[11] ^ locals[22] ^ locals[3]) & locals[14] ^ (locals[11] ^ locals[14]) & locals[24] ^
                     locals[1] ^ locals[3]) & locals[21]
                    ^ (locals[11] & locals[14] ^ locals[1]) & locals[24] ^ (locals[11] ^ locals[3]) & locals[14] ^
                    locals[1] ^ locals[3];
        locals[10] = (~((locals[60] & locals[9]) >> 3) & locals[10] ^ ~locals[234]) & 0x1fffffff;
        locals[9] = ~(((locals[1] ^ locals[22] ^ locals[3]) & locals[14] ^ (locals[11] ^ locals[14]) & locals[21] ^
                       locals[3]) & locals[24]) ^
                    (~(~locals[21] & locals[1]) ^ locals[22]) & locals[14] ^ locals[21];
        locals[24] = ((locals[21] ^ locals[24]) & locals[14] ^ locals[21] ^ locals[24]) & locals[3] ^
                     ~((locals[21] ^ locals[24]) & locals[22]) & locals[14] ^ locals[24];
        locals[11] = locals[24] ^ locals[8];
        locals[233] = ~locals[8] & locals[24];
        locals[27] = ((locals[24] & 0xbf87a7fd ^ 0xd48686cb) & locals[8] ^ locals[24] & 0x6b012136 ^ 0xd07afa0b) &
                     locals[9] ^
                     ((locals[11] & 0x787d7c2a ^ 0x3b052468) & locals[9] ^ locals[233] & 0x787d7c2a ^ 0xfcf38bfd) &
                     locals[16]
                     ^ locals[233] & 0x6b012136 ^ 0xacbbc875;
        locals[28] = ((locals[24] & 0xf9ffff66 ^ 0x2f6ea713) & locals[8] ^ locals[24] & 0xd6915875 ^ 0x9f9d55fd) &
                     locals[9] ^
                     ((locals[11] & 0x874a9adf ^ 0xc9debb46) & locals[9] ^ locals[233] & 0x874a9adf ^ 0x3f2d6db0) &
                     locals[16]
                     ^ locals[233] & 0xd6915875 ^ 0xf6a7890d;
        locals[29] = ((locals[24] & 0x6ffd78df ^ 0x4313de37) & locals[8] ^ locals[24] & 0x2ceea6e8 ^ 0xb82bd72a) &
                     locals[9] ^
                     ((locals[11] & 0x9082c7a1 ^ 0x24a14095) & locals[9] ^ locals[233] & 0x9082c7a1 ^ 0x4bdd79de) &
                     locals[16]
                     ^ locals[233] & 0x2ceea6e8 ^ 0x1f390573;
        locals[23] = ((locals[29] & 0x534e528e ^ 0x2108101) & locals[28] ^ locals[29] & 0x11771386 ^ 0x12500201) &
                     locals[27]
                     ^ (locals[29] & 0x1108105 ^ 0x1250c30d) & locals[28] ^ locals[29] & 0xb54dcf78;
        locals[21] = ((locals[29] & 0xd2444e68 ^ 0xd9cebfe2) & locals[28] ^ locals[29] & 0x273f15f7 ^ 0x3edce77d) &
                     locals[27]
                     ^ (locals[29] & 0x4abf708f ^ 0x412f1082) & locals[28] ^ locals[29] & 0xa4329df2 ^ 0x1250c30d;
        locals[1] = ~(((locals[29] & 0xd2444e68 ^ 0x10408304) & locals[28] ^ locals[29] & 0x82140905 ^ 0xc10c) &
                      locals[27]) ^
                    (locals[29] & 0xb4500e35 ^ 0x2108105) & locals[28] ^ locals[29] & 0xd37b9a87;
        locals[8] = ((locals[1] ^ 0xfff80007) & locals[21] ^ ~(locals[1] & 0xfff80007)) & locals[23] ^
                    ~locals[21] & locals[1] & 0xfff80007;
        locals[234] = locals[8] & 0xfffffff8 ^ 0x7ffff;
        locals[233] = ~(~(~locals[21] & locals[1]) & locals[23] & 7) ^ locals[1] & 7;
        locals[2] = ~((~locals[1] & locals[21] & 0xfff80000 ^ 0x7fff8) & locals[23]);
        locals[9] = (~locals[23] & locals[1] & 0x7fff8 ^ 0xfff80000) & locals[21];
        locals[22] = locals[9] ^ ~(~locals[23] & locals[1]) & 0x7fff8;
        locals[8] = locals[8] >> 0x13;
        locals[11] = ~(locals[2] >> 0x13);
        locals[3] = locals[8] ^ locals[11];
        locals[60] = (locals[1] ^ locals[21]) & 7;
        locals[9] = locals[9] >> 0x13;
        locals[24] = (locals[22] ^ locals[2]) << 0xd;
        locals[4] = ~((locals[234] & locals[2]) >> 0x13) & locals[9] ^ locals[11];
        locals[13] = locals[4] & 0x1fff;
        locals[11] = ~locals[9] & locals[8] ^ locals[11];
        locals[1] = (~(~locals[1] & locals[23]) & locals[21] ^ locals[1] & locals[23]) & 7;
        locals[8] = locals[11] & 0x1fff;
        locals[9] = locals[11] & 0x134f;
        locals[23] = locals[11] & 0x1e53;
        locals[18] = ~locals[103];
        locals[30] = ((locals[7] & 0x84553eb1 ^ locals[9] ^ 0x5d62cf8) & locals[103] ^
                      (locals[8] ^ 0x85d73ef9) & locals[13] & 0xfbabd34f ^ locals[23] ^ 0x7e6fc9af) & locals[3] ^
                     (locals[4] & 0xdfe ^ locals[3] & 0x84553eb1 ^ 0x13d1de53) & locals[12] & locals[18] ^
                     ((locals[7] & 0x7ffeedfe ^ locals[9] ^ 0xfe7dffb7) & locals[103] ^ locals[23] ^ 0xb8b26410) &
                     locals[13] ^
                     (locals[7] & 0xe87a0d1c ^ locals[9] ^ 0xaf24b2ea) & locals[103] ^ locals[23] ^ 0xf3365638;
        locals[16] = locals[11] & 0xc8f;
        locals[16] = ((locals[8] ^ 0xff2cdd36) & locals[13] ^ 0x22f3b6db ^
                      (locals[7] & 0xb7244522 ^ locals[8] ^ 0xc8089814) & locals[103] ^ locals[16]) & locals[3] ^
                     (locals[8] ^ 0x15857169 ^ locals[7] & 0xa594d370) & locals[103] ^
                     (locals[4] & 0x1add ^ locals[3] & 0xb7244522 ^ 0xda6b2c8f) & locals[12] & locals[18] ^
                     ((locals[7] & 0xc8dbbadd ^ locals[8] ^ 0xb7f767eb) & locals[103] ^ locals[16] ^ 0xedcec9f4) &
                     locals[13] ^
                     locals[16];
        locals[9] = locals[233] << 0x1d;
        locals[235] = locals[16] ^ 0xd6ba5a28;
        locals[21] = locals[1] << 0x1d;
        locals[23] = locals[60] << 0x1d;
        locals[17] = ~locals[9] & locals[23] ^ locals[21];
        locals[21] = ~locals[23] & locals[21] ^ locals[9];
        locals[9] = ~(((locals[1] ^ locals[233]) & locals[60]) << 0x1d) ^ locals[9];
        locals[14] = (~(locals[15] & (locals[17] ^ locals[9])) ^ locals[104] & (locals[17] ^ locals[9])) & locals[21] ^
                     ((locals[15] ^ locals[104]) & locals[9] ^ locals[15] ^ locals[104]) & locals[17] ^ locals[104];
        locals[60] = ((locals[2] ^ locals[234]) & locals[22]) << 0xd ^ 0x1fff;
        locals[1] = ~locals[9];
        locals[23] =
            ~(((locals[9] ^ locals[15]) & locals[17] ^ (locals[9] ^ locals[10]) & locals[15] ^ locals[9] ^ locals[10]) &
              locals[21]) ^
            ~((locals[21] ^ locals[15]) & locals[10]) & locals[104] ^ ~(locals[17] & locals[1]) & locals[15];
        locals[233] = (locals[22] & locals[2]) << 0xd & ~(locals[234] << 0xd) ^ 0x1fff;
        locals[2] = (~(~locals[60] & locals[233] & 0x80000000) ^ locals[60]) & locals[24] ^
                    ~(locals[233] & locals[60]) & 0x7fffffff;
        locals[19] = (~locals[24] & locals[233] & 0x80000000 ^ 0x7fffffff) & locals[60] ^
                     (locals[24] & 0x80000000 ^ 0x7fffffff) & locals[233];
        locals[233] = ((locals[24] ^ 0x80000000) & locals[60] ^ locals[24] ^ 0x80000000) & locals[233];
        locals[24] = locals[233] >> 3;
        locals[234] = ~(~(locals[2] >> 3) & locals[24]) & locals[19] >> 3;
        locals[24] = locals[234] ^ locals[24];
        locals[22] = locals[11] & 0x1cb2;
        locals[11] = locals[11] & 0x1531;
        locals[142] = ((locals[7] & 0x588ba3cd ^ locals[22] ^ 0x3af9c34f) & locals[103] ^
                       (locals[8] ^ 0x62726082) & locals[13] & 0xe7767cb2 ^ locals[11] ^ 0x9fc47c72) & locals[3] ^
                      (locals[3] & 0x588ba3cd ^ locals[4] & 0x1f7f ^ 0x7cb59531) & locals[12] & locals[18] ^
                      ((locals[7] & 0xbffddf7f ^ locals[22] ^ 0xdd8fbffd) & locals[103] ^ locals[11] ^ 0x260ffbaf) &
                      locals[13] ^
                      (locals[7] & 0x9bc3e983 ^ locals[22] ^ 0x407a0edc) & locals[103] ^ locals[11] ^ 0x288aea7d;
        locals[103] = ((locals[235] & 0x60480000 ^ 0x4000003) & locals[142] ^ (locals[16] ^ 0xd6ba5a2d) & 0x64480005) &
            locals[30] ^ (locals[235] & 0x80080007 ^ 0x24400000) & locals[142] ^ locals[235] & 0xa4480003;
        locals[60] = locals[103] ^ 7;
        locals[12] = ~locals[21];
        locals[4] = (~((locals[9] ^ locals[12]) & locals[104]) ^ locals[21] & locals[1] ^ locals[9]) & locals[17] ^
                    ((locals[104] ^ locals[12]) & locals[10] ^ locals[21] ^ locals[104]) & locals[15] ^
                    (~((locals[10] ^ locals[1]) & locals[21]) ^ locals[10]) & locals[104] ^ locals[10] & locals[12];
        locals[21] = ((locals[235] & 0x60480000 ^ 0xb3f00003) & locals[142] ^ (locals[16] ^ 0x2145a5d7) & 0xb9c00005) &
            locals[30] ^ (locals[235] & 0x7e700007 ^ 0xece80000) & locals[142] ^ locals[235] & 0xf7780003;
        locals[234] = (locals[233] & locals[2]) >> 3 ^ locals[234];
        locals[16] = ((locals[235] & 0x6e278 ^ 0x35958) & locals[142] ^ (locals[16] ^ 0x2944b9d7) & 0x31d88) &
                     locals[30] ^
                     (locals[235] & 0x5bfb0 ^ 0x65f18) & locals[142] ^ locals[235] & 0x4d680;
        locals[9] = ~locals[4];
        locals[233] = (locals[4] ^ locals[14]) & locals[23];
        locals[104] = (locals[61] ^ locals[9]) & locals[14];
        locals[1] = (~((locals[23] ^ locals[6] ^ locals[9]) & locals[14]) ^ (locals[23] ^ locals[6]) & locals[4]) &
                    locals[61] ^
                    ~(((locals[6] ^ locals[9]) & locals[61] ^ locals[233] ^ locals[104]) & locals[5]) ^ locals[4];
        locals[8] = (locals[21] ^ 0x1bb7fff8) >> 0x13;
        locals[3] = ((locals[142] ^ locals[235]) & 0xe4480000) >> 0x13;
        locals[103] = locals[103] >> 0x13;
        locals[10] = ~(~locals[8] & locals[3]) & locals[103] ^ locals[3];
        locals[13] = ((locals[235] & 0x58310 ^ 0x21d18) & locals[142] ^ locals[235] & 0x38988 ^ 0x15c00) & locals[30] ^
                     (locals[235] & 0x9c10 ^ 0x7a7e8) & locals[142] ^ locals[235] & 0x48200;
        locals[11] = (locals[19] ^ locals[2]) >> 3;
        locals[15] = ((locals[235] & 0x36168 ^ 0x56620) & locals[142] ^ locals[235] & 0x77f78 ^ 0x623b8) & locals[30] ^
                     (locals[235] & 0x44a90 ^ 0x39d88) & locals[142] ^ ~(locals[235] & 0x48200) & 0xfffca277;
        locals[7] = (locals[13] & locals[16] ^ locals[15]) << 0xd;
        locals[22] = ((locals[4] ^ locals[61]) & locals[14] ^ ~locals[61] & locals[4]) & locals[23] ^
                     ((locals[14] ^ locals[5] ^ locals[6]) & locals[4] ^ locals[14] ^ locals[5] ^ locals[6]) &
                     locals[61] ^ locals[14];
        locals[2] = locals[22] ^ locals[5];
        locals[15] = locals[15] << 0xd;
        locals[12] = (locals[13] ^ locals[16]) << 0xd ^ ~(locals[16] << 0xd) & locals[15];
        locals[103] = (~(~locals[103] & locals[3] & locals[8]) ^ ~locals[3] & locals[103]) & 0x1fff;
        locals[8] = (locals[21] ^ 0x1bb7fff8 ^ locals[60]) >> 0x13 ^ 0xffffe000;
        locals[61] = (~(locals[23] & locals[9]) ^ ~locals[6] & locals[61]) & locals[14] ^
                     ~((locals[6] & locals[61] ^ locals[4] ^ locals[233] ^ locals[104]) & locals[5]) ^ locals[4] ^
                     locals[61];
        locals[22] = locals[22] >> 0x13;
        locals[9] = ~((locals[1] ^ locals[61]) >> 0x13) & locals[22] ^ locals[61] >> 0x13;
        locals[233] = ~(locals[13] << 0xd) & locals[16] << 0xd ^ locals[15] ^ 0x1fff;
        locals[3] = locals[1] >> 0x13 & ~locals[22] ^ locals[61] >> 0x13 ^ 0xffffe000;
        locals[23] = (locals[2] & locals[61] ^ locals[1]) >> 0x13;
        locals[6] = (locals[61] & 0xff80000 ^ 0x7ffff) & locals[2] ^ locals[61] & 0x7ffff;
        locals[31] = locals[6] ^ 0xff80000;
        locals[4] = (locals[233] & locals[12]) >> 3 & ~(locals[7] >> 3);
        locals[22] = (locals[12] ^ locals[7]) >> 3;
        locals[32] = (~locals[61] & 0x7ffff ^ locals[1]) & locals[2] ^ (locals[1] ^ 0x7ffff) & locals[61] ^ 0x7ffff;
        locals[60] = locals[60] << 0x1d;
        locals[33] = locals[32] & 0xfffffff;
        locals[13] = locals[60] ^ 0xffffffff;
        locals[60] = locals[60] & ~(locals[21] << 0x1d);
        locals[104] = ~locals[60];
        locals[16] = ~(locals[1] & 0x7ffff) & (locals[2] ^ locals[61]);
        locals[5] = locals[233] >> 3 & ~(locals[7] >> 3) ^ (locals[12] & locals[7]) >> 3 ^ 0xe0000000;
        locals[17] = locals[16] & 0xfffffff;
        locals[21] = locals[21] << 0x1d;
        locals[61] = ~(locals[17] << 0xd);
        locals[6] = locals[6] << 0xd;
        locals[1] = ~(locals[33] << 0xd & locals[61]) ^ locals[6] & locals[61];
        locals[61] = ~(locals[33] << 0xd) & locals[6] & locals[61];
        locals[12] = (locals[11] ^ locals[234]) & locals[24] ^ locals[11] ^ locals[21];
        locals[12] = (locals[12] ^ locals[13]) & locals[104] ^ locals[12] & locals[13] ^ locals[24];
        locals[7] = (locals[17] ^ locals[31]) << 0xd;
        locals[6] = (~((locals[234] ^ ~locals[11] ^ locals[21]) & locals[13]) ^ locals[234]) & locals[24] ^
                    ~((locals[24] ^ locals[13]) & locals[21]) & locals[104] ^ (~locals[11] ^ locals[21]) & locals[13];
        locals[233] = ((locals[61] ^ locals[1]) & (locals[103] ^ locals[8]) ^ locals[61] ^ locals[1]) & locals[10] ^
                      (~(~locals[61] & locals[7]) ^ locals[61]) & locals[1] ^ locals[61] ^ locals[8];
        locals[60] = locals[60] ^ locals[13];
        locals[104] = (~(locals[24] & locals[60]) ^ locals[104] ^ locals[13]) & locals[11] ^
                      (locals[234] & locals[60] ^ locals[104] ^ locals[13]) & locals[24] ^ locals[104];
        locals[234] = (locals[103] & locals[10] ^ locals[7] & locals[1]) & (locals[61] ^ locals[8]) ^
                      ((~locals[10] ^ locals[1]) & locals[8] ^ locals[10] ^ locals[1]) & locals[61] ^ locals[1];
        locals[61] = (~((~locals[1] ^ locals[8]) & locals[103]) ^ ~locals[8] & locals[1] ^ locals[8]) & locals[10] ^
                     ~((~locals[7] ^ locals[61]) & locals[8]) & locals[1] ^ locals[61];
        locals[7] = ((~locals[104] ^ locals[6] ^ locals[9]) & locals[12] ^ (locals[12] ^ locals[9]) & locals[23] ^
                     locals[104]) & locals[3] ^
                    (~locals[9] & locals[23] ^ locals[6] ^ locals[9]) & locals[12];
        locals[103] = locals[7] ^ locals[23];
        locals[10] = ~locals[23] ^ locals[3];
        locals[8] = ~((~(locals[10] & locals[12]) ^ locals[23] ^ locals[3]) & locals[104]) ^
                    (locals[10] & locals[6] ^ locals[23] ^ locals[3]) & locals[12] ^ locals[10] & locals[9] ^ locals[3];
        locals[3] = ~(((locals[23] ^ locals[3]) & locals[12] ^ locals[23] ^ locals[3]) & locals[104]) ^
                    ~((locals[23] ^ locals[3]) & locals[6]) & locals[12] ^ locals[3];
        locals[10] = (locals[8] ^ locals[103]) >> 0x13;
        locals[178] = (((~(locals[3] & 0x1e00) & locals[103] ^ locals[3] & 0xffffe1ff) & locals[8] ^ 0x1e00) & 0x7ffff ^
                       ~(locals[3] & 0x7ffff) & locals[103]) & 0xfffffff;
        locals[9] = ~locals[61];
        locals[11] = locals[8] >> 0x13;
        locals[181] = ((locals[61] & 0x506b1030 ^ 0x6e8810a3) & locals[234] ^ locals[9] & 0x6e8810a3) & locals[233] ^
                      (locals[61] & 0x886205a ^ 0xd9fd0be6) & locals[234] ^ locals[61] & 0x764ed470 ^ 0x2c1c6b2f;
        locals[24] = ~((locals[103] & locals[3]) >> 0x13) & locals[11] ^ locals[3] >> 0x13 ^ 0xffffe000;
        locals[12] =
            ((~(locals[3] & 0xfff81e00) & locals[8] ^ ~(locals[3] & 0x1e00) & 0x7ffff) & locals[103] ^ 0x7ffff) &
            0xfffffff ^ (locals[8] & 0x7e1ff ^ 0x1e00) & locals[3];
        locals[11] = ~(~locals[11] & locals[7] >> 0x13) & locals[3] >> 0x13 ^ locals[11];
        locals[7] = ((locals[8] ^ 0x1e00) & locals[3] & 0xff81e00 ^ 0x7e1ff) & locals[103] ^
                    (locals[8] & 0xff81e00 ^ 0x7e1ff) & locals[3];
        locals[18] = locals[7] ^ 0xff80000;
        locals[34] = ((locals[61] & 0xad50cb1a ^ 0xf41daf55) & locals[234] ^ locals[9] & 0xf41daf55) & locals[233] ^
                     (locals[61] & 0xb1ef2b50 ^ 0xe67d04b) & locals[234] ^ locals[61] & 0x557aa4ad ^ 0xed8d6dbf;
        locals[103] = (locals[18] & locals[178]) << 0xd & ~(locals[12] << 0xd);
        locals[23] = ((locals[61] & 0x394b5e6 ^ 0x83e24a09) & locals[234] ^ locals[9] & 0x83e24a09) & locals[233] ^
                     (locals[61] & 0x1b6f01cf ^ 0x283bb4b0) & locals[234] ^ locals[61] & 0xccdd7bcf;
        locals[236] = locals[23] ^ 0xf9cb086f;
        locals[104] = (((locals[23] ^ 0x23cf793) & locals[181] ^ (locals[23] ^ 0x63cf793) & 0xfbbfffff) & locals[34] ^
                       locals[236] & locals[181] & 1) & 0x85480003;
        locals[8] = locals[178] << 0xd ^ ~(locals[12] << 0xd);
        locals[60] = ((locals[236] & 0x624c8 ^ 0x91a8) & locals[181] ^ locals[236] & 0x3cc30 ^ 0x635b8) & locals[34] ^
                     ~(locals[236] & 0xfffffdef) & locals[181] & 0x3df30 ^ locals[236] & 0x6e610;
        locals[233] = ((locals[236] & 0x3cee8 ^ 0x4a260) & locals[181] ^ locals[236] & 0x67f10 ^ 0x4b340) & locals[34] ^
                      (locals[236] & 0x67fd8 ^ 0x76470) & locals[181] ^ ~(locals[236] & 0x8200) & 0xfffcbb47;
        locals[6] = locals[60] << 0xd;
        locals[21] = (locals[12] & locals[178]) << 0xd & ~(locals[7] << 0xd);
        locals[234] = locals[233] << 0xd;
        locals[9] = ~locals[6] & locals[234];
        locals[23] = ((((locals[23] ^ 0xf9cb8ac7) & locals[181] ^ 0x8040) & 0x3cee8 ^ locals[236] & 0x39530) &
                      locals[34] ^
                      (locals[236] & 0x5b10 ^ 0x29d10) & locals[181] ^ locals[236] & 0x77d30) << 0xd;
        locals[60] = (locals[233] ^ locals[60]) << 0xd;
        locals[61] = locals[60] ^ 0x1fff;
        locals[7] = ~locals[9] & locals[23] ^ locals[6] ^ 0x1fff;
        locals[9] = (locals[9] ^ locals[6]) & locals[23] ^ locals[234] ^ 0x1fff;
        locals[23] = locals[9] ^ locals[7];
        locals[234] = locals[23] & locals[61] & 0x7fffffff;
        locals[233] = locals[234] >> 3;
        locals[9] = (locals[7] ^ locals[61] ^ 0x7fffffff) & locals[9] ^ (locals[60] ^ 0x7fffe000) & locals[7] ^
                    0x80000000;
        locals[7] = locals[9] >> 3;
        locals[23] = (locals[23] & 0x7fffffff) >> 3;
        locals[9] = (locals[9] ^ locals[234]) >> 3;
        locals[180] = ~(~locals[233] & locals[23] & locals[7]);
        locals[237] = ~locals[23] & locals[7] & locals[233] ^ 0xe0000000;
        locals[6] =
            (~(locals[236] & 3) & locals[181] & 0x67f00007 ^ locals[236] & 0xd9f80004 ^ 0x4ce80004) & locals[34] ^
            (locals[236] & 0xbf580002 ^ 0xf6800006) & locals[181] ^ locals[236] & 0x2a600002 ^ 0x85480002;
        locals[233] = ((locals[236] & 0x85480003 ^ 0x81400007) & locals[181] ^ locals[236] & 0x81080004 ^ 0x4480004) &
            locals[34] ^ (~(locals[236] & 2) & locals[181] ^ 2) & 6 ^ locals[236] & 1;
        locals[7] = locals[6] ^ locals[104];
        locals[234] = locals[233] << 0x1d;
        locals[61] = (locals[6] & locals[104]) >> 0x13;
        locals[6] = locals[6] << 0x1d;
        locals[23] = ~locals[234] & locals[104] << 0x1d ^ locals[6];
        locals[60] = locals[7] >> 0x13;
        locals[2] = ~((locals[233] & locals[7]) >> 0x13);
        locals[233] = locals[61] ^ locals[2] ^ locals[21];
        locals[1] = (locals[60] ^ locals[2]) & ~locals[61];
        locals[61] =
            ((locals[233] ^ locals[8]) & locals[60] ^ (locals[61] ^ locals[21] ^ locals[8]) & locals[2] ^ locals[21]) &
            locals[103] ^
            (locals[233] & locals[60] ^ (locals[61] ^ locals[21]) & locals[2] ^ locals[21]) & locals[8] ^ locals[1];
        locals[1] = (~locals[1] ^ locals[60] & locals[2] ^ locals[21]) & (locals[8] ^ locals[103]) ^ locals[60] ^
                    locals[2];
        locals[233] = ~((~locals[60] ^ locals[2]) & locals[21]);
        locals[103] = ~(((~locals[60] ^ locals[2]) & locals[8] ^ locals[233]) & locals[103]) ^ locals[233] & locals[8] ^
                      locals[60] & locals[2];
        locals[7] = locals[7] << 0x1d;
        locals[8] = ((locals[61] & 0xfffffffe ^ 1) & locals[1] ^ 1) & locals[103] ^ ~locals[61] & locals[1] & 1;
        locals[6] = ~(~(~locals[6] & locals[104] << 0x1d) & locals[234]) ^ locals[6];
        locals[233] = (locals[6] ^ locals[7]) & locals[23];
        locals[234] = ~((~locals[5] & locals[4] ^ locals[233] ^ locals[6] ^ locals[7]) & locals[22]) ^
                      (~locals[233] ^ locals[6] ^ locals[7]) & locals[5] ^ locals[6];
        locals[2] = ~((~locals[103] ^ locals[1]) & locals[61] & 1) ^ locals[1];
        locals[104] = (~(~locals[1] & locals[61]) & 0xfffffffe ^ locals[1]) & locals[103] ^ ~locals[1] & locals[61] ^ 1;
        locals[103] = ~((locals[2] & 0x3c00000 ^ 0xfc3fffff) & locals[8]) & locals[104];
        locals[21] = (~((~locals[6] ^ locals[22]) & locals[23]) ^ locals[6] ^ locals[22]) & locals[7] ^
                     ~((~locals[23] ^ locals[5] ^ locals[4]) & locals[6]) & locals[22] ^ locals[5];
        locals[60] = ~(~locals[104] & locals[8] & 0xfc3fffff) ^ locals[104];
        locals[61] = (~(~locals[2] & locals[104]) & 0x3c00000 ^ locals[2]) & locals[8] ^ locals[104] & 0x3c00000;
        locals[5] = (~((locals[5] ^ locals[4]) & locals[6]) ^ locals[233] ^ locals[7] ^ locals[4]) & locals[22] ^
                    (~locals[7] & locals[23] ^ locals[7] ^ locals[5]) & locals[6] ^ locals[5];
        locals[7] = ~locals[21];
        locals[140] = (~((locals[7] ^ locals[234] ^ locals[24]) & locals[10]) ^ locals[21] ^ locals[234] ^ locals[24]) &
                      locals[5] ^
                      (locals[5] ^ locals[10]) & locals[11] & locals[24] ^ locals[21] ^ locals[10];
        locals[7] = (~((locals[7] ^ locals[11]) & locals[10]) ^ ~locals[11] & locals[21] ^ locals[11]) & locals[24] ^
                    (locals[7] & locals[234] ^ (locals[7] ^ locals[234]) & locals[10] ^ locals[21]) & locals[5] ^
                    locals[21];
        locals[5] = ~(((locals[21] ^ locals[234]) & locals[5] ^ (locals[21] ^ locals[11]) & locals[24] ^ locals[21]) &
                      locals[10]) ^
                    (~locals[234] & locals[5] ^ ~locals[11] & locals[24]) & locals[21] ^ locals[5];
        locals[10] = (locals[7] ^ 0xfffe1ff) & locals[140] ^ locals[7];
        locals[11] = ~(locals[10] & locals[5]);
        locals[3] = ~((locals[10] ^ 0xfffe1ff) & locals[5]) ^ locals[140] & 0xf0001e00;
        locals[140] = ((locals[140] & 0xf0001e00 ^ 0xfffe1ff) & locals[5] ^ locals[140]) & locals[7] ^ locals[140];
        locals[15] = ~locals[140];
        locals[234] = ~(((locals[3] ^ locals[11] ^ locals[61]) & locals[140] ^ (locals[15] ^ locals[61]) & locals[103] ^
                         locals[11] ^ locals[61])
                        & locals[60]) ^ (~(locals[61] & locals[103]) ^ locals[3]) & locals[140] ^ locals[11];
        locals[99] = (locals[15] & locals[61] ^ locals[60] & (locals[140] ^ locals[61])) & locals[103] ^
                     ~((~locals[3] ^ locals[11] ^ locals[61]) & locals[60]) & locals[140] ^ locals[11];
        locals[21] = ((locals[61] ^ locals[60]) & locals[11] ^ ~locals[61] & locals[60]) & locals[103] ^
                     (~(locals[11] & (locals[140] ^ locals[61])) ^ locals[140] ^ locals[61]) & locals[60] ^
                     ~((locals[11] ^ locals[60]) & locals[3]) & locals[140];
        locals[23] = ~((locals[21] ^ locals[99]) * 2) & locals[234] * 2 ^ locals[21] * 2;
        locals[10] = locals[21] << 2;
        locals[7] = locals[234] << 2;
        locals[233] = locals[99] << 2;
        locals[5] = (~locals[10] & locals[7] ^ locals[10]) & locals[233] ^ locals[10];
        locals[24] = ~(~locals[10] & locals[7]) & locals[233] ^ locals[7];
        locals[233] = ~(~locals[233] & locals[7]) & locals[10] ^ locals[233];
        locals[22] = locals[21] << 3;
        locals[104] = locals[234] << 3;
        locals[10] = locals[99] << 3;
        locals[19] = ~(locals[10] & ~locals[22]) & locals[104] ^ locals[22];
        locals[22] = ~((locals[104] & ~locals[22] ^ locals[22]) & locals[10]) ^ locals[22];
        locals[104] = ~locals[10] ^ locals[104];
        locals[7] = ~locals[104] & locals[19] ^ locals[22];
        locals[10] = ~locals[19];
        locals[1] = ~(locals[22] & locals[10]) ^ locals[104];
        locals[8] = locals[104] & locals[19] ^ locals[22];
        locals[6] = ~((~locals[5] ^ locals[233]) & locals[23]) & locals[24] ^ locals[233];
        locals[2] = ((locals[5] ^ locals[233]) & locals[24] ^ locals[233]) & locals[23] ^
                    (locals[24] ^ locals[5]) & locals[233] ^ locals[24];
        locals[5] = ~(locals[24] & locals[233]) & locals[5];
        locals[20] = locals[5] ^ locals[23];
        locals[59] = ~(~locals[6] & locals[2] & locals[23]) & locals[20] ^ locals[5] & locals[6];
        locals[233] = ~locals[20];
        locals[14] = ~(locals[2] & locals[23] & locals[233]) & locals[6] ^ locals[20];
        locals[13] = ~((locals[23] & locals[233] ^ locals[20]) & locals[6]) ^
                     ~((locals[20] ^ locals[6]) & locals[2]) & locals[23];
        locals[5] = ((locals[13] ^ locals[59] ^ locals[234]) & locals[14] ^ locals[13] ^ locals[59] ^ locals[234]) &
                    locals[99] ^
                    (~((locals[99] ^ ~locals[14]) & locals[234]) ^ locals[14] ^ locals[99]) & locals[21] ^
                    (locals[234] ^ ~locals[13] ^ locals[59]) & locals[14] ^ locals[59] ^ locals[234];
        locals[24] = (locals[99] ^ ~locals[21]) & locals[234];
        locals[4] = (locals[59] & ~locals[14] ^ locals[21] ^ locals[99] ^ locals[24]) & locals[13] ^
                    (~locals[24] ^ locals[21] ^ locals[99]) & locals[14] ^ locals[99];
        locals[13] =
            ((locals[14] ^ locals[21]) & locals[234] ^ locals[14] & (~locals[13] ^ locals[59]) ^ locals[59] ^
             locals[21]) & locals[99] ^
            (locals[234] & ~locals[21] ^ locals[13] ^ locals[21]) & locals[14] ^ locals[13];
        locals[100] = locals[4] ^ locals[5];
        locals[101] = ~((~((~locals[13] ^ locals[6]) & locals[2]) ^ locals[13] ^ locals[6]) & locals[20]) ^
                      (~((locals[2] ^ locals[100]) & locals[13]) ^ locals[5]) & locals[6] ^ locals[13] & ~locals[5] ^
                      locals[5];
        locals[14] = (locals[19] ^ locals[22]) & locals[100] ^ locals[4] ^ locals[5];
        locals[99] = locals[13] & locals[14];
        locals[24] = (locals[22] ^ locals[10]) & locals[4];
        locals[21] = locals[19] & locals[100] ^ locals[4] ^ locals[5];
        locals[102] = locals[13] & locals[21];
        locals[234] = (locals[4] & locals[10] ^ locals[102]) & locals[22] ^ ~((locals[24] ^ locals[99]) & locals[104]) ^
                      locals[4] ^ locals[5];
        locals[59] = locals[20] & locals[100];
        locals[21] = locals[22] & locals[21] ^ locals[104] & locals[14] ^ locals[13] & locals[100] ^ locals[5];
        locals[10] = (~(locals[2] & ~locals[5]) ^ locals[5]) & locals[20];
        locals[10] = ~((~(((locals[4] ^ ~locals[59]) & locals[2] ^ locals[4] ^ locals[5] ^ locals[59]) & locals[13]) ^
                        locals[5] ^ locals[2] ^
                        locals[10]) & locals[6]) ^ (~locals[10] ^ locals[4]) & locals[13] ^
                     ~locals[2] & locals[5] & locals[20];
        locals[24] = (locals[19] & ~locals[4] ^ ~locals[102] ^ locals[4]) & locals[22] ^
                     ~((~locals[99] ^ locals[19] ^ locals[22] ^ locals[24]) & locals[104]) ^ locals[4] & locals[5];
        locals[104] = ((~((locals[5] ^ ~locals[59]) & locals[13]) ^ locals[20] ^ locals[5] & locals[233]) & locals[2] ^
                       (locals[4] ^ locals[5] ^ locals[59]) & locals[13] ^ locals[20] ^ locals[5] & locals[233]) &
                      locals[6] ^
                      ((~(locals[2] & ~locals[4]) ^ locals[4]) & locals[20] ^ locals[4]) & locals[13];
        locals[13] = locals[101] ^ locals[23];
        locals[22] = (~((locals[10] ^ ~locals[104]) & locals[23]) ^ locals[104] & locals[10]) & locals[101] ^
                     (~(locals[10] & ~locals[104]) ^ locals[104]) & locals[23] ^ locals[10];
        locals[2] = (~(locals[23] & (locals[104] ^ locals[10])) ^ locals[104] & ~locals[10]) & locals[101] ^
                    (~(locals[23] & ~locals[10]) ^ locals[10]) & locals[104] ^ locals[10];
        locals[4] = ~locals[1] ^ locals[7];
        locals[23] = locals[8] & locals[4];
        locals[233] = (~((~(locals[13] & locals[4]) ^ locals[1] ^ locals[7]) & locals[8]) ^ ~locals[13] & locals[1] ^
                       locals[13]) & locals[2];
        locals[233] = ((~locals[23] ^ locals[1]) & locals[13] ^ ~locals[233]) & locals[22] ^ locals[13] ^ locals[233];
        locals[5] = (locals[13] & locals[2] ^ locals[1] ^ locals[23]) & locals[22] ^
                    (locals[2] ^ locals[1] ^ locals[23]) & locals[13];
        locals[64] = (locals[24] ^ ~locals[234] & locals[21]) & 0x82001000 ^ 0x7dffefff;
        locals[6] = (~(locals[24] & locals[21]) & locals[234] ^ locals[24]) & 0x82001000 ^ 0x7dffefff;
        locals[23] = (locals[24] ^ locals[21]) & 0x82001000;
        locals[2] = (~((~((~(locals[22] & locals[4]) ^ locals[1] ^ locals[7]) & locals[2]) ^ locals[1] ^ locals[7]) &
                       locals[13]) ^ locals[1] ^
                     locals[7] ^ locals[22] & locals[4]) &
            locals[8] ^ (~(~locals[22] & locals[13] & locals[2]) ^ locals[13] ^ locals[22]) & locals[1]
                      ^ (locals[13] ^ locals[2]) & locals[22] ^ locals[2];
        locals[99] = ((locals[233] ^ locals[101]) & locals[5] ^ locals[233] ^ locals[101]) & locals[104] ^
                     ~((locals[101] & (locals[5] ^ locals[104]) ^ locals[5] ^ locals[104]) & locals[10]) ^
                     ~(locals[2] & (locals[5] ^ locals[104])) & locals[233] ^ locals[5];
        locals[7] = locals[6] >> 3;
        locals[22] = locals[23] >> 3;
        locals[19] = ~(locals[64] >> 3) & locals[7] ^ ~locals[22] & locals[64] >> 3 ^ 0xe0000000;
        locals[8] = (locals[23] ^ locals[6]) >> 3;
        locals[23] = locals[101] & (locals[104] ^ locals[10]);
        locals[13] = ~((~((locals[104] ^ ~locals[233]) & locals[101]) ^ locals[233] ^ locals[104]) & locals[10]) ^
                     ~((~locals[2] ^ locals[5] ^ locals[101]) & locals[233]) & locals[104] ^ locals[5];
        locals[1] = ~locals[5];
        locals[104] = ~((locals[2] & locals[1] ^ ~locals[23] ^ locals[104] ^ locals[10]) & locals[233]) ^
                      (locals[104] ^ locals[10] ^ locals[23]) & locals[5] ^ locals[104];
        locals[14] = ~locals[104];
        locals[10] = locals[13] & locals[14];
        locals[4] = (locals[13] ^ locals[14]) & locals[99];
        locals[6] = ((locals[233] ^ locals[10] ^ locals[4]) & locals[2] & locals[5] ^
                     ~(locals[5] & ~locals[233]) & (locals[10] ^ locals[4])) &
            0x82001000 ^ 0x7dffefff;
        locals[22] = ~locals[7] & locals[22];
        locals[7] = ~((~((~((locals[104] ^ locals[13]) & locals[1]) ^ locals[5]) & locals[99] & 0x82001000) ^
                       locals[13] & locals[14] & locals[1] & 0x82001000 ^ locals[5]) & locals[2]) ^
                    ((locals[2] ^ locals[10]) & 0x82001000 ^ ~(locals[4] & 0x82001000)) & locals[5] & locals[233] ^
                    locals[10] ^ locals[4]
            ;
        locals[233] = ~(((locals[233] & 0x82001000 ^ 0x7dffefff) & locals[2] ^ locals[233] & 0x7dffefff ^ 0x82001000) &
                        locals[5]) ^ locals[2] ^ locals[10] ^ locals[4];
        locals[1] = locals[13] & 0x7dffefff;
        locals[23] = locals[104] & (locals[1] ^ 0x82001000);
        locals[5] = ~locals[13];
        locals[59] = ~locals[7];
        locals[2] = ~(((~(locals[4] & 0x7dffefff) ^ locals[7] & 0x82001000 ^ locals[23] ^ locals[1]) & locals[233] ^
                       ((locals[5] ^ locals[4]) & 0x7dffefff ^ locals[23]) & locals[7]) & locals[6]) ^
                    ((locals[104] ^ locals[5]) & locals[99] ^ locals[13]) & locals[59] & 0x7dffefff ^
                    (locals[7] & (locals[1] ^ 0x82001000) ^ locals[1] ^ 0x82001000) & locals[104] ^ locals[7];
        locals[23] = ~locals[233];
        locals[20] = (((((locals[13] ^ locals[23]) & locals[104] ^ locals[23] & locals[5]) & locals[99] ^
                        ~(locals[13] & locals[23] & locals[14]))
                          & locals[7] ^ ~(locals[104] & locals[13] & locals[99]) & locals[233]) & locals[6] ^
                      ~(locals[13] & locals[99] & locals[59]) & locals[104]) & 0x82001000 ^ 0x7dffefff;
        locals[13] = ((((locals[13] ^ locals[59]) & locals[104] ^ locals[59] & locals[5]) & locals[99] ^
                       ~(locals[13] & locals[59] & locals[14]))
                      & locals[233] & locals[6] ^
                      ((~(locals[13] & ~locals[6]) & locals[7] ^ locals[5]) & locals[104] ^ locals[59] & locals[5]) &
                      locals[99] ^
                      (~locals[6] ^ locals[10]) & locals[7] ^ locals[10]) & 0x82001000 ^ 0x7dffefff;
        locals[23] = locals[13] ^ locals[24];
        locals[7] = locals[7] >> 2;
        locals[104] = ~((locals[6] & locals[233]) >> 2) ^ locals[7];
        locals[4] = (locals[24] ^ locals[234]) & locals[21];
        locals[1] = ~locals[2];
        locals[5] = ((locals[2] ^ locals[24]) & locals[20] ^ (locals[234] ^ locals[1]) & locals[24] ^ locals[234] ^
                     locals[4]) & locals[13] ^
                    (~(locals[20] & locals[1]) ^ locals[2] ^ ~locals[234] & locals[21]) & locals[24];
        locals[10] = ~(locals[233] >> 2);
        locals[233] = ~locals[7] & locals[233] >> 2 ^ locals[10] & locals[6] >> 2;
        locals[21] = (locals[10] & locals[7] ^ ~(locals[6] >> 2)) & 0x3fffffff;
        locals[14] = locals[233] ^ locals[21];
        locals[6] = (locals[233] ^ locals[8]) & locals[21];
        locals[10] = (~((locals[8] ^ locals[14]) & locals[104]) ^ ~locals[8] & locals[19] ^ locals[233] ^ locals[6]) &
                     locals[22] ^
                     ((locals[19] ^ locals[14]) & locals[104] ^ (locals[233] ^ locals[19]) & locals[21] ^ locals[233]) &
                     locals[8] ^
                     (locals[21] ^ locals[104]) & locals[19] ^ locals[21];
        locals[4] = (~locals[13] ^ locals[2]) & locals[20] ^ ~locals[24] & locals[234] ^ locals[13] & locals[1] ^
                    locals[2] ^ locals[4];
        locals[24] = (~(~locals[4] & locals[23]) & locals[5] ^ locals[4] & locals[23]) & 0x82001000;
        locals[7] = ~((~((locals[233] ^ locals[22] ^ locals[19]) & locals[8]) ^ locals[22] ^ locals[19] ^ locals[6]) &
                      locals[104]) ^
                    (~(~locals[233] & locals[21]) ^ locals[233]) & locals[8] ^ locals[21] ^ locals[22];
        locals[234] = (~(~locals[5] & locals[23]) & locals[4] ^ locals[5]) & 0x82001000;
        locals[8] = (~((~locals[21] ^ locals[22]) & locals[8]) ^ locals[21] ^ locals[22]) & locals[19] ^
                    (locals[104] & locals[14] ^ locals[233] ^ locals[6]) & locals[22] ^
                    (~(locals[104] & ~locals[21]) ^ locals[21]) & locals[233]
                    ^ locals[104] ^ locals[8];
        locals[233] = ~(locals[4] & 0x82001000) ^ locals[23] & 0x82001000;
        locals[23] = (locals[233] & locals[234] ^ locals[24]) >> 1;
        locals[104] = ~(~(locals[234] >> 1) & locals[233] >> 1) ^ locals[24] >> 1;
        locals[6] = ((locals[234] ^ locals[24]) & locals[233] ^ locals[234]) >> 1;
        locals[234] = ~(((locals[23] ^ locals[2]) & locals[104] ^ locals[23] ^ locals[2]) & locals[13]) ^
                      (~((locals[104] ^ locals[13]) & locals[2]) ^ locals[104] ^ locals[13]) & locals[20] ^
                      (locals[23] & (locals[104] ^ locals[13]) ^ locals[104] ^ locals[13]) & locals[6] ^ locals[104];
        locals[24] = locals[6] ^ ~locals[104];
        locals[233] = locals[23] & locals[24];
        locals[22] = (~locals[23] & locals[6] ^ locals[13] & locals[2]) & locals[104] ^
                     ((locals[13] ^ ~locals[104]) & locals[2] ^ locals[104] ^ locals[6] ^ locals[233]) & locals[20] ^
                     locals[13];
        locals[6] = (~(locals[13] & locals[24]) ^ locals[104] ^ locals[6]) & locals[23] ^
                    (~locals[233] ^ locals[104] ^ locals[6]) & locals[20] ^
                    (locals[104] ^ locals[6]) & locals[13] ^ locals[6];
        locals[5] = (locals[22] ^ locals[8]) & locals[7];
        locals[104] = locals[8] & ~locals[22];
        locals[233] = locals[6] & locals[234] & ~locals[22];
        locals[23] = locals[234] & (locals[22] ^ locals[6]);
        locals[8] = (locals[6] ^ locals[8]) & locals[22];
        locals[24] = (~locals[5] ^ locals[104]) & locals[10] ^ (locals[8] ^ locals[23]) & locals[7] ^ locals[22] ^
                     locals[233];
        locals[234] = ((~locals[7] ^ locals[10]) & locals[6] ^ locals[7] ^ locals[10]) & locals[22] ^
                      ((locals[7] ^ locals[10]) & (locals[22] ^ locals[6]) ^ locals[22] ^ locals[6]) & locals[234] ^
                      locals[7];
        locals[233] = ~((~locals[23] ^ locals[8] ^ locals[5]) & locals[10]) ^ ~locals[104] & locals[7] ^ locals[233];
        locals[7] = (~locals[24] & locals[234] & 0xf0000000 ^ 0x1e00) & locals[233];
        locals[8] = ~locals[234];
        locals[104] = ((locals[234] ^ 0xffffe1ff) & locals[24] ^ 0x1e00) & locals[233] ^
                      (locals[24] & locals[8] ^ locals[234]) & 0xffffe1ff;
        locals[6] = locals[104] & 0xf0001e00;
        locals[10] = locals[234] & ~locals[233];
        locals[21] = ~((locals[234] ^ ~locals[233]) & locals[24] & 0x3c00000) ^ locals[10] & 0x3c00000;
        locals[238] = ~(((locals[234] ^ 0x1e00) & locals[233] ^ locals[8] & 0x1e00) & locals[24] & 0xf0001e00) ^
                      locals[10] & 0xf0001e00;
        locals[8] = locals[233] & locals[8] & 0x3c00000;
        locals[233] = locals[233] ^ locals[234];
        locals[234] = locals[233] & 0x3c00000;
        locals[10] = (~locals[7] ^ locals[140]) & locals[238];
        locals[2] = ~locals[238];
        locals[232] = ~((~((locals[238] ^ locals[140]) & locals[11]) ^ locals[2] & locals[140]) & locals[3]) ^
                      (~((locals[2] ^ locals[11]) & locals[7]) ^ locals[238] ^ locals[11]) & locals[6] ^
                      (locals[7] ^ locals[10] ^ locals[140]) & locals[11] ^ locals[7] ^ locals[10] ^ locals[140];
        locals[22] = (~locals[234] ^ locals[61]) & locals[60];
        locals[24] = (~locals[234] ^ locals[60]) & locals[21] ^ locals[61];
        locals[5] = locals[22] ^ locals[61];
        locals[10] = locals[61] & 0x79da5ff6;
        locals[65] = ((locals[60] & 0xdf75fb79 ^ locals[233] & 0x1c00000 ^ 0xe7bfbfff) & locals[8] ^
                      (locals[10] ^ 0xa0aad42c) & locals[60] ^ locals[24] & 0x79da5ff6 ^ 0x471774c1) & locals[103] ^
                     (((locals[234] ^ 0x41101b70) & 0xdf75fb79 ^ locals[10]) & locals[60] ^ locals[233] & 0x1800000 ^
                      locals[10] ^
                      0xa6adbb9d) & locals[21] ^
                     ((locals[233] & 0x2800000 ^ 0x38ca4486) & locals[21] ^ locals[233] & 0x3000000 ^
                      locals[5] & 0xdf75fb79 ^
                      0x7dfb2464) & locals[8] ^ (locals[61] & 0x986090aa ^ 0x3aee4fb7) & locals[60] ^
                     locals[61] & 0x986090aa ^
                     0xd0689787;
        locals[23] = ~(locals[234] << 6);
        locals[100] = locals[21] << 6;
        locals[239] = ((locals[233] & 0x3800000 ^ locals[60] & 0xbcfbf7ff ^ 0x7bd7fcd4) & locals[8] ^
                       (locals[61] & 0xc7afebab ^ 0xc7d364f2) & locals[60] ^ locals[24] & 0xc7afebab ^ 0xbea1b925) &
                      locals[103] ^ (((locals[61] ^ 0x83e080) & 0xc7afebab ^ locals[233] & 0xc00000) & locals[60] ^
                                     locals[233] & 0x3400000 ^ locals[61] & 0xc7afebab ^ 0x79f13d57) & locals[21] ^
                      ((locals[233] & 0x3400000 ^ 0xc72c0b2b) & locals[21] ^ locals[5] & 0xbcfbf7ff ^ 0x7b0ad69e) &
                      locals[8]
                      ^ (locals[61] & 0xff6fd9 ^ 0xc70e4eb8) & locals[60] ^ locals[61] & 0xff6fd9 ^ 0xcba7d9f6;
        locals[182] = ~(~(locals[100] & locals[23]) & locals[8] << 6) ^ locals[234] << 6;
        locals[10] = locals[61] & 0xbf7dbcdf;
        locals[66] = ((locals[60] & 0xfffedfaf ^ locals[233] & 0x3400000 ^ 0xfeef677f) & locals[8] ^
                      (locals[10] ^ 0xe60171f6) & locals[60] ^ locals[24] & 0xbf7dbcdf ^ 0x24ce129f) & locals[103] ^
                     ((locals[233] & 0xc00000 ^ locals[22] ^ locals[61]) & 0xfffedfaf ^
                      (locals[233] & 0x800000 ^ 0x111b8d0) & locals[21] ^ 0x83ddab59) & locals[8] ^
                     (((locals[234] ^ 0xbe6d245f) & 0xfffedfaf ^ locals[10]) & locals[60] ^ locals[233] & 0x400000 ^
                      locals[10] ^
                      0x7ca36766) & locals[21] ^ (locals[61] & 0xe710c926 ^ 0x9b33bdd0) & locals[60] ^
                     locals[61] & 0xe710c926
                     ^ 0xd76ebc59;
        locals[24] = ~(locals[234] >> 0xd);
        locals[19] = ~((locals[21] & locals[234]) >> 0xd) & locals[8] >> 0xd ^ locals[24];
        locals[20] = locals[19] & 0x7ffff;
        locals[4] = locals[6] << 0x13;
        locals[103] = ~(locals[7] << 0x13) & locals[4] ^ locals[238] << 0x13 ^ 0x7ffff;
        locals[99] = (locals[234] ^ locals[21]) >> 0xd;
        locals[60] = ((locals[65] & 0x621d0 ^ 0x2c28) & locals[239] ^ locals[65] & 0xd00 ^ 0x32ac0) & locals[66] ^
                     (locals[65] & 0x304c0 ^ 0x2b7c0) & locals[239] ^ locals[65] & 0xc00;
        locals[233] = locals[6] & ~locals[7];
        locals[61] = ~locals[6];
        locals[5] = ((locals[7] ^ locals[140] ^ locals[3]) & locals[238] ^ locals[140] & locals[3] ^
                     locals[7] & locals[61] ^ locals[6]) & locals[11]
                    ^ (locals[15] & locals[3] ^ ~locals[233] ^ locals[140]) & locals[238] ^ locals[3];
        locals[10] = ((locals[65] & 0x2bf40 ^ 0x10800) & locals[239] ^ locals[65] & 0x20740 ^ 0x2800) & locals[66] ^
                     (~(locals[65] & 0x10500) & locals[239] ^ locals[65] & 0x19100) & 0x7bff8;
        locals[22] = ((locals[65] & 0xe6a80004 ^ 0xa5200007) & locals[239] ^ locals[65] & 0x40b80004 ^ 0xc6800006) &
                     locals[66];
        locals[59] = ~(locals[24] & locals[21] >> 0xd) & locals[8] >> 0xd ^ locals[234] >> 0xd;
        locals[24] = (~(locals[65] & 1) & locals[239] ^ ~locals[65] & 1) & 7 ^ locals[22];
        locals[140] = ~((locals[234] & locals[21]) << 6) & locals[8] << 6 ^ locals[100] ^ 0x3f;
        locals[183] = (locals[6] & locals[7] ^ locals[238]) << 0x13;
        locals[8] = locals[60] << 0xd;
        locals[234] = ~locals[8];
        locals[21] = locals[10] << 0xd;
        locals[13] = (((locals[65] & 0x49e90 ^ 0x5b110) & locals[239] ^ locals[65] & 0x4fe90 ^ 0x7fbd0) & locals[66] ^
                      (locals[65] & 0x4fbb8 ^ 0x49538) & locals[239] ^ locals[65] & 0x566b8 ^ 0xfffcd53f) << 0xd;
        locals[14] = ~locals[13];
        locals[1] = (locals[21] & locals[234] ^ locals[14]) & 0xffffe000;
        locals[2] = (locals[6] ^ locals[2]) & locals[7];
        locals[100] = locals[100] ^ locals[23];
        locals[15] = (~locals[2] ^ locals[238] ^ locals[6]) & locals[11] ^
                     (locals[238] ^ locals[6] ^ locals[2]) & locals[3] ^ locals[238];
        locals[11] = locals[232] ^ locals[15];
        locals[240] = locals[7] ^ locals[61];
        locals[23] = locals[104] & 0xf0000600;
        locals[241] = ((locals[5] & 0xfcffa6ff ^ locals[11] & 0x7ff67b6b) & locals[240] ^
                       (locals[23] ^ 0x881f09db) & locals[7] ^
                       locals[61] & 0x881f09db) & locals[238] ^
                      ((locals[7] & 0x7ff67b6b ^ 0xa88da495) & locals[6] ^ (locals[23] ^ 0xdc6d0bb1) & locals[5] ^
                       locals[232] & 0x7ff67b6b ^ 0x54c0ed0c) & locals[15] ^
                      ((locals[23] ^ 0x2092ad4e) & locals[232] ^ locals[233] & 0xfcffa6ff ^ 0xff5ed043) & locals[5] ^
                      ((locals[7] ^ 0xd47b86fe) & locals[6] & 0x7ff67b6b ^ 0xa3299fbc) & locals[232] ^
                      (locals[7] & 0x74e0af24 ^ 0x8bbe7f67) & locals[6] ^ 0xec69dac5;
        locals[2] = ~(locals[238] << 0x13) & locals[4] ^ ~locals[4] & locals[7] << 0x13;
        locals[102] = ((locals[65] & 0xe6a80004 ^ 0x42980007) & locals[239] ^ locals[65] & 0x3b680004 ^ 0xcde80006) &
            locals[66] ^ (locals[65] & 0xfee80001 ^ 0x52980001) & locals[239] ^ locals[65] & 0x23280001 ^ 0x2a57fffe
            ;
        locals[141] = ~(~(locals[66] & 0xfffffffd) & locals[239] & locals[65] & 6);
        locals[179] = locals[141] ^ locals[66] & 0xe7b80000;
        locals[4] = ~locals[18];
        locals[3] = locals[183] ^ ~locals[2];
        locals[101] = (~((locals[2] ^ locals[183] ^ locals[103] ^ locals[4]) & locals[178]) ^
                       (locals[103] ^ locals[3]) & locals[18] ^ locals[2] ^
                       locals[183] ^ locals[103]) & locals[12] ^
                      ((locals[103] ^ locals[2] ^ locals[183]) & locals[178] ^
                       (locals[103] ^ ~locals[2]) & locals[183]) & locals[18] ^ locals[2]
                      ^ locals[183];
        locals[23] = locals[104] & 0xb0001e00;
        locals[105] = ((locals[5] & 0xbfd95f1f ^ locals[11] & 0xd0bfbdfc) & locals[240] ^
                       (locals[23] ^ 0xf9e8dd73) & locals[7] ^
                       locals[61] & 0xf9e8dd73) & locals[238] ^
                      ((locals[7] & 0xd0bfbdfc ^ 0xbf50431f) & locals[6] ^ (locals[23] ^ 0xf961c173) & locals[5] ^
                       locals[232] & 0xd0bfbdfc ^ 0x96bb9260) & locals[15] ^
                      ((locals[23] ^ 0x46b89e6c) & locals[232] ^ locals[233] & 0xbfd95f1f ^ 0x22076f9c) & locals[5] ^
                      ((locals[7] ^ 0x891c00) & locals[6] & 0xd0bfbdfc ^ 0xbfecf2ef) & locals[232] ^
                      (locals[7] & 0x4631826c ^ 0x6436edf0) & locals[6] ^ 0xd19b8506;
        locals[22] = locals[22] >> 0x13;
        locals[242] = ~locals[22];
        locals[23] = (~(locals[179] >> 0x13) & locals[102] >> 0x13 ^ locals[242]) & 0x1fff;
        locals[35] = (~((locals[103] ^ locals[4]) & locals[178]) ^ locals[103] & locals[4] ^ locals[18]) & locals[12] ^
                     (locals[183] & (locals[103] ^ locals[4]) ^ locals[18] ^ locals[103]) & locals[2] ^
                     ~((locals[183] ^ locals[178]) & locals[18]) & locals[103] ^ locals[18] ^ locals[183];
        locals[4] = (locals[102] ^ locals[24]) << 0x1d;
        locals[18] = ((locals[18] ^ locals[12]) & (locals[2] ^ locals[183]) ^ locals[18] ^ locals[12]) & locals[178] ^
                     (~(locals[18] & locals[3]) ^ locals[2] ^ locals[183]) & locals[12] ^
                     ~(locals[2] & locals[183]) & locals[103] ^ locals[18];
        locals[2] = locals[141] << 0x1d & ~locals[4] ^ locals[24] << 0x1d ^ 0x1fffffff;
        locals[12] = (locals[10] & locals[60]) << 0xd ^ locals[13] & locals[234] ^ 0x1fff;
        locals[234] = ~(locals[102] << 0x1d) & locals[24] << 0x1d;
        locals[22] = ~((locals[102] & locals[179]) >> 0x13) ^ locals[22];
        locals[24] = (locals[179] ^ locals[24]) >> 0x13 ^ ~(locals[242] & locals[102] >> 0x13);
        locals[104] = locals[104] & 0xe0001a00;
        locals[106] = ((locals[11] & 0xbfffff97 ^ locals[5] & 0xef67fbff) & locals[240] ^
                       (locals[104] ^ 0x3679224c) & locals[7] ^
                       locals[61] & 0x3679224c) & locals[238] ^
                      ((locals[7] & 0xbfffff97 ^ 0x44631a6a) & locals[6] ^ (locals[104] ^ 0x9d7dc3d9) & locals[5] ^
                       locals[232] & 0xbfffff97 ^ 0x6f143cb3) & locals[15] ^
                      ((locals[104] ^ 0x721a3826) & locals[232] ^ locals[233] & 0xef67fbff ^ 0x9e706bd) & locals[5] ^
                      ((locals[7] ^ 0xeb04e1fd) & locals[6] & 0xbfffff97 ^ 0xe692e168) & locals[232] ^
                      (locals[7] & 0xd91ed9b3 ^ 0xd0f9df0e) & locals[6] ^ 0xfba1e021;
        locals[10] = locals[1] >> 3;
        locals[11] = (locals[234] ^ locals[4]) & locals[180];
        locals[6] = ~locals[11];
        locals[61] = (locals[11] ^ 0xffffffff ^ locals[234] ^ locals[4]) & locals[237] ^
                     (locals[6] ^ locals[234] ^ locals[4]) & locals[9] ^
                     ~locals[4] & locals[234];
        locals[11] = locals[12] >> 3;
        locals[103] = ((locals[14] & locals[8] ^ ~locals[21]) & 0xffffe000) >> 3;
        locals[13] = ~(~locals[11] & locals[103]) ^ locals[10];
        locals[60] = ~locals[10] & locals[11] ^ locals[103];
        locals[10] =
            (~(locals[105] & 0x19cc2) & 0x7fee3 ^ (locals[105] & 0x1793f ^ 0xa4c9) & locals[241]) & locals[106] ^
            (locals[105] & 0x929 ^ 0x20ed) & locals[241] ^ locals[105] & 0x840b;
        locals[7] = ((locals[105] & 0x1793f ^ 0x3becb) & locals[241] ^ locals[105] & 0x3ffff ^ 0x64228) & locals[106] ^
                    (locals[105] & 0x4481d ^ 0x64b79) & locals[241] ^ locals[105] & 0x4ec96 ^ 0xffff5179;
        locals[233] = ((~locals[234] ^ locals[4]) & locals[2] ^ locals[180] ^ locals[234]) & (locals[9] ^ locals[237]) ^
                      locals[234] ^ locals[4];
        locals[8] = ((locals[105] & 0x55822 ^ 0x57082) & locals[241] ^ locals[105] & 0x79662 ^ 0x11241) & locals[106] ^
                    (locals[105] & 0x2880 ^ 0x4e5fd) & locals[241] ^ locals[105] & 0x138c0;
        locals[11] = (locals[8] ^ locals[7]) << 0xd ^ 0x1fff;
        locals[104] = locals[7] << 0xd;
        locals[21] = locals[10] << 0xd;
        locals[8] = locals[8] << 0xd;
        locals[10] = ~(~locals[104] & locals[21]) & locals[8] ^ (locals[10] & locals[7]) << 0xd;
        locals[6] = ~((~((~locals[9] ^ locals[180] ^ locals[2]) & locals[234]) ^
                       (locals[9] ^ locals[180] ^ locals[2]) & locals[4] ^ locals[9] ^
                       locals[2]) & locals[237]) ^
                    (~((~locals[234] ^ locals[4]) & locals[9]) ^ locals[234] ^ locals[4]) & locals[2] ^
                    (locals[9] ^ locals[4]) & locals[234] ^ locals[6] & locals[9];
        locals[103] = ~((locals[1] & locals[12]) >> 3) ^ locals[103];
        locals[9] = (((locals[105] & 0x9007ffff ^ 0x47c00000) & locals[241] ^ locals[105] & 0x955fffff ^ 0xd600000) &
                        locals[106] ^ (locals[105] & 0x43900000 ^ 0xb57fffff) & locals[241]) >> 0x13 ^
                    ~(locals[105] >> 0x13 & 0xc51) & 0x1e51;
        locals[5] = ((locals[105] >> 0x13 ^ 0xffffff57) & locals[241] >> 0x13 & 0x5bc ^
                     (locals[105] & 0x6e680000 ^ 0x9a80000) >> 0x13) & locals[106] >> 0x13 ^
                    ((locals[105] & 0x42880000 ^ 0xf287ffff) & locals[241] ^ locals[105] & 0x6fe80000) >> 0x13;
        locals[7] = ~locals[5];
        locals[234] = (((locals[105] & 0x9007ffff ^ 0x4aa00000) & locals[241] ^ locals[105] & 0x2dc80000 ^ 0x66400000) &
                locals[106] ^ (locals[105] & 0xfee7ffff ^ 0x46e80000) & locals[241] ^ locals[105] & 0x24600000) >> 0x13
            ;
        locals[12] = ~((~(locals[233] & (locals[61] ^ locals[7])) ^ locals[5] & locals[61]) & locals[6]) ^
                     (~(locals[234] & (locals[61] ^ locals[7])) ^ locals[5] ^ locals[61]) & locals[9] ^
                     ~((locals[234] ^ locals[233]) & locals[5]) & locals[61];
        locals[233] = ((locals[5] ^ locals[61]) & locals[6] ^ locals[61] & locals[7]) & locals[233] ^
                      (~((locals[6] ^ locals[7]) & locals[234]) ^ locals[5] ^ locals[6]) & locals[9] ^
                      ~((locals[234] ^ locals[61]) & locals[6]) & locals[5] ^ locals[61];
        locals[7] = (locals[24] ^ locals[22]) & locals[23];
        locals[104] = ~(~(~locals[8] & locals[104]) & locals[21]) ^ locals[104];
        locals[7] = (locals[104] ^ locals[10] ^ locals[24] ^ locals[7]) & locals[11] ^
                    (~locals[7] ^ locals[104] ^ locals[24]) & locals[10] ^
                    locals[104] ^ locals[23];
        locals[234] = (~locals[6] ^ locals[61]) & locals[234];
        locals[9] = (~locals[234] ^ locals[6] ^ locals[61]) & locals[9] ^
                    (locals[6] ^ locals[61] ^ locals[234]) & locals[5] ^ locals[6];
        locals[8] = locals[10] ^ ~locals[104];
        locals[3] = ((locals[9] ^ locals[233]) & locals[12] ^ locals[233]) >> 0x13 ^ 0xffffe000;
        locals[14] = (~(locals[233] >> 0x13) & locals[12] >> 0x13 ^ ~(locals[6] >> 0x13)) & 0x1fff;
        locals[234] = ~(((locals[104] ^ locals[10] ^ locals[24] ^ locals[22]) & locals[11] ^
                         (~locals[104] ^ locals[24] ^ locals[22]) & locals[10]
                         ^ locals[104] & (locals[24] ^ locals[22]) ^ locals[24]) & locals[23]) ^
                      ~(~locals[10] & locals[104]) & locals[11] ^
                      (locals[8] ^ locals[11]) & locals[24] ^ locals[10];
        locals[11] = ((locals[10] ^ locals[24] ^ locals[22]) & locals[104] ^ locals[8] & locals[11] ^ locals[22]) &
                     locals[23] ^
                     (~locals[11] & locals[10] ^ locals[24]) & locals[104] ^ locals[10] ^ locals[11];
        locals[8] = (locals[233] & locals[12] ^ locals[9]) >> 0x13;
        locals[184] = ((locals[9] & 0xff80000 ^ 0x7ffff) & locals[233] ^ locals[9] & 0xfffffff) & locals[12];
        locals[102] = (locals[233] & 0x7ffff ^ 0xff80000) & locals[9] ^ 0x7ffff;
        locals[185] = ~locals[184];
        locals[24] = ((locals[7] & 0x10d01b50 ^ 0x66eb810c) & locals[234] ^ ~(locals[7] & 0xfffffffd) & 0x66eb810e) &
            locals[11] ^ (locals[7] & 0x763b9a5e ^ 0xfddee6a9) & locals[234] ^ locals[7] & 2;
        locals[141] = locals[24] ^ 0x71479691;
        locals[12] = ((~(locals[9] & 0xfff80000) & locals[12] ^ ~locals[9]) & locals[233] ^
                      ~(locals[12] & 0x7ffff) & locals[9]) &
                     0xfffffff;
        locals[179] = locals[12] ^ 0xf0000000;
        locals[12] = locals[12] << 0xd;
        locals[9] = ~((locals[179] & locals[102]) << 0xd) & locals[185] << 0xd ^ locals[12] ^ 0x1fff;
        locals[10] = ((locals[7] & 0xe32f6c34 ^ 0xc91b32a1) & locals[234] ^ ~locals[7] & 0xc91b32a3) & locals[11] ^
                     (locals[7] & 0x2a345e95 ^ 0xdfcdcb7a) & locals[234] ^ ~(locals[7] & 2) & 0xf16c4e86;
        locals[2] = ~locals[12] & locals[185] << 0xd ^ locals[102] << 0xd ^ 0x1fff;
        locals[233] = (locals[102] ^ locals[185]) << 0xd;
        locals[12] = ((locals[7] & 0x4d868689 ^ 0xd446ed71) & locals[234] ^ ~locals[7] & 0xd446ed73) & locals[11] ^
                     (locals[7] & 0x99c06bf8 ^ 0xabbf98df) & locals[234];
        locals[186] = locals[12] ^ 0x8e33d60;
        locals[11] = (~(locals[186] & 0xfffef527) & locals[10] ^ locals[186] & 0xffff6f37 ^ 0xfffe65af) & locals[141] &
            0x79ff8 ^ (locals[186] & 0x4fa50 ^ 0x2f420) & locals[10] ^ locals[186] & 0x7f460 ^ 0x25e60;
        locals[234] = locals[10] & 0xfbe80000 ^ locals[186] & 0xfb300000;
        locals[5] = ((locals[24] ^ 0x71479cd1) & locals[186] & 0x28e40 ^ 0x605a8) & locals[10] ^
                    (locals[141] & 0x2a00 ^ 0xda00) & locals[186];
        locals[6] = ((locals[186] & 0x30d80000 ^ 0x30800007) & locals[141] ^ locals[186] & 0xfb200003 ^ 0x3a600000) &
            locals[10] ^ (locals[141] & 0x100004 ^ 0xc1000007) & locals[186] ^ 0xfffffffd;
        locals[23] = ((locals[186] & 0x30d80000 ^ 0xff300007) & locals[10] ^ (locals[12] ^ 0xf7d4c29b) & 0xfbf80004) &
            locals[141] ^ (locals[186] & 0x8ef80003 ^ 0xf0b80000) & locals[10] ^ locals[186] & 0xf4e80007 ^ 0xf57fffd
            ;
        locals[24] = locals[23] >> 0x13;
        locals[61] = ~(locals[234] >> 0x13) & locals[24] ^ (locals[6] ^ locals[234]) >> 0x13;
        locals[23] = locals[23] << 0x1d;
        locals[22] = ((locals[12] ^ 0x8e33c40) & locals[141] & 0x41b60 ^ locals[186] & 0xbc8 ^ 0x40188) & locals[10] ^
                     (locals[141] & 0x4a00 ^ 0x2b460) & locals[186];
        locals[7] = locals[6] << 0x1d;
        locals[12] = ~(~(locals[6] >> 0x13) & locals[234] >> 0x13) & locals[24] ^ (locals[6] & locals[234]) >> 0x13;
        locals[234] = ~locals[24] ^ locals[6] >> 0x13;
        locals[1] = (~locals[23] & locals[6] << 0x1d ^ 0xffffffff) & 0xe0000000;
        locals[104] = locals[11] << 0xd;
        locals[24] = locals[22] << 0xd;
        locals[21] = ~locals[104] & locals[24] ^ locals[5] << 0xd;
        locals[23] = ~(~(locals[6] << 0x1d) & locals[23]);
        locals[4] = ~((locals[5] & locals[11]) << 0xd) ^ locals[24];
        locals[22] = (locals[22] ^ locals[5]) << 0xd ^ ~locals[24] & locals[104];
        locals[24] = (~locals[60] ^ locals[13]) & locals[103];
        locals[6] = ~((~locals[24] ^ locals[23] & locals[7] ^ locals[60]) & locals[1]) ^
                    (locals[7] ^ locals[24] ^ locals[60]) & locals[23] ^
                    locals[7];
        locals[24] = (locals[234] ^ locals[12]) & locals[61];
        locals[104] = ~((locals[12] ^ locals[233] ^ locals[2] ^ locals[24]) & locals[9]) ^
                      (~locals[24] ^ locals[12] ^ locals[2]) & locals[233] ^
                      locals[234] ^ locals[12];
        locals[24] = (locals[61] ^ locals[2]) & (locals[233] ^ locals[9]);
        locals[5] = (locals[12] ^ locals[233] ^ locals[24]) & locals[234] ^ (locals[9] ^ locals[24]) & locals[12] ^
                    ~locals[233] & locals[9] ^
                    locals[233];
        locals[24] = (locals[4] & ~locals[22] & 0x80000000 ^ locals[22] ^ 0x7fffffff) & locals[21] ^
                     (locals[4] ^ 0x80000000) & locals[22] ^ 0x7fffffff;
        locals[11] = ((locals[21] ^ 0x7fffffff) & locals[4] ^ 0x7fffffff) & locals[22] ^ locals[4] ^ locals[21] ^
                     0x7fffffff;
        locals[2] = locals[2] & (locals[233] ^ locals[9]);
        locals[22] = (locals[21] & ~locals[22] & 0x7fffffff ^ locals[22]) & locals[4] ^
                     (locals[22] ^ 0x80000000) & locals[21] ^
                     0x7fffffff;
        locals[21] = (locals[24] >> 3 & ~(locals[11] >> 3) ^ ~((locals[11] & locals[22]) >> 3)) & 0x1fffffff;
        locals[9] = ~((locals[12] ^ locals[61] ^ locals[9] ^ locals[2]) & locals[234]) ^
                    (~locals[2] ^ locals[61] ^ locals[9]) & locals[12] ^
                    locals[233] ^ locals[9];
        locals[12] = ~(((locals[60] ^ locals[13]) & (locals[23] ^ locals[7]) ^ locals[23] ^ locals[7]) & locals[103]) ^
                     (locals[23] ^ locals[7]) & locals[60] ^ locals[23] ^ locals[1];
        locals[60] =
            (~((~locals[1] ^ locals[7]) & locals[60]) ^ (~locals[1] ^ locals[7]) & locals[13] ^ locals[1] ^ locals[7]) &
            locals[103] ^
            (locals[23] & locals[7] ^ locals[60]) & locals[1] ^ locals[7] & ~locals[60] ^ locals[23] ^ locals[60];
        locals[7] = ~locals[14];
        locals[61] = (locals[60] ^ locals[12]) & (locals[7] ^ locals[3]) & locals[8] ^ locals[12] ^ locals[3];
        locals[233] = ((locals[5] & 0xabff7729 ^ 0xd36e95b5) & locals[104] ^ locals[5] & 0xf37ee1bc ^ 0xeab3769f) &
                      locals[9]
                      ^ (locals[5] & 0xf37ee1be ^ 0x3d8d8e4b) & locals[104] ^ locals[5] & 0xf37ee1be;
        locals[67] = locals[233] ^ 0x8139ac5e;
        locals[103] = (locals[11] ^ locals[24]) >> 3 ^ ~(locals[11] >> 3) & locals[22] >> 3;
        locals[187] = ((locals[5] & 0x7f27fffd ^ 0xbfdd5ce9) & locals[104] ^ locals[5] & 0xf4fa5f09 ^ 0x5bef63f6) &
                      locals[9]
                      ^ (locals[5] & 0xf4fa5f0b ^ 0xcb1581b0) & locals[104] ^ locals[5] & 0xf4fa5f0b ^ 0x4bf551e8;
        locals[68] = ((locals[5] & 0xd6ff8dfc ^ 0x6f99def2) & locals[104] ^ locals[5] & 0xfb5156e4 ^ 0xbdfe8d3d) &
                     locals[9] ^
                     (locals[5] & 0xfb5156e4 ^ 0xef7296) & locals[104] ^ locals[5] & 0xfb5156e6 ^ 0x4af6d8c4;
        locals[24] = (locals[11] & locals[24] ^ locals[22]) >> 3;
        locals[5] = ((locals[67] & 0xf5580000 ^ 0x39a00000) & locals[68] ^ locals[67] & 0x40680000 ^ 0x980000) &
                    locals[187] ^
                    (locals[67] & 0xf7400000 ^ 0x84b00000) & locals[68] ^ locals[67] & 0x80000;
        locals[234] = ((locals[67] & 0xf5580000 ^ 0xcfd80000) & locals[68] ^ locals[67] & 0xfdc80000 ^ 0xcff00000) &
            locals[187] ^ (locals[67] & 0x48c00000 ^ 0x40780000) & locals[68] ^ locals[67] & 0x8800000 ^ 0x40780000;
        locals[11] = (locals[68] ^ locals[67]) & 0x4fe70;
        locals[23] =
            ((((locals[233] ^ 0x81b9ac5e) & locals[68] ^ ~(locals[67] & 0xf7c7ffff) & 0xff7fffff) & locals[187] ^
              locals[67] & 0xf777ffff) & 0x48f80000 ^ ~(locals[67] & 0x40480000) & locals[68]) & 0xfff80000;
        locals[22] = ~locals[12];
        locals[15] = ((locals[6] ^ locals[22]) & locals[60] ^ (locals[12] ^ locals[14]) & locals[8] ^
                      locals[6] & locals[22] ^ locals[12]) & locals[3]
                     ^ (locals[60] & locals[6] ^ locals[7] & locals[8]) & locals[12] ^ locals[60];
        locals[104] = ((locals[67] & 0x40220 ^ 0xa415) & locals[68] ^ (locals[233] ^ 0x8139ac5d) & 0x4a637) &
                      locals[187] ^
                      (locals[67] & 0x7e62 ^ 0xa621) & locals[68] ^ locals[67] & 0xd844 ^ 0xfffffff9;
        locals[9] = (locals[234] & locals[23]) >> 0x13 & ~(locals[5] >> 0x13);
        locals[233] = ~locals[9];
        locals[3] = ~((~((locals[14] ^ locals[22]) & locals[3]) ^ locals[7] & locals[12] ^ locals[14]) & locals[8]) ^
                    (~((locals[3] ^ locals[22]) & locals[6]) ^ locals[12] & locals[3]) & locals[60] ^
                    (~(locals[3] & locals[22]) ^ locals[12]) & locals[6] ^ locals[3];
        locals[234] = ~(locals[234] >> 0x13 & ~(locals[5] >> 0x13)) ^ (locals[23] & locals[5]) >> 0x13;
        locals[12] = locals[61] & 0x1e00;
        locals[23] = (locals[23] ^ locals[5]) >> 0x13;
        locals[188] = ((locals[61] & 0xff81e00 ^ 0x7ffff) & locals[15] ^ ~locals[12] & 0xfffffff) & locals[3] ^
                      (locals[15] & 0xfffe1ff ^ 0x1e00) & locals[61] ^ 0xfffffff;
        locals[8] = locals[61] >> 0x13;
        locals[22] = ~(locals[15] >> 0x13);
        locals[1] = locals[3] >> 0x13 & locals[22] ^ (locals[61] & locals[15]) >> 0x13 ^ 0xffffe000;
        locals[7] = ~((locals[61] & locals[3]) >> 0x13) & locals[15] >> 0x13 ^ locals[8] ^ 0xffffe000;
        locals[4] = ((locals[67] & 0x40220 ^ 0x359cd) & locals[68] ^ locals[67] & 0x5847 ^ 0x258cb) & locals[187] ^
                    (locals[67] & 0x7b59a ^ 0x5f151) & locals[68] ^ locals[67] & 0x5f154 ^ 0xfffa0fa1;
        locals[8] = ~(locals[8] & locals[22]) & locals[3] >> 0x13 ^ locals[8];
        locals[60] = locals[104] << 0x1d;
        locals[6] = ~(locals[4] << 0x1d) & locals[60] ^ locals[4] << 0x1d;
        locals[5] = ~locals[60];
        locals[13] = (locals[104] ^ locals[4]) << 0x1d ^ 0x1fffffff;
        locals[2] = ~locals[6];
        locals[22] =
            ((locals[60] ^ locals[103]) & locals[24] ^ locals[2] & locals[13] ^ (locals[6] ^ locals[103]) & locals[5]) &
            locals[21] ^
            (~(~locals[13] & locals[6]) ^ ~locals[24] & locals[103] ^ locals[13]) & locals[5] ^ locals[6];
        locals[60] = (locals[60] ^ locals[13] ^ locals[103]) & locals[6];
        locals[60] = ~(((locals[6] ^ locals[103]) & locals[24] ^ locals[60] ^ locals[5] ^ locals[13] ^ locals[103]) &
                       locals[21]) ^
                     ~(locals[2] & locals[24]) & locals[103] ^ locals[60] ^ locals[13];
        locals[36] = ((locals[61] & 0xff81e00 ^ 0x7e1ff) & locals[15] ^ locals[12]) & locals[3] ^
                     ((locals[15] ^ 0x7e1ff) & locals[61] ^ 0xffffe1ff) & 0xfffffff;
        locals[24] = (locals[5] ^ locals[6]) & locals[24];
        locals[6] = ((locals[5] ^ locals[6]) & locals[103] ^ ~locals[24]) & locals[21] ^
                    (locals[24] ^ locals[5] ^ locals[6]) & locals[103] ^
                    locals[2] & locals[5] & locals[13] ^ locals[6];
        locals[104] = locals[104] << 0xd;
        locals[14] = ~(locals[4] << 0xd) & locals[104];
        locals[103] = ~locals[60] & locals[22];
        locals[178] = ~locals[60] ^ locals[22];
        locals[24] = locals[178] & locals[6];
        locals[13] = ~((locals[103] ^ locals[24] ^ locals[7] ^ locals[1]) & locals[8]) ^
                     (~locals[24] ^ locals[103] ^ locals[7]) & locals[1] ^
                     locals[6] ^ locals[60];
        locals[238] = (~(~locals[61] & locals[15]) & 0xff80000 ^ locals[61] & 0x7e1ff) & locals[3] ^ locals[12] ^
                      0x7e1ff;
        locals[61] = ~(locals[188] << 0xd) & locals[36] << 0xd;
        locals[5] = ~locals[61];
        locals[103] = (locals[36] ^ locals[188]) << 0xd;
        locals[21] = locals[238] << 0xd & ~locals[103];
        locals[24] = (locals[8] ^ locals[1]) & locals[7];
        locals[12] = ~((locals[4] ^ locals[11]) << 0xd) & locals[104] ^ locals[4] << 0xd;
        locals[2] = locals[11] << 0xd & ~locals[14] ^ locals[104];
        locals[3] = (locals[24] ^ locals[60] ^ locals[1]) & locals[6] ^ (~locals[24] ^ locals[1]) & locals[60] ^
                    locals[8] ^ locals[1];
        locals[15] = locals[21] ^ locals[234] ^ locals[233];
        locals[60] = ((locals[60] ^ locals[22] ^ locals[7]) & locals[6] ^ (~locals[22] ^ locals[7]) & locals[60] ^
                      locals[22] ^ locals[1]) & locals[8]
                     ^ ((locals[178] ^ locals[7]) & locals[6] ^ (locals[22] ^ locals[7]) & locals[60] ^ locals[22]) &
                     locals[1] ^
                     (~locals[6] ^ locals[60]) & locals[22] ^ locals[6] ^ locals[60];
        locals[24] = ((locals[4] & locals[11]) << 0xd & ~locals[104] ^ locals[14]) >> 3;
        locals[11] = locals[12] >> 3;
        locals[22] = ~(((locals[21] ^ locals[5]) & locals[103] ^ locals[15] & locals[5] ^ locals[233]) & locals[23]) ^
                     locals[61] & locals[103] & locals[21] ^ locals[5] & locals[233] ^ locals[234];
        locals[104] = locals[234] ^ locals[233];
        locals[7] = locals[2] >> 3;
        locals[6] = ~(~locals[24] & locals[11]) ^ locals[7];
        locals[61] = ((~locals[234] ^ locals[233]) & locals[21] ^ locals[234] ^ locals[233]) & locals[5] ^
                     ~((locals[104] & (locals[21] ^ locals[5]) ^ locals[21] ^ locals[5]) & locals[103]) ^
                     locals[9] & locals[234] ^
                     locals[104] & locals[23] ^ locals[233];
        locals[8] = (~locals[13] & locals[3] & 0xf0001e00 ^ 0xfffe1ff) & locals[60] ^ 0xf0001e00;
        locals[9] = ((locals[3] ^ 0xf0001e00) & locals[60] ^ locals[3]) & locals[13] ^ 0xf0001e00;
        locals[60] = (locals[3] ^ 0xfffe1ff) & locals[60];
        locals[11] = ~locals[11];
        locals[1] = locals[11] & locals[7] ^ locals[24];
        locals[189] = (locals[60] ^ 0xf0001e00) & locals[13] ^ locals[60] ^ 0xfffe1ff;
        locals[12] = locals[11] & locals[24] ^ (locals[2] & locals[12]) >> 3;
        locals[23] = ~(((locals[21] ^ locals[23] ^ locals[234] ^ locals[233]) & locals[5] ^
                        (~locals[23] ^ locals[234] ^ locals[233]) & locals[21]
                         ) & locals[103]) ^ (~(locals[15] & locals[23]) ^ locals[104] & locals[21] ^ locals[233]) &
                     locals[5] ^
                     (locals[23] ^ locals[233]) & locals[234] ^ locals[23];
        locals[11] = (~locals[23] & locals[22] ^ locals[23]) & 3 ^ locals[61];
        locals[24] = ((locals[23] & 0xfffffffc ^ 3) & locals[22] ^ 3) & locals[61] ^ locals[23] & locals[22] ^
                     0xfffffffc;
        locals[180] = ~locals[24] & locals[11];
        locals[11] = ~locals[11];
        locals[233] = ~((locals[11] ^ locals[24]) &
                        ((~(~locals[22] & locals[23]) & 0xfffffffc ^ locals[22]) & locals[61] ^ locals[23] & 3));
        locals[240] = locals[11] & locals[24] ^ locals[233];
        locals[232] = locals[180] & 0x3c00000;
        locals[4] = locals[233] & 0x3c00000;
        locals[13] = ~locals[232];
        locals[24] = (~locals[189] ^ locals[9]) & locals[8];
        locals[234] = ~locals[8];
        locals[178] = ((locals[4] ^ locals[8]) & locals[9] ^ locals[4] ^ locals[8]) & locals[232] ^
                      ~((~((locals[232] ^ locals[9]) & locals[4]) ^ locals[232] ^ locals[9]) & locals[240]) ^
                      ((locals[232] ^ locals[9]) & locals[8] ^ locals[232] ^ locals[9]) & locals[189] ^ locals[9];
        locals[60] = (~((~locals[189] ^ locals[9]) & locals[232]) ^ locals[189] ^ locals[9]) & locals[8] ^
                     (~locals[24] ^ locals[189] ^ locals[9]) & locals[240] ^ (locals[189] ^ locals[9]) & locals[232] ^
                     locals[189];
        locals[237] = (locals[234] & locals[189] ^ locals[4] & locals[232]) & locals[9] ^
                      ((locals[13] ^ locals[9]) & locals[4] ^ locals[24] ^ locals[189] ^ locals[9]) & locals[240] ^
                      locals[232];
        locals[243] = ~(locals[178] * 2) & locals[60] * 2 ^ (locals[237] ^ locals[178]) * 2;
        locals[242] = (~(locals[60] * 2) & locals[178] * 2 ^ ~(locals[237] * 2)) & 0xfffffffe;
        locals[22] = ~(locals[178] << 3) & locals[60] << 3;
        locals[23] = (locals[237] ^ locals[178]) << 3 ^ locals[22];
        locals[7] = (locals[60] & locals[237] ^ locals[178]) << 1;
        locals[11] = ~((locals[60] & locals[237]) << 2) ^ locals[178] << 2;
        locals[104] = locals[237] << 2 & ~(locals[60] << 2) ^ locals[178] << 2 ^ 3;
        locals[2] = ~locals[11];
        locals[24] = (((locals[60] ^ locals[178]) & locals[237]) << 2 ^ ~(locals[60] << 2)) & 0xfffffffc;
        locals[103] = (locals[237] & locals[178] ^ locals[60]) << 3;
        locals[61] = ((locals[2] ^ locals[242]) & locals[24] ^ locals[2] & locals[242] ^ locals[11]) & locals[104] ^
                     ~((locals[7] ^ locals[243]) & locals[11]) & locals[242] ^ locals[11] ^ locals[243];
        locals[5] = ~((~locals[104] ^ locals[243]) & locals[7]) & locals[242] ^
                    ~((~locals[24] ^ locals[11] ^ locals[242]) & locals[104] & locals[243]) ^ locals[11];
        locals[22] = (~(locals[237] << 3) ^ locals[22]) & 0xfffffff8;
        locals[21] = (~(~locals[22] & locals[103]) ^ locals[22]) & locals[23] ^ locals[22] ^ locals[103];
        locals[244] = (~((locals[11] ^ locals[242] ^ locals[243]) & locals[24]) ^
                       (locals[7] ^ locals[11] ^ locals[243]) & locals[242] ^
                       locals[2] & locals[243] ^ locals[11]) & locals[104] ^
                      (locals[7] & locals[11] ^ (locals[7] ^ locals[11]) & locals[243]) & locals[242] ^
                      locals[2] & locals[243];
        locals[24] = ~locals[5] ^ locals[61];
        locals[104] = ~locals[61];
        locals[11] = ~(locals[24] & locals[7]);
        locals[3] = ~((((locals[244] ^ locals[61]) & locals[7] ^ locals[61]) & locals[5] ^
                       (locals[104] & locals[244] ^ locals[61]) & locals[7] ^
                       locals[61]) & locals[243]) ^ (locals[24] & locals[243] ^ locals[11] ^ locals[5] ^ locals[61]) &
                    locals[244] & locals[242] ^
                    locals[61] ^ locals[7];
        locals[2] = ~locals[7];
        locals[183] =
            ((locals[11] ^ locals[5] ^ locals[61]) & locals[244] ^ ~(~locals[5] & locals[61]) & locals[7] ^
             locals[61]) & locals[243] ^
            (~((locals[2] ^ locals[243]) & locals[5]) ^ locals[7] ^ locals[243]) & locals[61] & locals[242] ^
            (locals[61] ^ locals[7]) & locals[5];
        locals[11] = locals[104] & locals[7];
        locals[14] = (locals[104] ^ locals[7]) & locals[5];
        locals[104] = locals[103] & locals[23] ^ locals[22];
        locals[24] = ~locals[183] ^ locals[178];
        locals[14] = ((~((~locals[14] ^ locals[11] ^ locals[61]) & locals[243]) ^
                       (~locals[11] ^ locals[61]) & locals[5] ^ locals[11] ^ locals[61]
                      ) & locals[244] ^
                      (~((~(locals[2] & locals[5]) ^ locals[7]) & locals[243]) ^ locals[2] & locals[5] ^ locals[7]) &
                      locals[61]
            ) & locals[242] ^ (~(~(locals[244] & locals[5]) & locals[61]) ^ locals[7]) & locals[243] ^ locals[14];
        locals[15] = (locals[24] & locals[237] ^ ~locals[183] & locals[178] ^ locals[183]) & locals[60] ^
                     ~(locals[24] & locals[3]) & locals[14] ^
                     (locals[3] ^ locals[237]) & locals[183] & locals[178];
        locals[24] = locals[14] ^ locals[183];
        locals[190] = (~(locals[24] & locals[237]) ^ locals[24] & locals[3]) & locals[178] ^
                      ~((~locals[3] ^ locals[237] ^ locals[178]) & locals[24] & locals[60]) ^ locals[183];
        locals[11] = ~locals[14] ^ locals[60];
        locals[24] = ~locals[22] ^ locals[23];
        locals[14] = ~((locals[11] & locals[237] ^ ~locals[14] & locals[60] ^ locals[14]) & locals[178]) ^
                     (locals[11] & locals[3] ^ locals[14] ^ locals[60]) & locals[183] ^
                     ~((~locals[3] ^ locals[237]) & locals[14]) & locals[60] ^
                     locals[14];
        locals[245] = ~locals[103];
        locals[11] = (locals[245] ^ locals[23]) & locals[14];
        locals[60] = (locals[245] ^ locals[23]) & locals[22];
        locals[183] =
            (~((~locals[11] ^ locals[103] ^ locals[23]) & locals[190]) ^ locals[245] & locals[23] ^ locals[103]) &
            locals[22] ^
            ((~locals[60] ^ locals[14]) & locals[190] ^ locals[11] & locals[22]) & locals[15] ^
            (locals[190] ^ locals[23]) & locals[14]
            ^ locals[190];
        locals[237] = ~locals[14] ^ locals[15];
        locals[11] = ~(((~(locals[237] & locals[103]) ^ locals[14] ^ locals[15]) & locals[22] ^
                        (~(locals[237] & locals[22]) ^ locals[14] ^ locals[15]) & locals[23]) & locals[190]) ^
                     ~((locals[60] ^ locals[23]) & locals[15]) & locals[14] ^ locals[22] & locals[103] & locals[23];
        locals[60] = ~(locals[237] & locals[244]) ^ locals[14] ^ locals[15];
        locals[3] = ~(~locals[15] & locals[244]) ^ locals[15];
        locals[178] = ~((locals[3] & locals[14] ^ locals[60] & locals[190] ^ locals[244]) & locals[5]) ^ locals[244];
        locals[3] = ~((~(locals[60] & locals[5]) ^ locals[14] ^ locals[15]) & locals[190]) ^
                    (~(locals[3] & locals[5]) ^ locals[15]) & locals[14]
                    ^ (~locals[244] ^ locals[5]) & locals[61] ^ locals[244] ^ locals[5];
        locals[245] = (~((locals[14] ^ locals[103]) & locals[22]) ^ locals[14]) & locals[23] ^
                      (~(locals[245] & locals[22]) ^ locals[190]) & locals[14] ^
                      (locals[14] ^ locals[190]) & locals[15] ^ locals[190];
        locals[246] = locals[245] ^ locals[183];
        locals[5] = ((locals[237] & locals[5] ^ ~(locals[237] & locals[244]) ^ locals[14] ^ locals[15]) & locals[190] ^
                     (~((~locals[244] ^ locals[5]) & locals[15]) ^ locals[244] ^ locals[5]) & locals[14]) & locals[61] ^
                    locals[244] ^ locals[5];
        locals[23] = (locals[3] ^ locals[178]) & locals[5];
        locals[15] = (~((locals[5] ^ locals[7]) & locals[242]) ^ locals[23] ^ locals[178]) & locals[243] ^
                     (locals[2] & locals[242] ^ locals[3]) & locals[5] ^ locals[7];
        locals[103] = locals[245] & locals[11] & locals[183] & 0x82001000;
        locals[190] = ~((~locals[23] ^ locals[178]) & locals[7]) ^ (locals[23] ^ locals[178]) & locals[243] ^ locals[5];
        locals[61] = ~locals[11] & ~locals[245] & locals[183] & 0x82001000;
        locals[242] = ((~locals[3] ^ locals[178] ^ locals[242]) & locals[5] ^ locals[178] ^ locals[242]) & locals[243] ^
                      ((~locals[5] ^ locals[243]) & locals[242] ^ locals[5] ^ locals[243]) & locals[7] ^
                      (~locals[178] ^ locals[242]) & locals[5]
                      ^ locals[178] ^ locals[242];
        locals[244] = (locals[242] ^ locals[190]) & locals[15];
        locals[237] = (~locals[244] ^ locals[242]) & locals[104];
        locals[243] = locals[61] >> 3;
        locals[23] =
            (~((~locals[237] ^ locals[244] ^ locals[242]) & locals[21]) ^ locals[237] ^ locals[244] ^ locals[242]) &
            locals[24] ^
            locals[104] ^ locals[21];
        locals[7] = locals[103] >> 3;
        locals[2] = ~locals[7];
        locals[60] = (locals[246] & 0x82001000) >> 3;
        locals[7] = ~locals[243] & locals[7] ^ locals[60] & locals[2];
        locals[14] = (locals[242] ^ locals[190]) & locals[104];
        locals[22] = ~locals[104] & locals[24];
        locals[14] =
            ~((((locals[14] ^ locals[242] ^ locals[190]) & locals[24] ^ locals[14] ^ locals[242] ^ locals[190]) &
               locals[15] ^
               (~locals[22] ^ locals[104]) & locals[242] ^ locals[104]) & locals[21]) ^ locals[22] ^ locals[244] ^
            locals[242] ^
            locals[104];
        locals[60] = locals[2] & locals[243] ^ locals[60];
        locals[61] = (locals[103] & locals[246] & 0x82001000 ^ locals[61]) >> 3;
        locals[237] = (locals[22] ^ locals[244] ^ locals[242] ^ locals[104]) & locals[21] ^ locals[237];
        locals[21] = ~locals[237];
        locals[104] = ~(((locals[5] ^ locals[3]) & locals[23] ^ ~locals[3] & locals[5]) & locals[178]) ^
                      ((locals[237] ^ locals[14] ^ locals[5]) & locals[3] ^ locals[237] ^ locals[14]) & locals[23] ^
                      (locals[21] ^ locals[14]) & locals[3] ^ locals[237];
        locals[24] = (~((locals[14] ^ locals[23]) & locals[5]) ^ locals[14] ^ locals[23]) & locals[3] ^
                     ~(~locals[23] & locals[237]) & locals[14]
                     ^ (locals[14] ^ locals[23]) & (locals[5] ^ locals[3]) & locals[178];
        locals[22] = ~locals[14];
        locals[242] = ((locals[22] ^ locals[5]) & locals[178] ^ locals[22] & locals[5] ^
                       (locals[237] ^ locals[14]) & locals[23] ^ locals[237] ^
                       locals[14]) & locals[3] ^
                      (locals[21] & locals[23] ^ locals[5] & locals[178] ^ locals[237]) & locals[14] ^ locals[23];
        locals[190] = ~locals[242];
        locals[103] = (locals[22] ^ locals[23]) & locals[237];
        locals[2] = ((locals[190] ^ locals[103]) & locals[24] & 0x82001000 ^
                     ~(locals[190] & (locals[22] ^ locals[23]) & locals[237] & 0x82001000)) & locals[104] ^
                    (~locals[103] & locals[190] & locals[24] ^ locals[14]) & 0x82001000;
        locals[15] = locals[190] & locals[24];
        locals[5] = locals[21] & locals[14] ^ locals[237];
        locals[21] = ~(((locals[24] & 0x7dffefff ^ 0x82001000) & locals[242] ^ locals[21] & locals[14] ^ locals[24] ^
                        locals[237] ^
                        0x82001000) & locals[104]) ^
                     ~((~(locals[14] & 0x82001000) ^ locals[104]) & locals[23]) & locals[237] ^
                     (locals[237] ^ 0x7dffefff) & locals[14] ^ locals[15];
        locals[103] = (locals[242] ^ 0x7dffefff) & locals[21];
        locals[22] = ~locals[21];
        locals[237] = (((~locals[24] ^ locals[5]) & 0x7dffefff ^ locals[5]) & locals[242] ^
                       (locals[24] & 0x82001000 ^ 0x7dffefff) & locals[5] ^ 0x82001000) & locals[104] ^
                      (((locals[242] ^ locals[24]) & 0x82001000 ^ 0x7dffefff) & locals[104] ^
                       (locals[15] ^ locals[14]) & 0x82001000) & locals[237] & locals[23] ^
                      locals[5] & locals[190] & locals[24] & 0x82001000;
        locals[3] = ~locals[237] & locals[22];
        locals[23] = (((locals[21] & 0x82001000 ^ 0x7dffefff) & locals[237] ^ locals[21] & 0x7dffefff ^ 0x82001000) &
            locals[2] ^ locals[3] & 0x7dffefff) & locals[190];
        locals[5] =
            ~(((((locals[21] & 0x82001000 ^ locals[242] ^ 0x7dffefff) & locals[237] ^ locals[103] ^ 0x82001000) &
                locals[2] ^ (locals[103] ^ locals[242] ^ 0x7dffefff) & locals[237] ^ locals[103] ^ locals[242] ^
                0x7dffefff) &
                locals[24] ^ locals[23]) & locals[104]) ^
            ((locals[21] ^ locals[242]) & locals[2] ^ locals[22] & locals[242]) & locals[237] & 0x82001000 ^
            (locals[21] & ~locals[2] & 0x82001000 ^ 0x7dffefff) & locals[242] ^ locals[24] & locals[23];
        locals[103] = locals[237] >> 2;
        locals[14] = ~(~(locals[2] >> 2 & ~locals[103]) & locals[21] >> 2) ^ locals[103];
        locals[23] = ~((locals[21] & locals[2]) >> 2 & ~locals[103]) ^ ~(locals[21] >> 2) & locals[103];
        locals[178] = (locals[237] ^ locals[2]) >> 2;
        locals[103] = ((~(((locals[190] ^ locals[24]) & locals[104] ^ ~locals[15]) & locals[21]) & 0x82001000 ^
                        (locals[24] & locals[104] ^ 0x82001000) & locals[242]) & locals[237] ^
                       ((locals[21] & locals[242] ^ 0x82001000) & locals[24] ^ locals[190] & 0x82001000) & locals[104] ^
                       ~((locals[21] ^ locals[24]) & locals[190]) & 0x82001000) & locals[2] ^
                      ((~(locals[22] & locals[237]) ^ locals[21]) & locals[24] & locals[104] ^ locals[3] & 0x82001000) &
                      locals[242] ^
                      locals[3] & 0x82001000;
        locals[21] = (locals[242] ^ 0x82001000) & locals[21];
        locals[3] = locals[3] & locals[190] & ~locals[2];
        locals[242] = ((((locals[22] & 0x82001000 ^ locals[242]) & locals[237] ^ locals[21] ^ 0x82001000) & locals[2] ^
                        (locals[242] ^ locals[21] ^ 0x82001000) & locals[237] ^ locals[242] ^ locals[21] ^ 0x82001000) &
                       locals[24] ^
                       locals[3] & 0x82001000) & locals[104] ^ (locals[24] & locals[3] ^ locals[2]) & 0x82001000 ^
                      locals[242];
        locals[24] = ~locals[103];
        locals[21] = locals[5] ^ locals[24];
        locals[22] = (locals[183] ^ locals[21]) & locals[245];
        locals[22] = (~locals[245] & locals[183] ^ locals[246] & locals[242]) & locals[11] ^
                     (locals[103] ^ locals[5] ^ locals[183] ^ locals[22]) & locals[242] ^ locals[5] ^ locals[183] ^
                     locals[22];
        locals[2] = ~locals[7];
        locals[3] = ~((locals[178] ^ locals[7]) & locals[14]);
        locals[104] = (~((~locals[14] ^ locals[7]) & locals[61]) ^ locals[7] ^ locals[14] & locals[2]) & locals[60] ^
                      (locals[178] & locals[2] ^ locals[3]) & locals[23] ^
                      (locals[7] ^ locals[14] & locals[2]) & locals[61] ^ locals[14] ^ locals[7];
        locals[178] = ~locals[178];
        locals[2] = (~((locals[7] ^ ~locals[23]) & locals[61]) ^ locals[23] & locals[2] ^ locals[7]) & locals[60] ^
                    (locals[14] ^ locals[7] ^ locals[178]) & locals[23] & locals[61] ^ locals[14] ^ locals[7];
        locals[60] = (~((locals[60] ^ locals[7] ^ locals[178]) & locals[23]) ^
                      (locals[23] ^ locals[60] ^ locals[7]) & locals[14] ^ locals[60] ^
                      locals[7]) & locals[61] ^ (~((locals[14] ^ ~locals[23]) & locals[7]) ^ locals[23] ^ locals[14]) &
                     locals[60] ^
                     (locals[7] & locals[178] ^ locals[3]) & locals[23];
        locals[7] = ((locals[183] ^ locals[24]) & locals[245] ^ locals[103] & locals[183]) & locals[11] ^
                    ((locals[103] ^ locals[245]) & locals[242] ^ locals[103] ^ locals[245]) & locals[5] ^
                    ((locals[242] ^ locals[183]) & locals[245] ^ locals[242] ^ locals[183]) & locals[103] ^
                    locals[242] ^ locals[245];
        locals[23] = locals[7] ^ locals[22];
        locals[7] = locals[7] & locals[22] & 0x82001000;
        locals[11] = ~((locals[245] & (locals[242] ^ locals[103]) ^ locals[242] ^ locals[103]) & locals[183] ^
                       ~(~locals[242] & locals[5]) & locals[103] ^
                       ~(locals[246] & locals[11] & (locals[242] ^ locals[103])) ^ locals[245]) &
                     locals[23] & 0x82001000;
        locals[61] = (locals[7] ^ locals[11]) >> 1;
        locals[11] = ~(locals[7] >> 1) & locals[11] >> 1;
        locals[7] = ~locals[11];
        locals[3] = (locals[103] ^ locals[5]) & locals[242];
        locals[23] = locals[23] >> 1 & ~locals[61] & 0x41000800;
        locals[22] = ~locals[23];
        locals[23] = locals[23] & locals[7];
        locals[24] =
            ((locals[7] ^ locals[103]) & locals[5] ^ (locals[5] ^ locals[11]) & locals[22] ^ locals[103] ^ locals[3]) &
            locals[61] ^
            (locals[242] & locals[24] ^ ~locals[23]) & locals[5] ^ locals[103];
        locals[11] =
            (~((locals[103] ^ locals[11]) & locals[22]) ^ (locals[7] ^ locals[5]) & locals[103] ^ locals[5] ^
             locals[3]) & locals[61] ^
            (~locals[5] & locals[242] ^ locals[23]) & locals[103] ^ locals[5];
        locals[103] = (~(locals[61] & locals[21]) ^ locals[103] ^ locals[5]) & locals[7] ^
                      (locals[61] ^ locals[7]) & locals[22] & locals[21] ^
                      locals[61] ^ locals[103];
        locals[7] = ~locals[11];
        locals[21] = ~(((locals[2] ^ locals[7]) & locals[60] ^ (locals[60] ^ locals[2]) & locals[104] ^
                        locals[24] & (locals[11] ^ locals[60]) ^
                        locals[2]) & locals[103]) ^
                     (~(locals[24] & locals[7]) ^ ~locals[2] & locals[104] ^ locals[11]) & locals[60] ^ locals[24] ^
                     locals[2];
        locals[22] = locals[103] ^ locals[11] ^ locals[60];
        locals[23] = ((locals[11] ^ locals[104] ^ ~locals[103]) & locals[60] ^
                      ~((locals[104] ^ locals[22]) & locals[2]) ^ locals[103] ^
                      locals[11]) & locals[24] ^
                     ((locals[104] ^ locals[11] ^ locals[60]) & locals[2] ^ (locals[104] ^ locals[7]) & locals[60] ^
                      locals[11]) & locals[103] ^
                     (~locals[60] ^ locals[2]) & locals[11] ^ locals[2];
        locals[60] = ((~locals[24] ^ locals[60]) & locals[104] ^ locals[11] & ~locals[103] ^ locals[24] & locals[22]) &
                     locals[2] ^
                     (~locals[104] & locals[60] ^ locals[103] & locals[7]) & locals[24] ^ locals[103] ^ locals[60];
        locals[11] = ~(locals[60] & locals[23]);
        locals[7] = locals[11] & 0x1e00;
        locals[104] = ((locals[60] ^ locals[21]) & 0xf0000000 ^ 0x1e00) & locals[23] ^
                      (locals[21] & 0xf0000000 ^ 0x1e00) & locals[60] ^ 0xfffffff;
        locals[3] = locals[23] & locals[21] ^ locals[60];
        locals[14] = locals[3] & 0x3c00000;
        locals[178] = (~locals[21] & locals[60] ^ locals[23]) & 0x3c00000 ^ 0xfc3fffff;
        locals[22] = ~locals[60] & locals[21] ^ locals[60] ^ locals[23];
        locals[61] = locals[22] & 0x3c00000;
        locals[37] = locals[14] << 6;
        locals[143] = ~(~(locals[178] << 6) & locals[61] << 6) & locals[37] ^ (locals[61] & locals[178]) << 6;
        locals[37] = ~(~locals[37] & locals[178] << 6) & locals[61] << 6 ^ locals[37];
        locals[15] = ~locals[4] ^ locals[232];
        locals[247] = locals[37] ^ 0x3f;
        locals[237] = locals[232] ^ locals[178];
        locals[5] = ((locals[61] ^ locals[3] & 0x1c00000) & locals[15] ^
                     (locals[180] & 0x2000000 ^ 0xea89fa2d) & locals[4] ^
                     locals[13] & 0xea89fa2d) & locals[240] ^
                    ((locals[178] & 0xe2030ce3 ^ 0xdfc5314) & locals[4] ^ (locals[178] & 0xe2030ce3 ^ 0x5003a0ab) &
                                                                        locals[61]
                                                                        ^ locals[180] & 0x1c00000 ^
                                                                        locals[178] & 0xea89fa2d ^ 0xeefe0efc) &
                    locals[14] ^
                    (~(locals[178] & 0xf203aceb) & locals[4] ^ locals[232] ^ locals[178] & 0xea89fa2d ^ 0x2302f1c2) &
                    locals[61] ^
                    (locals[237] & 0xe2030ce3 ^ 0x9575a95b) & locals[4] ^ locals[237] & 0xea89fa2d;
        locals[107] = locals[5] ^ 0xb20bf8b6;
        locals[103] = locals[61] >> 0xd;
        locals[69] = locals[178] >> 0xd;
        locals[191] = ~((locals[61] ^ locals[178]) >> 0xd) & 0x7ffff;
        locals[24] = (~locals[69] & locals[103] ^ locals[69]) & locals[14] >> 0xd ^ locals[103];
        locals[21] = (locals[60] ^ locals[23]) & locals[21];
        locals[192] = (locals[14] ^ locals[178]) << 6 ^ 0x3f;
        locals[2] = locals[21] & 0x1e00;
        locals[60] = locals[2] << 0x13;
        locals[183] = ~(locals[7] << 0x13) ^ locals[60];
        locals[23] = ~(~(~locals[60] & locals[7] << 0x13) & locals[104] << 0x13) ^ locals[60];
        locals[69] = ~(~(~locals[103] & locals[69]) & locals[14] >> 0xd) ^ locals[69];
        locals[103] = locals[178] & 0x5df4d32c;
        locals[70] = ((locals[22] & 0x3400000 ^ locals[3] & 0x2800000) & locals[15] ^
                      (locals[180] & 0x1c00000 ^ 0x1803cb56) & locals[4] ^ locals[13] & 0x1803cb56) & locals[240] ^
                     ((locals[103] ^ 0x2bc485e) & locals[61] ^ (locals[103] ^ 0xa0032481) & locals[4] ^
                      locals[180] & 0x2800000 ^
                      locals[178] & 0x1803cb56 ^ 0x7fc3f332) & locals[14] ^
                     (~locals[103] & locals[4] & 0xfdf7f7ad ^ locals[180] & 0x3400000 ^ locals[178] & 0x1803cb56 ^
                      0xcef40ee9)
                     & locals[61] ^ (locals[237] & 0x5df4d32c ^ 0xf67cadff) & locals[4] ^ locals[237] & 0x1803cb56 ^
                     0xf72cdb0b;
        locals[103] = locals[178] & 0x4286691;
        locals[144] = ((locals[14] ^ locals[61]) & locals[15] ^ locals[233] & 0x3400000 ^ locals[13] & 0xb7744780) &
                      locals[240] ^
                      ((locals[103] ^ 0x5200886a) & locals[4] ^ (locals[103] ^ 0xadd71714) & locals[61] ^ locals[232] ^
                       locals[178] & 0xb7744780 ^ 0x6f3d70ef) & locals[14] ^
                      (~locals[103] & locals[4] & 0x5628eefb ^ locals[232] ^ locals[178] & 0xb7744780 ^ 0x9869b914) &
                      locals[61] ^
                      (locals[237] & 0x4286691 ^ 0xe9dffffe) & locals[4] ^ locals[237] & 0xb7744780 ^ 0xc578c757;
        locals[103] = ((locals[107] & 0x306b8 ^ 0x148f0) & locals[70] ^ locals[107] & 0x24608 ^ 0x68e58) & locals[144] ^
                      (locals[107] & 0x40b0 ^ 0x12ef0) & locals[70] ^ locals[107] & 0x5b1b0 ^ 0x68008;
        locals[233] = ((locals[107] & 0xdca00004 ^ 0xb3580000) & locals[70] ^ locals[107] & 0xfdf00000 ^ 0x92580000) &
                      locals[144] ^ (~(locals[107] & 0x54a00000) & locals[70] ^ 0xdfafffff) & 0xfef80000 ^
                      locals[107] & 0x55a00004;
        locals[3] = ~((locals[104] & locals[7]) << 0x13) & locals[60] ^ locals[104] << 0x13;
        locals[22] = (locals[9] ^ locals[8]) & locals[2];
        locals[60] = ((locals[104] ^ locals[9]) & locals[2] ^ locals[104] ^ locals[9]) & locals[8] ^
                     ((locals[8] ^ locals[2]) & locals[104] ^ locals[8] ^ locals[2]) & locals[7] ^
                     (~locals[9] & locals[8] ^ locals[22]) & locals[189]
                     ^ locals[104] ^ locals[2];
        locals[61] = (~locals[104] ^ locals[9]) & locals[8];
        locals[234] = (~((locals[234] ^ locals[2]) & locals[104]) ^ locals[8] ^ locals[2]) & locals[7] ^
                      ~((locals[234] & locals[9] ^ locals[22]) & locals[189]) ^ ~locals[61] & locals[2] ^ locals[104];
        locals[22] = (locals[23] ^ locals[183]) & (locals[36] ^ locals[188]);
        locals[108] = (~locals[3] ^ locals[23] ^ locals[36]) & locals[183] ^
                      ~((locals[22] ^ locals[36] ^ locals[188]) & locals[238]) ^
                      (locals[3] ^ locals[36]) & locals[23] ^ locals[3];
        locals[4] = (~((locals[7] ^ locals[9] ^ locals[2]) & locals[104]) ^ locals[7] ^ locals[9] ^ locals[2]) &
                    locals[8] ^
                    (locals[104] & locals[9] ^ locals[61]) & locals[189] ^ locals[2];
        locals[8] = locals[11] & 0x600 ^ locals[104] & 0xe7ffffcf;
        locals[109] = (~(locals[21] & 0x1800) & locals[104] & 0x7f57dbfb ^ (locals[8] ^ 0x635960) & locals[4] ^
                       (locals[21] & 0x1800 ^ 0x4347c24b) & locals[7] ^ 0xefbcae0f) & locals[60] ^
                      ((locals[104] & 0x3c1019b0 ^ 0xe79ca6af) & locals[2] ^ locals[104] & 0x98a82434 ^ 0x76965bbc) &
                      locals[7] ^ ((locals[8] ^ 0x3c7340d0) & locals[60] ^ locals[11] & 0x600 ^
                                   locals[104] & 0xe7ffffcf ^
                                   0x3c7340d0) & locals[234] ^ (locals[2] ^ 0x1e188e7) & locals[104] ^ 0x574cdaf8;
        locals[8] = locals[11] & 0x1c00 ^ locals[104] & 0xfd5f2ffe;
        locals[8] = (~(locals[21] & 0x1200) & locals[104] & 0x9af9f77f ^
                     (locals[21] & 0x1200 ^ 0x98180524) & locals[7] ^
                     (locals[8] ^ 0xc1dd679c) & locals[4] ^ 0x7d86bafb) & locals[60] ^
                    ((locals[104] & 0x2e1f25b ^ 0x3c824862) & locals[2] ^ locals[104] & 0x67a6d881 ^ 0x136b62de) &
                    locals[7] ^
                    ((locals[8] ^ 0xc33c95c7) & locals[60] ^ locals[11] & 0x1c00 ^ locals[104] & 0xfd5f2ffe ^
                     0xc33c95c7) &
                    locals[234] ^ (locals[21] & 0x1a00 ^ 0xc8966738) & locals[104];
        locals[38] = locals[8] ^ 0x1a42f3e1;
        locals[61] = ((locals[107] & 0x6f1a0 ^ 0x34600) & locals[70] ^ locals[107] & 0x3e608 ^ 0x5b7a0) & locals[144] ^
                     (locals[107] & 0xe48 ^ 0x8608) & locals[70] ^ locals[107] & 0x131b0;
        locals[178] = locals[22] & locals[238] ^ locals[23] ^ locals[36];
        locals[9] = ((locals[107] & 0x5f718 ^ 0x6f708) & locals[70] ^ locals[107] & 0x3e618 ^ 0x2d1b8) & locals[144] ^
                    ~(locals[107] & 0x10000) & locals[70] & 0x3ae48 ^ locals[107] & 0x48000;
        locals[36] = ~(((locals[23] ^ locals[36]) & locals[183] ^ ~locals[23] & locals[36]) & locals[3]) ^
                     ((locals[23] ^ locals[36]) & locals[188] ^ ~locals[23] & locals[36]) & locals[238] ^ locals[183] ^
                     locals[36];
        locals[11] = (locals[61] & locals[103] ^ locals[9]) << 0xd;
        locals[23] = locals[104] & 0xfeeafaf3 ^ locals[7];
        locals[61] = locals[61] << 0xd;
        locals[39] = ((locals[21] & 0x400 ^ 0x24a03890) & locals[7] ^ ~(locals[21] & 0x600) & locals[104] & 0xefbffd9d ^
                      (locals[23] ^ 0x7e89eb23) & locals[4] ^ 0xd36953f6) & locals[60] ^
                     ((locals[104] & 0xcb1fc50d ^ 0x806311d0) & locals[2] ^ locals[104] & 0x1155076e ^ 0xca7eec99) &
                     locals[7]
                     ^ ((locals[23] ^ 0xb5962e2e) & locals[60] ^ locals[104] & 0xfeeafaf3 ^ locals[7] ^ 0xb5962e2e) &
                     locals[234]
                     ^ (locals[21] & 0x1400 ^ 0x76cb5322) & locals[104] ^ 0x81f5c98a;
        locals[13] = ~locals[61] & locals[9] << 0xd ^ locals[103] << 0xd;
        locals[104] = (locals[9] ^ locals[103]) << 0xd ^ ~(locals[9] << 0xd) & locals[61];
        locals[23] = (((locals[38] & 0x65000000 ^ 0xfe7fffff) & locals[109] ^ (locals[8] ^ 0xa4bd0c1e) & 0xfbffffff) &
                         locals[39] ^ locals[38] & 0xaaafffff) >> 0x13 ^
                     ((locals[38] >> 0x13 ^ 0xfffffebf) & locals[109] >> 0x13 ^ 0x502) & 0x1dc7;
        locals[9] = ((locals[38] & 0x8b62 ^ 0x4851) & locals[39] ^ locals[38] & 0x28b62 ^ 0x36515) & locals[109] ^
                    (locals[39] & 0x64091 ^ 0x2ed15) & locals[38];
        locals[7] = (locals[144] & locals[107] & 4 ^ 0xdea80000) & locals[70];
        locals[234] = locals[9] << 0xd;
        locals[14] =
            ((((locals[8] ^ 0x1a43f3e1) & locals[39] ^ locals[38] & 0x10222) & 0x3a626 ^ 0x2c951) & locals[109] ^
             (locals[39] & 0x2404 ^ 0x642b3) & locals[38]) << 0xd;
        locals[60] = ((locals[38] & 0x32d44 ^ 0xbf2e) & locals[109] ^ (locals[8] ^ 0x1a425cc7) & 0x1bf6e) & locals[39] ^
                     (locals[38] & 0x6fddd ^ 0x7eff7) & locals[109] ^ locals[38] & 0x464d5 ^ 0xfffcdafb;
        locals[8] = locals[60] << 0xd;
        locals[103] = ~locals[234] & locals[14];
        locals[21] = locals[8] ^ locals[103] ^ 0x1fff;
        locals[61] = (~locals[104] & locals[11] ^ 0x80000000) & locals[13] ^ (locals[11] ^ 0x7fffffff) & locals[104] ^
                     0x7fffffff;
        locals[3] = (locals[104] & locals[11] ^ 0x7fffffff) & locals[13] ^ (locals[11] ^ 0x80000000) & locals[104] ^
                    locals[11];
        locals[4] = (~(locals[38] >> 0x13 & 0xfffffeaf) & locals[109] >> 0x13 & 0x358 ^
                     (locals[38] & 0x90ffffff ^ 0x77400000) >> 0x13) & locals[39] >> 0x13 ^
                    ((locals[109] & 0xa800000 ^ 0xe7bfffff) & locals[38]) >> 0x13;
        locals[2] = (((locals[38] & 0x65000000 ^ 0x64800000) & locals[109] ^ locals[38] & 0x84afffff ^ 0xbbffffff) &
            locals[39] ^ (locals[109] & 0x1800000 ^ 0x3f500000) & locals[38]) >> 0x13;
        locals[22] = ((locals[107] & 0xdca00004 ^ 0x5ca00007) & locals[70] ^ locals[5] & 5) & locals[144] ^
                     (locals[107] & 0x2880003 ^ 0xce280003) & locals[70];
        locals[180] = locals[22] ^ (locals[5] ^ 0xb20bf8b5) & 7;
        locals[8] = ~locals[8] & locals[234] ^ locals[14] ^ 0x1fff;
        locals[22] = locals[22] >> 0x13;
        locals[234] = locals[233] >> 0x13;
        locals[15] = ~locals[22];
        locals[5] = locals[234] & locals[15] ^ (locals[7] & locals[180]) >> 0x13;
        locals[14] = ~locals[234] & locals[22] ^ locals[7] >> 0x13;
        locals[234] = locals[7] >> 0x13 & locals[15] ^ locals[234];
        locals[60] = (locals[60] ^ locals[9]) << 0xd ^ ~locals[103];
        locals[104] = (locals[104] ^ 0x7fffffff) & locals[11] ^ (locals[104] ^ 0x80000000) & locals[13] ^ locals[104];
        locals[22] = locals[61] >> 3 & ~(locals[3] >> 3) ^ (locals[104] & locals[3]) >> 3 ^ 0xe0000000;
        locals[11] = ~((~((~locals[60] ^ locals[234] ^ locals[14]) & locals[8]) ^
                        (locals[60] ^ locals[234] ^ locals[14]) & locals[21] ^
                        locals[234]) & locals[5]) ^
                     ((~locals[60] ^ locals[14]) & locals[234] ^ locals[21]) & locals[8] ^
                     ~((locals[60] ^ locals[14]) & locals[21]) & locals[234];
        locals[103] = locals[180] & locals[7] & locals[233];
        locals[9] = locals[103] << 0x1d;
        locals[15] = (locals[103] ^ locals[180] ^ locals[7]) << 0x1d &
                     ~(~((locals[180] ^ locals[233]) << 0x1d) & locals[7] << 0x1d);
        locals[13] = (locals[15] ^ locals[9] ^ locals[1]) & locals[12] ^ locals[6];
        locals[60] = ((locals[8] ^ locals[21]) & locals[60] ^ locals[234] ^ locals[8]) & locals[5] ^
                     ((locals[8] ^ locals[21]) & locals[234] ^ locals[8] ^ locals[21]) & locals[60] ^
                     locals[234] & locals[8] ^ locals[21];
        locals[103] = (locals[104] & locals[61]) >> 3 & ~(locals[3] >> 3);
        locals[233] = (locals[104] ^ locals[3]) >> 3;
        locals[21] = ((locals[234] ^ locals[14]) & (~locals[8] ^ locals[21]) ^ locals[8] ^ locals[21]) & locals[5] ^
                     ((~locals[8] ^ locals[21]) & locals[14] ^ locals[8] ^ locals[21]) & locals[234] ^
                     ~locals[21] & locals[8] ^ locals[21];
        locals[6] = (locals[12] ^ ~locals[15] ^ locals[9]) & locals[6];
        locals[8] = locals[15] ^ locals[9] ^ locals[1] ^ locals[6];
        locals[7] = ((locals[11] & 2 ^ 0x62ab1628) & locals[60] ^ locals[11] & 0x78de1f6a ^ 0xdfacf7be) & locals[21] ^
                    (locals[11] & 0x9d05e1d6 ^ 0x4673ae4a) & locals[60] ^ locals[11] & 0x23f91835;
        locals[6] = locals[12] & (~locals[15] ^ locals[9]) ^ locals[1] ^ locals[6];
        locals[61] = locals[7] ^ 0x126d9b7;
        locals[9] = ((locals[11] & 3 ^ 0x6ea85332) & locals[60] ^ locals[11] & 0x29822d2d ^ 0xbd5d98d7) & locals[21] ^
                    (locals[11] & 0xd275ccd9 ^ 0x57ff751f) & locals[60] ^ locals[11] & 0xee6a72e1;
        locals[40] = locals[9] ^ 0x5f08cb6d;
        locals[71] = ((locals[11] & 3 ^ 0x80a8709) & locals[60] ^ locals[11] & 0xf08a17ed ^ 0x2ff7f9f0) & locals[21] ^
                     (locals[11] & 0xcff56815 ^ 0xfa76faf4) & locals[60] ^ locals[11] & 0x101ca51b ^ 0x44492def;
        locals[12] = (locals[71] ^ locals[40]) & 0xff380000;
        locals[1] = ((~(locals[40] & 2) & locals[61] ^ locals[40] ^ 0xfffffffe) & locals[71] ^
                     (locals[7] ^ 0x126d9b4) & locals[40]) &
            7 ^ 0xfffffffd;
        locals[14] = ~((~((locals[2] ^ locals[4] ^ locals[8] ^ locals[13]) & locals[6]) ^ locals[8] ^ locals[4]) &
                       locals[23]) ^
                     (locals[13] ^ locals[2]) & locals[6];
        locals[180] = locals[14] ^ locals[4];
        locals[15] = ((locals[40] & 0x5180000 ^ 0x70380000) & locals[61] ^ locals[40] & 0xaed80000 ^ 0xfa900000) &
                     locals[71]
                     ^ (locals[9] ^ 0xa0773492) & locals[61] & 0x70f80000 ^ ~locals[40] & 0xfad00000;
        locals[9] =
            ((locals[61] & ~locals[40] & 0xfffffffe ^ ~(locals[40] & 0xfffffffc)) & locals[71] ^ locals[61] & 3) & 7;
        locals[7] = ((locals[40] & 2 ^ 1) & locals[61] ^ 6) & locals[71] ^ locals[61] & 3;
        locals[11] = locals[9] << 0x1d;
        locals[234] = locals[7] << 0x1d;
        locals[104] = ~(~(~(locals[1] << 0x1d) & locals[11]) & locals[234]) ^ (locals[9] & locals[1]) << 0x1d;
        locals[3] = (locals[7] ^ locals[1]) << 0x1d ^ 0x1fffffff;
        locals[5] =
            ~(((locals[13] ^ locals[2] ^ locals[4] ^ ~locals[8]) & locals[6] ^ locals[8] ^ locals[2] ^ locals[4]) &
              locals[23]) ^
            (locals[2] ^ locals[4] ^ ~locals[8]) & locals[6] ^ locals[8] ^ locals[2];
        locals[60] = ((locals[40] & 0x5180000 ^ 0x8f077ed8) & locals[61] ^ locals[40] & 0xf125bf78 ^ 0xb12d8158) &
                     locals[71]
                     ^ (locals[40] & 0x8a1ad9e0 ^ 0x522b0) & locals[61] ^ locals[40] & 0x400ac5e8;
        locals[21] = locals[60] ^ 0x2f7a0;
        locals[9] = locals[12] >> 0x13 & ~(locals[15] >> 0x13);
        locals[7] = ~(locals[60] >> 0x13) & locals[15] >> 0x13 ^ locals[9];
        locals[1] = ~(~locals[234] & locals[1] << 0x1d) & locals[11] ^ locals[234] ^ 0x1fffffff;
        locals[234] = (~((locals[1] ^ locals[233]) & locals[22]) ^ locals[1] ^ locals[233]) & locals[104] ^
                      (locals[1] & (locals[104] ^ locals[22]) ^ locals[104] ^ locals[22]) & locals[3] ^
                      ~(locals[103] & (locals[104] ^ locals[22])) & locals[233];
        locals[232] = locals[1] & (locals[3] ^ locals[104]);
        locals[9] = (locals[15] & locals[60]) >> 0x13 ^ locals[9];
        locals[11] = locals[6] & (locals[8] ^ locals[13]);
        locals[1] = (locals[103] & locals[22] ^ locals[3] ^ locals[232]) & locals[233] ^
                    (locals[22] & (locals[3] ^ locals[104]) ^ locals[3] ^ locals[104]) & locals[1] ^
                    locals[3] & ~locals[22] ^ locals[104] ^
                    locals[22];
        locals[6] = (locals[2] & locals[4] ^ locals[8] ^ locals[11]) & locals[23] ^
                    (~locals[11] ^ locals[8] ^ locals[2]) & locals[4] ^ locals[6];
        locals[104] = (locals[103] & ~locals[22] ^ locals[3] ^ locals[104] ^ locals[232]) & locals[233] ^
                      (~locals[232] ^ locals[3] ^ locals[104]) & locals[22] ^ locals[104];
        locals[11] = ~locals[180] & locals[6];
        locals[60] = ~(locals[5] & locals[11] & 0x7ffff);
        locals[72] = locals[60] ^ locals[180] & 0xff80000;
        locals[12] = (locals[15] & locals[12] ^ locals[21]) >> 0x13;
        locals[103] = (locals[21] << 0xd) >> 3;
        locals[22] = (locals[6] ^ locals[180]) >> 0x13;
        locals[2] = ~locals[22];
        locals[23] = (locals[6] & locals[5] & locals[180]) >> 0x13 ^ 0xffffe000;
        locals[3] = ~(~((locals[6] ^ locals[5]) >> 0x13) & locals[14] >> 0x13) & 0x1fff;
        locals[8] = (~(locals[104] & (locals[234] ^ locals[2])) ^ locals[234] & locals[2] ^ locals[22]) & locals[1] ^
                    (locals[23] & (locals[234] ^ locals[2]) ^ locals[22] & locals[234]) & locals[3] ^ locals[23] ^
                    locals[104];
        locals[233] = ~locals[104] ^ locals[234];
        locals[6] = (~(locals[3] & locals[233]) ^ locals[1] & locals[233]) & locals[22] ^
                    (locals[3] ^ locals[1]) & locals[23] & locals[233] ^
                    locals[234];
        locals[234] = (~(~locals[3] & locals[22]) ^ ~locals[1] & locals[234]) & locals[104] ^
                      (~((locals[104] ^ locals[2]) & locals[3]) ^ locals[22] ^ locals[234] ^ locals[1] & locals[233]) &
                      locals[23] ^ locals[22] ^
                      locals[234];
        locals[2] = locals[234] ^ locals[8];
        locals[233] = locals[2] >> 0x13;
        locals[41] = ~(locals[5] & 0x7ffff) ^ ~locals[11] & 0xff80000 ^ locals[180] & 0x7ffff;
        locals[15] = (locals[21] << 0xd ^ 0xffffffff) >> 3;
        locals[23] = ~(locals[21] << 10 & locals[15]) ^ 0x1fffffff;
        locals[22] = ((locals[8] & 0x1e00 ^ 0x7e1ff) & locals[6] ^ ~locals[8] & 0x7e1ff) & locals[234] ^
                     locals[8] & 0xff80000 ^
                     0x7e1ff;
        locals[104] = ~((locals[6] & locals[2]) >> 0x13);
        locals[11] = ((locals[5] ^ 0xfff80000) & locals[180] ^ locals[11] & 0x7ffff) & 0xfffffff;
        locals[180] = locals[11] ^ 0xfff80000;
        locals[5] = ~locals[234] & ~locals[8];
        locals[13] =
            ((~(locals[8] & 0xfff81e00) & locals[234] ^ (locals[8] ^ 0x1e00) & 0x7ffff) & locals[6] ^ locals[5]) &
            0xfffffff;
        locals[244] = ((locals[8] & 0xff80000 ^ 0x1e00) & locals[234] ^ (locals[8] ^ 0x7e1ff) & 0xfffffff) & locals[6] ^
                      locals[5] & 0x1e00;
        locals[60] = locals[60] << 0xd;
        locals[11] = locals[11] << 0xd;
        locals[3] = (locals[6] & locals[2] ^ locals[234] & locals[8]) >> 0x13 ^ 0xffffe000;
        locals[234] = ~locals[60];
        locals[60] = ~locals[11] & locals[60] ^ locals[41] << 0xd & locals[234];
        locals[1] = locals[11] ^ locals[234];
        locals[234] = ~(locals[41] << 0xd) & locals[11] & locals[234];
        locals[21] = locals[22] << 0xd;
        locals[8] = ~(locals[13] << 0xd) ^ locals[21];
        locals[11] = locals[244] << 0xd;
        locals[240] = ~(~locals[21] & locals[11]) & locals[13] << 0xd ^ locals[11];
        locals[21] = ~((locals[13] & locals[22]) << 0xd) & locals[11] ^ locals[21];
        locals[5] = ~locals[234];
        locals[11] = ((locals[1] ^ locals[12] ^ locals[5]) & locals[7] ^ (~locals[60] ^ locals[12]) & locals[1] ^
                      locals[234] & (locals[1] ^ locals[12]) ^ locals[12]) & locals[9] ^
                     (locals[60] & locals[5] ^ locals[234]) & locals[1];
        locals[234] = (~((~locals[1] ^ locals[12]) & locals[7]) ^ locals[1] & locals[12]) & locals[9] ^
                      (locals[234] ^ 0xffffffff ^ locals[60]) & locals[1] ^ locals[234] ^ locals[7];
        locals[7] = ~((locals[9] ^ locals[5]) & locals[60]) & locals[1] ^ 0xffffffff ^ locals[7];
        locals[12] = locals[11] & 0x72254324;
        locals[145] = (locals[234] & 0x8dceacc5 ^ locals[12] ^ 0x8b97179e) & locals[7] ^
                      (locals[12] ^ 0x659bb5b) & locals[234] ^
                      locals[12] ^ 0x87f7a1a5;
        locals[60] = locals[11] & 0x96bbb9d1;
        locals[60] = (locals[234] & 0x604c471a ^ locals[60] ^ 0xd9f81bbc) & locals[7] ^
                     (locals[60] ^ 0xb9b45ca6) & locals[234] ^
                     locals[60];
        locals[11] = locals[11] & 0x4de0264f;
        locals[146] = locals[60] ^ 0xa8d3a382;
        locals[248] = (locals[234] & 0x127dd9e0 ^ locals[11] ^ 0xf56ffd41) & locals[7] ^
                      (locals[11] ^ 0xe71224a1) & locals[234] ^
                      locals[11] ^ 0xd4dfaf02;
        locals[1] = (locals[248] & locals[146] & 4 ^ 0x71de0) & locals[145] ^ locals[248] & 4;
        locals[234] =
            ((locals[146] & 0x714e4 ^ 0x60dc3) & locals[248] ^ locals[146] & 0x500a7 ^ 0x31062) & locals[145] ^
            (~(locals[248] & 0xfffffffe) & locals[146] ^ 0xfffffffc) & 7;
        locals[9] = ((locals[146] & 0x714e4 ^ 0x2f6eb) & locals[248] ^ locals[146] & 0x21d47 ^ 0x5e7a2) & locals[145] ^
                    (locals[60] ^ 0xa8d1556e) & locals[248] & 0x7f6ee ^ locals[146] & 0x21d5f ^ 0x505a4;
        locals[14] = ~((locals[234] ^ locals[9]) << 0x1d) & locals[1] << 0x1d;
        locals[11] = locals[234] << 0xd;
        locals[12] = ~(locals[9] << 0xd) & locals[11] ^ locals[1] << 0xd;
        locals[5] = locals[234] ^ locals[1];
        locals[7] = ~((locals[1] & locals[9]) << 0xd) ^ locals[11];
        locals[234] = locals[234] & locals[1] & locals[9];
        locals[237] = locals[5] << 0x1d;
        locals[242] = ~locals[14];
        locals[4] = locals[234] << 0x1d;
        locals[234] = (locals[234] ^ locals[5]) << 0x1d;
        locals[11] = ~locals[11] & locals[9] << 0xd ^ locals[5] << 0xd;
        locals[1] =
            (~((locals[237] ^ locals[15] ^ ~locals[4]) & locals[103]) ^ (locals[242] ^ locals[15]) & locals[234]) &
            locals[23] ^
            locals[237];
        locals[5] = ~(((locals[15] ^ ~locals[4]) & locals[103] ^ ~locals[15] & locals[4] ^ locals[15]) & locals[23]) ^
                    (locals[14] & locals[4] ^ locals[242]) & locals[237] ^
                    (~(locals[242] & locals[234]) ^ locals[237]) & locals[103] ^ locals[4];
        locals[232] = ~locals[11];
        locals[9] = locals[146] & 0xd1e00000;
        locals[238] = locals[7] & 0xbf780000 ^ locals[9];
        locals[234] = locals[146] & 0xd1e7ffff;
        locals[188] = (locals[146] & 0xe1e80000 ^ 0x4cd00000) & locals[11];
        locals[14] = locals[248] & (locals[60] ^ 0xaaaba382) & locals[232];
        locals[183] = (locals[7] ^ locals[14]) & 0xbf780000;
        locals[189] = ~(((((locals[11] ^ 0xbf7fffff) & locals[7] ^ locals[146] & 0x834fffff ^ locals[12] & locals[232] ^
                           0x1800000
                             ) & locals[248] ^ ~(locals[146] & 0xfcffffff) & 0x830fffff) & 0xfff80000 ^
                         (locals[146] & 0xa1680000 ^ locals[188] ^ 0x8f180000) & locals[7] ^
                         (locals[188] ^ locals[146] & 0xe1e80000 ^ 0x4cd00000) & locals[12]) & locals[145]) ^
                      ((locals[234] ^ locals[14] ^ 0xfcb7ffff) & 0xbf780000 ^ (locals[9] ^ 0xc34fffff) & locals[11]) &
                      locals[7] ^
                      ((locals[238] ^ 0x7c37ffff) & locals[11] ^ locals[183] ^ locals[9] ^ 0x7c37ffff) & locals[12] ^
                      ~locals[248] & locals[146] & 0x80000000;
        locals[103] = ~((~locals[237] ^ locals[23]) & locals[242]) & locals[4] ^
                      (locals[103] ^ locals[242] ^ locals[15]) & locals[237] & locals[23] ^ locals[103];
        locals[23] = (locals[6] & locals[2] ^ locals[2]) >> 0x13;
        locals[4] = ~locals[103];
        locals[6] = locals[4] & locals[1];
        locals[237] = ~(((~locals[3] ^ locals[103]) & locals[1] ^ locals[3] & locals[4] ^ locals[103]) & locals[5]) ^
                      ((locals[23] ^ locals[1]) & locals[103] ^ locals[1]) & locals[3] ^ locals[233] ^ locals[6];
        locals[2] = locals[248] & (locals[60] ^ 0xaaaba382);
        locals[60] = locals[248] ^ locals[146] & 0xe1efffff;
        locals[9] = (((locals[248] & locals[232] ^ locals[146] & 0xe1efffff ^ 0x4cd00000) & 0xfff80000 ^ locals[188]) &
                        locals[145] ^ (locals[238] ^ 0x83c80000) & locals[11] ^ locals[183] ^ locals[9] ^ 0x83c80000) &
                    locals[12] ^
                    ((((locals[60] ^ 0x4cd00000) & locals[145] ^ locals[2] & 0xbf7fffff ^ locals[234] ^ 0x3cb00000) &
                      locals[11] ^
                      0x8007ffff) & locals[7] ^ locals[146] & 0x51e00000 ^ locals[2] & 0x3f780000 ^ 0x3c80000) &
                    0xfff80000
                    ^ (locals[60] & 0x7ff80000 ^ 0xcf180000) & locals[145];
        locals[15] = (((locals[146] & 0xc3cfffff ^ locals[7]) & 0xbf780000 ^ 0x81800000) & locals[248] ^
                      (locals[11] & 0x83c80000 ^ locals[146] & 0xa1680000 ^ 0x8f180000) & locals[7] ^
                      (locals[146] & 0x80000 ^ locals[12] & locals[232] ^ 0xfcf7ffff) & 0x83c80000) & locals[145] ^
                     ((locals[2] ^ locals[234] ^ locals[11]) & 0x4087ffff ^ locals[2] ^ locals[234] ^ 0x3480000) &
                     locals[7] ^
                     (~(locals[7] & locals[232] & 0xbf780000) ^ locals[11]) & locals[12] ^ 0x7fffffff;
        locals[12] = locals[9] >> 3;
        locals[234] = ~(~(~locals[12] & locals[15] >> 3) & locals[189] >> 3) ^ locals[12];
        locals[11] = ~(~(locals[189] >> 0x13) & locals[9] >> 0x13);
        locals[7] = locals[11] ^ locals[15] >> 0x13;
        locals[60] = ~((locals[15] & locals[9]) >> 3) & locals[189] >> 3 ^ locals[12] ^ 0xe0000000;
        locals[2] = ~(~(locals[9] >> 0x13) & locals[15] >> 0x13) ^ locals[189] >> 0x13;
        locals[14] = (locals[15] ^ locals[9]) >> 3;
        locals[12] = ~locals[233];
        locals[15] = (locals[9] & locals[189] ^ locals[15]) >> 0x13;
        locals[9] = ((locals[233] ^ locals[103]) & locals[1] ^ locals[12] & locals[103] ^ locals[3] & locals[23] ^
                     locals[233]) & locals[5] ^
                    (locals[3] & locals[104] ^ ~locals[6]) & locals[233] ^ locals[3] ^ locals[103];
        locals[5] = ~((~((locals[23] ^ locals[103] ^ locals[1]) & locals[5]) ^
                       (locals[12] ^ locals[103]) & locals[104] ^
                       (locals[12] ^ locals[1]) & locals[103] ^ locals[1]) & locals[3]) ^
                    ((locals[4] ^ locals[1]) & locals[5] ^ locals[6] ^ locals[103]) & locals[233] ^ locals[5];
        locals[4] = ((locals[237] ^ 0xfffe1ff) & locals[5] ^ ~locals[237] & 0xfffe1ff) & locals[9] ^
                    ~locals[237] & locals[5] ^
                    0xfffe1ff;
        locals[12] = ~locals[240] ^ locals[15];
        locals[103] = ((~locals[240] ^ locals[7]) & locals[15] ^ locals[21] & locals[12] ^ locals[240]) & locals[8] ^
                      (locals[21] & locals[240] ^ locals[7]) & locals[15] ^
                      (locals[8] ^ locals[15]) & locals[2] & locals[7] ^ locals[21];
        locals[23] = (~locals[21] ^ locals[8]) & (locals[15] ^ locals[2]) & locals[7] ^ locals[21] ^ locals[15];
        locals[8] = ~((~locals[15] & locals[240] ^ locals[8] & locals[12] ^ locals[15]) & locals[21]) ^
                    ~((locals[240] ^ locals[7]) & locals[15]) & locals[8] ^
                    (~locals[8] ^ locals[15]) & locals[2] & locals[7];
        locals[12] = (locals[9] ^ 0xfffe1ff) & locals[237];
        locals[104] = ~(locals[8] & 0xfffffffb) ^ locals[103] & 0xfffffffb;
        locals[15] = ~locals[23] & ~locals[103] & locals[8];
        locals[233] = locals[15] & 0xfffffffb;
        locals[12] = ~((~locals[12] ^ locals[9]) & locals[5]) ^ locals[12] ^ locals[9];
        locals[5] = (locals[9] & locals[237] & 0xfffe1ff ^ 0xf0001e00) & locals[5];
        locals[15] = locals[15] & 0x3c00000;
        locals[103] = (locals[103] ^ 0xfffffffb) & locals[8] ^ (locals[23] ^ 4) & locals[103] ^ locals[23] ^ 4;
        locals[193] = ((locals[104] & 0x3c00000 ^ 0xfc3fffff) & locals[233] ^ locals[104]) & locals[103] ^
                      ~locals[15] & locals[104];
        locals[233] = (~locals[103] & locals[104] & 0x3c00000 ^ locals[103]) & locals[233];
        locals[23] = ~locals[233];
        locals[15] = (~locals[104] & locals[103] ^ locals[104]) & 0xfc3fffff ^ locals[15];
        locals[103] = ~locals[12] ^ locals[4];
        locals[249] = locals[15] ^ locals[4];
        locals[238] = (locals[12] & locals[4] ^ locals[103] & locals[15]) & locals[5] ^
                      ((locals[193] ^ locals[12]) & locals[4] ^ locals[193] ^ locals[12]) & locals[15] ^
                      (locals[249] & locals[193] ^ locals[15] ^ locals[4]) & locals[23];
        locals[190] = ~((locals[23] ^ locals[15]) & locals[193]) ^ locals[103] & locals[5] ^ ~locals[12] & locals[4] ^
                      locals[23] ^ locals[15] ^
                      locals[12];
        locals[6] = locals[190] << 3;
        locals[104] = locals[249] << 3;
        locals[9] = ~(~locals[104] & locals[6]) & locals[238] << 3 ^ locals[104];
        locals[103] = locals[190] * 2;
        locals[8] = locals[249] * 2;
        locals[194] = (~locals[103] & locals[8] ^ locals[103]) & locals[238] * 2 ^ locals[8];
        locals[243] = ~locals[8] ^ locals[103];
        locals[8] = ~(~locals[8] & locals[103]) & locals[238] * 2 ^ locals[8];
        locals[21] = locals[190] << 2;
        locals[103] = ~locals[21] & locals[249] << 2;
        locals[3] = locals[238] << 2;
        locals[103] = ~locals[103] & locals[3] ^ locals[103] ^ locals[21];
        locals[104] = (~locals[6] & locals[104] ^ locals[6]) & locals[238] << 3 ^ locals[104];
        locals[6] = (locals[190] ^ locals[238]) << 3;
        locals[237] = (locals[249] ^ locals[190]) << 2;
        locals[3] = ~(~(~locals[3] & locals[21]) & locals[249] << 2) ^ locals[3];
        locals[21] = locals[104] ^ locals[9];
        locals[2] = locals[237] ^ locals[8] ^ locals[243];
        locals[1] = ~locals[8] ^ locals[243];
        locals[195] = ~(~locals[9] & locals[6]) & locals[104] ^ locals[6];
        locals[188] = (~(locals[2] & locals[194]) ^ (locals[8] ^ locals[243]) & locals[237] ^ locals[8] ^ locals[243]) &
                      locals[103] ^
                      ((locals[2] ^ locals[194]) & locals[103] ^ (locals[1] ^ locals[194]) & locals[237]) & locals[3] ^
                      locals[243];
        locals[183] = (locals[237] ^ locals[103]) & locals[3];
        locals[196] = ~(locals[6] & locals[104]) & locals[9] ^ locals[6];
        locals[232] = ~locals[237] & locals[103];
        locals[240] = ~locals[183];
        locals[2] = ~locals[8] & locals[243];
        locals[250] = ((~locals[103] ^ locals[8]) & locals[194] ^ locals[232] ^ locals[240] ^ locals[8]) & locals[243] ^
                      (~locals[237] & locals[3] ^ ~locals[194] & locals[8] ^ locals[237]) & locals[103] ^ locals[8] ^
                      locals[194];
        locals[245] = ~((locals[2] ^ locals[232] ^ locals[183] ^ locals[8]) & locals[194]) ^
                      (locals[232] ^ locals[240]) & locals[8] ^ locals[103]
                      ^ locals[243];
        locals[232] = (locals[245] ^ locals[250]) & locals[243];
        locals[242] = locals[250] ^ ~locals[245];
        locals[3] = (~(locals[1] & locals[188]) ^ locals[8] ^ locals[243]) & (locals[245] ^ locals[250]) & locals[194] ^
                    (locals[232] ^ locals[245] ^ locals[250]) & locals[188] ^ locals[8] & locals[242] ^ locals[243];
        locals[103] = ~(~locals[243] & locals[188]) & locals[245];
        locals[189] = (~((locals[8] & (locals[245] ^ locals[188]) ^ locals[245]) & locals[243]) ^
                       (locals[188] ^ ~locals[245]) & locals[8] ^
                       locals[245]) & locals[250] ^
                      (~((~(locals[1] & locals[245]) ^ locals[8] ^ locals[243]) & locals[250]) ^ locals[8] ^
                       locals[243] ^ locals[1] & locals[245]
                      ) & locals[194] ^ (locals[243] ^ locals[103]) & locals[8] ^ locals[245];
        locals[240] = ~((~((~(locals[243] & (locals[245] ^ locals[188])) ^ locals[245] ^ locals[188]) & locals[250]) ^
                         locals[243] ^
                         locals[103]) & locals[8]) ^ locals[232] ^ locals[245] ^ locals[250];
        locals[103] = locals[238] ^ ~locals[249];
        locals[237] = locals[3] & (locals[240] ^ locals[189]);
        locals[232] = ((locals[249] ^ locals[238]) & (locals[240] ^ locals[189]) ^ locals[240] ^ locals[189]) &
                      locals[3] ^
                      (locals[240] & locals[103] ^ locals[249] ^ locals[238]) & locals[189] ^
                      locals[190] & locals[103] ^ locals[238];
        locals[103] = locals[240] & locals[189] ^ locals[237];
        locals[183] = (locals[249] ^ locals[103]) & locals[238] ^ locals[249] & locals[103] ^ locals[189];
        locals[249] = ((~locals[240] ^ locals[190]) & locals[189] ^ locals[190] & ~locals[249] ^ locals[237]) &
                      locals[238] ^
                      (~(locals[249] & ~locals[189]) ^ locals[189]) & locals[190] ^
                      locals[240] & locals[3] & ~locals[189] ^ locals[189] ^
                      locals[249];
        locals[103] = locals[6] ^ ~locals[249];
        locals[237] = locals[249] ^ locals[232];
        locals[189] = locals[183] & locals[237];
        locals[147] = ~locals[183];
        locals[251] = (locals[9] & locals[103] ^ locals[249] ^ locals[232] ^ locals[189]) & locals[104] ^
                      (locals[6] & locals[9] ^ locals[183] ^ ~(locals[232] & locals[147])) & locals[249] ^ locals[232] ^
                      locals[6];
        locals[252] = locals[249] ^ ~locals[189];
        locals[246] = ((locals[249] ^ locals[189]) & locals[245] ^ locals[249] ^ locals[232] ^ locals[189]) &
                      locals[250] ^
                      (locals[232] ^ locals[252]) & locals[245] ^ locals[249] ^ locals[189];
        locals[110] = locals[183] ^ ~(locals[232] & locals[147]);
        locals[3] = locals[249] & locals[110];
        locals[238] = locals[249] & locals[147];
        locals[190] = ((locals[188] & locals[252] ^ locals[232] ^ locals[3]) & locals[250] ^
                       (~locals[3] ^ locals[232]) & locals[188] ^
                       locals[249] ^ locals[232] ^ locals[189]) & locals[245] ^
                      (~(locals[188] & (~locals[238] ^ locals[183])) & locals[250] ^ locals[183] ^ locals[238]) &
                      locals[232] ^ locals[250];
        locals[3] = (locals[232] ^ ~locals[249]) & locals[183];
        locals[240] = locals[249] ^ locals[3];
        locals[3] = ~(((~locals[3] ^ locals[249]) & locals[245] ^ (locals[245] ^ locals[240]) & locals[188]) &
                      locals[250]) ^
                    ~(locals[245] & locals[240]) & locals[188] ^ locals[183];
        locals[242] = locals[183] & locals[242];
        locals[252] = ((~locals[242] ^ locals[245] ^ locals[250]) & locals[249] ^ locals[232] & locals[242] ^
                       locals[245] ^ locals[250]) &
            locals[188] ^ locals[245] & locals[250] & locals[252] ^ locals[238];
        locals[242] = (~((~((~((~locals[232] ^ locals[245]) & locals[183]) ^ locals[232] ^ locals[245]) & locals[249]) ^
                          ~(locals[183] & locals[245]) & locals[232] ^ locals[245]) & locals[188]) ^
                       (~(locals[245] & locals[110]) ^ locals[183]) & locals[249] ^
                       (locals[245] ^ locals[147]) & locals[232]) & locals[250] ^
                      (~(locals[245] & locals[188] & (~locals[238] ^ locals[183])) ^ locals[183] ^ locals[245] ^
                       locals[238]) & locals[232] ^
                      locals[245];
        locals[240] = locals[8] ^ ~locals[190];
        locals[253] = (locals[190] ^ locals[246]) & locals[242];
        locals[110] = locals[246] & ~locals[190];
        locals[238] = ~((locals[194] & locals[240] ^ locals[8] ^ locals[110] ^ locals[253]) & locals[243]) ^
                      (~locals[246] & locals[242] ^ ~locals[194] & locals[8]) & locals[190] ^ locals[8] ^ locals[194];
        locals[245] = ~(((locals[183] ^ locals[245]) & locals[188] ^ locals[245] & locals[147]) & locals[250]) ^
                      (locals[245] & locals[188] ^ locals[249] ^ locals[232]) & locals[183] ^ locals[249];
        locals[103] = ((locals[6] ^ locals[104]) & locals[9] ^ ~(locals[183] & locals[103]) ^ locals[6] ^ locals[104]) &
                      locals[232] ^
                      (~locals[104] & locals[9] ^ locals[249] & locals[183] ^ locals[104]) & locals[6] ^ locals[249] ^
                      locals[104];
        locals[1] = ~((~((locals[243] ^ locals[194] ^ locals[240]) & locals[242]) ^
                       (locals[1] ^ locals[194]) & locals[190] ^ locals[8] ^
                       locals[243] ^ locals[194]) & locals[246]) ^
                    ((~locals[242] ^ locals[8] ^ locals[243]) & locals[194] ^ (locals[8] ^ locals[243]) & locals[242]) &
                    locals[190] ^ locals[8] ^
                    locals[194];
        locals[240] = ~locals[251] & locals[103] & 0x82001000;
        locals[243] = (~locals[253] ^ locals[2] ^ locals[8] ^ locals[110]) & locals[194] ^
                      (locals[110] ^ locals[253]) & locals[8] ^ locals[190] ^
                      locals[243];
        locals[2] = ~locals[243];
        locals[232] = (((locals[183] ^ locals[9]) & locals[237] ^ locals[249] ^ locals[232]) & locals[6] ^
                       (locals[9] & locals[237] ^ locals[249] ^ locals[232] ^ ~locals[189]) & locals[104] ^
                       locals[249]) &
            (~locals[103] ^ locals[251]) & 0x82001000 ^ 0x7dffefff;
        locals[104] = locals[238] & (locals[1] ^ locals[2]);
        locals[6] = ~locals[21];
        locals[103] = (locals[103] ^ locals[251]) & 0x82001000;
        locals[242] = ((locals[1] ^ locals[21]) & locals[196] ^ (locals[21] ^ locals[2]) & locals[1] ^ ~locals[104] ^
                       locals[243] ^ locals[21]) &
            locals[195] ^ (locals[196] & locals[6] ^ locals[243] & locals[238]) & locals[1];
        locals[183] = ~locals[1];
        locals[8] = locals[195] & locals[183];
        locals[8] = (~((~((~((locals[195] ^ locals[183]) & locals[243]) ^ locals[1] ^ locals[8]) & locals[21]) ^
                        locals[243] & (~locals[8] ^ locals[1]) ^ locals[1] ^ locals[8]) & locals[196]) ^
                     (~(~(locals[1] & locals[6]) & locals[195]) ^ locals[1]) & locals[243] ^ locals[1] ^ locals[8]) &
                    locals[238] ^
                    (~((~(locals[21] & (~locals[8] ^ locals[1])) ^ locals[1] ^ locals[8]) & locals[196]) ^ locals[1] ^
                     locals[8]) & locals[243] ^
                    locals[1] ^ locals[195];
        locals[9] = locals[240] >> 3;
        locals[104] =
            (((~(locals[196] & (locals[1] ^ locals[2])) ^ locals[243] & locals[183] ^ locals[1]) & locals[238] ^
              (~(locals[196] & locals[183]) ^ locals[1]) & locals[243] ^ locals[1] ^ locals[196]) & locals[21] ^
             (~(~(~locals[196] & locals[1]) & locals[243]) ^ locals[1]) & locals[238] ^
             (locals[196] ^ locals[2]) & locals[1] ^
             locals[243] ^ locals[196]) & locals[195] ^
            (~((~(locals[243] & locals[238] & locals[6]) ^ locals[21]) & locals[1]) ^ locals[21]) & locals[196] ^
            locals[243] & locals[183] ^ locals[104];
        locals[6] = locals[232] >> 3;
        locals[21] = locals[103] >> 3;
        locals[188] = ~locals[21] & locals[9] ^ locals[6] ^ 0xe0000000;
        locals[189] = ~locals[6] & locals[21] ^ locals[9] ^ 0xe0000000;
        locals[9] = ~locals[8] ^ locals[252];
        locals[6] = ~locals[104] ^ locals[242] ^ locals[252];
        locals[190] = (locals[103] & locals[232] ^ locals[240]) >> 3;
        locals[238] = (locals[8] & locals[6] ^ locals[9] & locals[3] ^ locals[242]) & locals[245] ^
                      (~(~locals[3] & locals[252]) ^ locals[104]) & locals[8] ^ locals[252] ^ locals[3];
        locals[243] = ~((~((locals[104] ^ locals[242] ^ locals[252]) & locals[8]) ^ locals[9] & locals[245] ^
                         locals[242] ^ locals[252]) &
                        locals[3]) ^
                      (locals[6] & locals[245] ^ (~locals[104] ^ locals[242]) & locals[252] ^ locals[104]) & locals[8] ^
                      (locals[245] ^ locals[252]) & locals[242] ^ locals[245];
        locals[237] =
            ~(((~locals[252] ^ locals[3]) & (locals[104] ^ locals[242]) ^ locals[252] ^ locals[3]) & locals[8]) ^
            locals[242] & (~locals[252] ^ locals[3]) ^ locals[245] ^ locals[252] ^ locals[3];
        locals[21] = (((locals[237] ^ locals[242]) & 0x7dffefff ^ 0x82001000) & locals[238] ^
                      ~(locals[242] & 0x7dffefff) & locals[237]) & locals[243] ^
                     ((locals[238] & 0x7dffefff ^ locals[104] ^ locals[8]) & locals[242] ^ locals[238] ^ locals[104]) &
                     locals[237] ^
                     locals[8] & locals[242];
        locals[103] = locals[242] & ~locals[8];
        locals[6] = locals[104] & ~locals[242];
        locals[9] = ~locals[6] ^ locals[103];
        locals[240] = ~(((locals[237] ^ locals[103] ^ locals[6]) & locals[238] ^ locals[237] & locals[9]) &
                        locals[243] & 0x82001000) ^
                      ~(locals[238] & locals[9] & 0x82001000) & locals[237] ^ locals[242];
        locals[9] = locals[8] & 0x82001000 ^ 0x7dffefff;
        locals[103] = locals[242] & locals[9] ^ locals[6] & 0x82001000;
        locals[242] = ~(((~locals[237] & 0x7dffefff ^ locals[103]) & locals[238] ^ locals[237] & locals[103]) &
                        locals[243]) ^
                      (~((~(locals[238] & ~locals[242] & 0x82001000) ^ locals[242]) & locals[237]) ^ locals[242]) &
                      locals[104] ^
                      ~((locals[238] & locals[9] ^ locals[8]) & locals[242]) & locals[237] ^ locals[242];
        locals[246] = ~locals[240];
        locals[103] = (~((locals[21] & locals[246] ^ locals[240]) & locals[237]) ^ locals[240]) & locals[243] ^
                      ~(locals[242] & locals[238] & (locals[237] ^ locals[243]) & (locals[240] ^ locals[21])) ^
                      (locals[237] ^ locals[246]) & locals[21];
        locals[8] = locals[240] & (locals[237] ^ locals[243]);
        locals[1] = ((locals[237] ^ locals[243] ^ locals[8]) & locals[21] ^ locals[237] ^ locals[243] ^ locals[8]) &
                    locals[238] ^
                    ~(locals[242] & locals[237] & (locals[240] ^ locals[21])) & locals[243] ^ locals[21];
        locals[9] = (locals[242] ^ locals[21]) >> 2;
        locals[2] = ~((locals[242] & locals[21]) >> 2);
        locals[232] = ~(locals[242] & locals[21] & 0x82001000) ^ locals[240] & 0x82001000;
        locals[104] = (locals[240] & (locals[242] ^ locals[21]) ^ locals[242]) >> 2;
        locals[6] = (~locals[21] & locals[242] ^ locals[246]) & 0x82001000;
        locals[183] = ~locals[242];
        locals[8] = (locals[242] & locals[240] ^ locals[21] & locals[183]) & 0x82001000 ^ 0x7dffefff;
        locals[237] = ((~((~((locals[237] ^ locals[183]) & locals[240]) ^ locals[237] & locals[183]) & locals[21]) ^
                        (~(locals[242] & ~locals[237]) ^ locals[237]) & locals[240] ^ locals[237]) & locals[238] ^
                       ((~(locals[21] & locals[183]) ^ locals[242]) & locals[240] ^ locals[21]) & locals[237] ^
                       locals[240]) & locals[243] ^
                      (~(locals[242] & locals[238] & locals[246]) & locals[237] ^ locals[240]) & locals[21] ^
                      locals[240] ^ locals[237];
        locals[240] = (locals[237] & locals[1] ^ locals[252] & locals[3]) & (~locals[103] ^ locals[245]) ^
                      ~((locals[1] ^ locals[252]) & locals[103] & locals[245]) ^ locals[1] ^ locals[252];
        locals[238] = ((~locals[237] ^ locals[103] ^ locals[252]) & locals[245] ^
                       (locals[103] ^ locals[252]) & locals[237] ^
                       (locals[103] ^ locals[3]) & locals[252]) & locals[1] ^
                      (locals[103] & ~locals[3] ^ (locals[103] ^ locals[3]) & locals[245]) & locals[252] ^ locals[103] ^
                      locals[245];
        locals[183] = (locals[104] ^ locals[2]) & locals[9];
        locals[21] =
            ~(((~locals[9] ^ locals[190]) & locals[189] ^ locals[183] ^ locals[2] ^ locals[190]) & locals[188]) ^
            (~locals[189] & locals[190] ^ locals[104]) & locals[9] ^ locals[190] ^ locals[189];
        locals[252] = ~((locals[237] ^ locals[103] ^ locals[245] ^ locals[3]) & locals[252]) & locals[1] ^ locals[103] ^
                      locals[245] ^ locals[252]
            ;
        locals[3] = (~locals[190] & locals[188] ^ ~locals[183] ^ locals[2] ^ locals[190]) & locals[189] ^
                    (locals[183] ^ locals[2]) & locals[190]
                    ^ locals[9] ^ locals[188];
        locals[189] =
            ((locals[188] ^ locals[190] ^ locals[189]) & locals[104] ^ (~locals[188] ^ locals[190]) & locals[189]) &
            locals[9] ^
            (~((~locals[188] ^ locals[190] ^ locals[189]) & locals[9]) ^ locals[188] ^ locals[190] ^ locals[189]) &
            locals[2] ^
            locals[190] ^ locals[189];
        locals[104] = (~locals[238] & locals[240] ^ locals[252]) & 0x82001000;
        locals[103] = (~locals[240] & locals[252] ^ locals[238]) & 0x82001000;
        locals[9] = (locals[104] ^ locals[103]) >> 1;
        locals[104] = (locals[104] & locals[103]) >> 1;
        locals[2] = (locals[238] >> 1 & ~(locals[240] >> 1) ^ (locals[252] & locals[240]) >> 1) & locals[9];
        locals[183] = locals[2] ^ locals[104];
        locals[1] = (~locals[183] ^ locals[9]) & locals[6];
        locals[1] = ((~locals[183] ^ locals[9]) & locals[8] ^ ~locals[1] ^ locals[183] ^ locals[9]) & locals[232] ^
                    ~(locals[183] & locals[9]) & locals[104] ^ locals[183] ^ locals[1];
        locals[103] = (~locals[6] ^ locals[8]) & locals[232];
        locals[237] = (locals[104] & locals[183] ^ ~locals[103] ^ locals[6]) & locals[9] ^
                      (locals[183] ^ locals[103] ^ locals[6]) & locals[104] ^
                      locals[183];
        locals[9] = ~(((locals[6] ^ locals[8]) & locals[2] ^ locals[104] ^ locals[183]) & locals[232]) ^ locals[104] ^
                    locals[9];
        locals[8] = (locals[9] ^ locals[1]) & (locals[3] ^ locals[21]);
        locals[103] = (locals[3] & locals[21] ^ locals[237]) & (~locals[9] ^ locals[1]) ^
                      ~((locals[8] ^ locals[3] ^ locals[21]) & locals[189]) ^
                      locals[9] ^ locals[21];
        locals[8] = (~((locals[9] ^ locals[1]) & locals[3]) ^ locals[9] ^ locals[1]) & locals[21] ^
                    ~(locals[8] & locals[189]) ^ locals[9];
        locals[242] = ~locals[8];
        locals[1] = ~(((locals[1] ^ locals[3]) & locals[21] ^ (locals[1] ^ locals[21]) & locals[237] ^
                       (locals[3] ^ locals[21]) & locals[189]) &
                      locals[9]) ^ (~(~locals[3] & locals[189]) ^ ~locals[1] & locals[237] ^ locals[1] ^ locals[3]) &
            locals[21] ^ locals[1];
        locals[9] = ~locals[1];
        locals[104] = (locals[8] ^ locals[9]) & locals[103];
        locals[254] = (~(locals[1] & locals[242]) & locals[103] ^ locals[242] & locals[9]) & 0x3c00000;
        locals[238] = ~(~locals[103] & locals[1] & locals[242]);
        locals[73] = (locals[104] ^ locals[9]) & 0xf3c00000;
        locals[148] = locals[238] & 0x3c00000;
        locals[2] = locals[254] ^ locals[148];
        locals[232] = (locals[73] & locals[2] ^ locals[254] & locals[148]) << 6;
        locals[237] = ~locals[254];
    }
}