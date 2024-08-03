using System.Runtime.InteropServices;

namespace HarpoS7.Family0.Monoliths.Nine;

/// <summary>
/// Starts at line 20248 and goes to the end
/// </summary>
internal static class Part11
{
    public static void Execute(Span<byte> destination, Span<uint> locals)
    {
        var dst = MemoryMarshal.Cast<byte, uint>(destination);

        locals[800] = (locals[720] & 0x300030) >> 2;
        locals[765] = ~(~(~(locals[794] >> 2) & locals[793] >> 2) & locals[800]) ^ (locals[793] & locals[794]) >> 2;
        locals[766] = (locals[260] & 0xc000c000 ^ 0x3000300) & locals[812] & locals[782];
        locals[768] = ~locals[766];
        locals[657] = locals[812] & locals[779] & ~locals[782] & 0x300030;
        locals[755] = (locals[785] ^ locals[752]) >> 6;
        locals[709] = ~(locals[683] >> 10) & locals[811] >> 10 ^ locals[781] >> 10;
        locals[462] = (locals[781] ^ locals[811] & locals[683]) >> 10;
        locals[800] = ~(~locals[800] & locals[793] >> 2) & locals[794] >> 2 ^ locals[800];
        locals[748] = ~(locals[260] & 0xfcfffcff) & locals[782] & locals[636] & 0xc300c300 ^ 0x3fff3fff;
        locals[827] = ~(((locals[782] ^ 0xfffcfffc) & locals[260] ^ 0xfffcfffc) & locals[812] & 0xc030c03);
        locals[802] = ~(~locals[802] & locals[769] & 0xc000c000);
        locals[769] = (locals[748] ^ locals[775]) >> 2 ^ 0xc0000000;
        locals[816] = (locals[260] ^ locals[636]) & locals[782] ^ locals[260];
        locals[788] = locals[816] & 0x3c003c ^ 0xffc3ffc3;
        locals[792] = ~(~((locals[772] & locals[802]) >> 4) & locals[791] >> 4) ^ locals[772] >> 4;
        locals[408] = locals[816] & 0x30c030c0 ^ 0xcf3fcf3f;
        locals[683] = ~((locals[811] & locals[683]) << 2) & locals[781] << 2 ^ locals[811] << 2;
        locals[813] = locals[748] >> 2;
        locals[816] = ~locals[813] & locals[775] >> 2;
        locals[757] = ~(~locals[816] & locals[768] >> 2) ^ locals[775] >> 2;
        locals[781] = ((~(locals[260] & 0x30003) & locals[812] ^ locals[779]) & locals[782] ^ locals[260]) & 0xc030c03 ^
                      0xf3fcf3fc;
        locals[301] = (locals[408] ^ locals[764]) >> 6;
        locals[760] = (locals[657] ^ locals[749]) << 2;
        locals[813] = (locals[816] ^ locals[813]) & locals[768] >> 2 ^ locals[813];
        locals[814] = locals[774] >> 6 & ~locals[301] ^ locals[764] >> 6 ^ 0xfc000000;
        locals[260] = (((locals[260] ^ 0x30003) & locals[782] ^ locals[260] & 0xfffcfffc) & locals[812] ^
                       ~(locals[782] & locals[779]) & 0x30003) & 0xc030c03;
        locals[657] = locals[657] << 2;
        locals[812] = ~(~(locals[788] << 2) & locals[657]) ^ (locals[788] ^ locals[749]) << 2;
        locals[782] = locals[774] << 8 & ~(locals[764] << 8) ^ locals[764] << 8;
        locals[699] = locals[408] >> 6 & ~(locals[764] >> 6);
        locals[790] = ~(locals[827] << 4) & locals[781] << 4 ^ (locals[260] & locals[827]) << 4 ^ 0xf;
        locals[770] = ~(locals[791] >> 4) & locals[772] >> 4 ^ locals[802] >> 4;
        locals[753] = (locals[802] & locals[791] ^ locals[772]) << 4;
        locals[794] = (locals[794] ^ locals[793]) >> 2;
        locals[816] = (locals[755] ^ locals[757] ^ locals[769]) & locals[813];
        locals[720] = ~locals[816];
        locals[742] = ((locals[704] ^ ~locals[813]) & locals[755] ^ locals[813] ^ locals[704]) & locals[759] ^
                      ~((locals[757] & locals[769] ^ locals[720]) & locals[704]) ^
                      ~(locals[769] & ~locals[813]) & locals[757] ^ locals[813];
        locals[657] = ~(locals[749] << 2 & ~locals[657]) & locals[788] << 2 ^ locals[657];
        locals[811] = (locals[791] << 4 & ~(locals[802] << 4) ^ ~(locals[772] << 4)) & 0xfffffff0;
        locals[636] = (locals[462] ^ locals[699] ^ locals[301]) & locals[814];
        locals[777] = ((~locals[699] ^ locals[301] ^ locals[773]) & locals[462] ^ locals[699] ^ locals[636]) &
                      locals[709] ^
                      (locals[814] ^ locals[699] ^ locals[301]) & locals[462] & locals[773] ^
                      (locals[301] ^ locals[814]) & locals[699] ^
                      locals[301];
        locals[788] = locals[788] << 0xc ^ 0xfff;
        locals[799] = (~locals[814] ^ locals[709]) & locals[462] & locals[773] ^
                      ~((locals[301] ^ locals[636]) & locals[709]) ^
                      locals[301] & locals[814] ^ locals[699];
        locals[778] = ~locals[788] ^ locals[793] << 8 ^ 0xffffffff;
        locals[636] = (~locals[769] ^ locals[755]) & locals[757];
        locals[769] = ~((locals[759] ^ ~locals[757]) & locals[755]) & locals[704] ^
                      (locals[813] & (locals[757] ^ locals[769]) ^ locals[636]) & locals[759] ^
                      ~(locals[769] & ~locals[757]) & locals[813];
        locals[791] = (~(locals[791] << 4) & locals[772] << 4 ^ ~(locals[802] << 4)) & 0xfffffff0;
        locals[755] = (locals[781] & locals[827] ^ locals[260]) << 4;
        locals[749] = ~(locals[788] & locals[793] << 8) ^ 0xffffffff;
        locals[793] = (~(locals[781] << 4) & locals[827] << 4 ^ ~(locals[260] << 4)) & 0xfffffff0;
        locals[615] = (locals[774] & locals[764]) << 8;
        locals[779] = locals[760] & ~locals[812];
        locals[750] =
            ~(((locals[812] ^ locals[800]) & locals[657] ^ locals[765] & (locals[657] ^ locals[800]) ^ locals[779]) &
              locals[794]) ^
            (~locals[800] & locals[765] ^ ~locals[779] ^ locals[812] ^ locals[800]) & locals[657] ^ locals[765];
        locals[779] = (locals[774] ^ locals[764]) & locals[408] ^ locals[774];
        locals[408] = locals[779] << 8;
        locals[802] = (locals[802] ^ locals[772]) >> 4;
        locals[779] = (locals[779] ^ locals[774] & locals[764]) << 8;
        locals[813] = ~locals[408];
        locals[772] = ~(((locals[753] ^ locals[782] ^ locals[779]) & locals[811] ^
                         (locals[782] ^ locals[813]) & locals[615] ^ locals[753] ^
                         locals[782] & locals[813]) & locals[791]) ^
                      (~((locals[782] ^ locals[615] ^ locals[813]) & locals[811]) ^ locals[408] ^ locals[615] ^
                       locals[782]) & locals[753] ^
                      ~(locals[782] & locals[813]) & locals[615] ^ locals[782];
        locals[779] = ((locals[753] ^ locals[782] ^ locals[615] ^ locals[813]) & locals[811] ^
                       (locals[408] ^ locals[782]) & locals[615] ^
                       locals[753] ^ locals[408] & locals[782]) & locals[791] ^
                      ((locals[782] ^ locals[779]) & locals[811] ^ locals[408] ^ locals[615] ^ locals[782]) &
                      locals[753] ^
                      ~(locals[408] & locals[782]) & locals[615] ^ locals[782];
        locals[757] = (locals[636] ^ locals[720]) & locals[759] ^ (locals[636] ^ locals[816]) & locals[704] ^
                      locals[757];
        locals[816] = ~locals[748];
        locals[704] =
            ~(((~locals[802] ^ locals[792] ^ locals[748]) & locals[775] ^ (locals[816] ^ locals[775]) & locals[768]) &
              locals[770])
            ^ (~(locals[766] & locals[748]) ^ locals[802] ^ locals[792]) & locals[775] ^ locals[792] ^ locals[768];
        locals[764] =
            ((locals[800] ^ ~locals[812]) & locals[657] ^ ~(locals[794] & (locals[657] ^ locals[800])) ^ locals[800]) &
            locals[765]
            ^ (~((~locals[657] ^ locals[765]) & locals[812]) ^ locals[657] ^ locals[765]) & locals[760] ^
            (~(locals[794] & ~locals[657]) ^ locals[657]) & locals[800] ^ locals[794];
        locals[800] = ~(locals[827] << 6 & ~(locals[260] << 6)) & locals[781] << 6 ^ locals[260] << 6;
        locals[812] = (locals[657] ^ locals[760]) & locals[812];
        locals[657] = (~locals[812] ^ locals[657] ^ locals[760]) & locals[794] ^
                      (locals[657] ^ locals[760] ^ locals[812]) & locals[765] ^
                      locals[657];
        locals[720] = ~locals[755] ^ locals[790];
        locals[794] = (~((~locals[793] ^ locals[752]) & locals[796]) ^ locals[793] ^ locals[752]) & locals[785] ^
                      (~((locals[720] ^ locals[796]) & locals[793]) ^ locals[790] ^ locals[796]) & locals[752] ^
                      (locals[790] ^ locals[796]) & locals[793] ^ locals[790];
        locals[811] = (locals[615] ^ locals[782]) & locals[811];
        locals[408] = ~((~locals[811] ^ locals[615] ^ locals[782]) & locals[791]) ^
                      (locals[615] ^ locals[782] ^ locals[811]) & locals[753] ^
                      locals[408];
        locals[812] = ~((locals[260] & locals[827]) << 6) ^ locals[781] << 6;
        locals[811] = (~((locals[764] ^ ~locals[408]) & locals[779]) ^ (locals[657] ^ locals[750]) & locals[764] ^
                       locals[750] & ~locals[657])
            & locals[772] ^ (~locals[750] & locals[657] ^ locals[408] & locals[779]) & locals[764] ^ locals[750];
        locals[260] =
            (~locals[796] & locals[785] ^ locals[793] & locals[720] ^ locals[790] ^ locals[796]) & locals[752] ^
            (locals[793] & locals[720] ^ locals[790]) & locals[796] ^ locals[793];
        locals[781] = (locals[781] ^ locals[827]) << 6;
        locals[782] = ((locals[816] ^ locals[768]) & locals[792] ^ locals[816] & locals[768] ^ locals[748]) &
                      locals[775] ^
                      (~((~locals[792] ^ locals[768]) & locals[770]) ^ locals[792] ^ locals[768]) & locals[802] ^
                      ~((locals[770] ^ locals[748]) & locals[768]) & locals[792] ^ locals[770] ^ locals[768];
        locals[813] = (locals[408] ^ locals[772]) & (locals[750] ^ ~locals[764]) & locals[779] ^ locals[764] ^
                      locals[772];
        locals[636] = (locals[781] ^ locals[800]) & locals[812];
        locals[764] = ((locals[750] ^ ~locals[657]) & locals[764] ^ (locals[750] ^ ~locals[408]) & locals[779] ^
                       locals[657] & locals[750]) &
            locals[772] ^ (~(locals[657] & ~locals[764]) ^ locals[408] & locals[779]) & locals[750] ^ locals[764];
        locals[752] =
            ~((~((locals[720] ^ locals[785] ^ locals[752]) & locals[796]) ^ locals[755] ^ locals[785] ^ locals[752]) &
              locals[793])
            ^ ~locals[790] & locals[796] ^ locals[752];
        locals[720] = ~locals[813];
        locals[796] = ((locals[811] ^ 0xbbbbbbbb) & locals[764] ^ ~locals[811] & 0xbbbbbbbb) & locals[720] & 0xcccccccc;
        locals[759] =
            (((locals[811] ^ 0x44444444) & locals[764] ^ ~locals[811] & 0x44444444) & locals[813] ^ 0x44444444) &
            0xcccccccc;
        locals[779] = ~locals[636] ^ locals[781] ^ locals[331];
        locals[813] = (~locals[683] ^ locals[776]) & locals[812];
        locals[813] = ~((~locals[813] ^ locals[683] ^ locals[776]) & locals[781]) ^
                      (locals[813] ^ locals[683] ^ locals[776]) & locals[800] ^
                      locals[683];
        locals[793] = (locals[811] & locals[720] & 0x44444444 ^ 0x88888888) & locals[764] ^ locals[811] & 0x44444444;
        locals[811] = locals[796] >> 1;
        locals[772] = ~(~(locals[793] >> 1) & locals[759] >> 1) & locals[811] ^ locals[793] >> 1;
        locals[720] = (~locals[813] ^
                       (~locals[812] & locals[781] ^ locals[331] & locals[776] ^ locals[812]) & locals[800] ^
                       ((~locals[800] ^ locals[776]) & locals[331] ^ locals[781] ^ locals[800] ^ locals[636]) &
                       locals[683] ^ locals[776]) &
                      ((locals[779] ^ locals[776]) & locals[683] ^ locals[779] & locals[776] ^ locals[800]);
        locals[636] = locals[788] ^ locals[778];
        locals[800] = (locals[813] ^ locals[720] ^ locals[749]) & locals[636];
        locals[779] = locals[759] ^ locals[796];
        locals[331] = ~((locals[779] & locals[793]) >> 1) ^ locals[811];
        locals[749] = ~locals[749];
        locals[720] = (locals[749] ^ locals[778]) & locals[788] ^ locals[749] & locals[778] ^ locals[813] ^ locals[720];
        locals[813] = ~locals[769] ^ locals[742];
        locals[749] = (~(locals[752] & locals[813]) ^ locals[260] & locals[813] ^ locals[769] ^ locals[742]) &
                      locals[757] ^
                      ~((locals[260] ^ ~locals[752]) & locals[742]) & locals[769] ^ locals[260];
        locals[462] = (locals[709] ^ locals[773]) & locals[462];
        locals[799] = ~((~(((locals[802] ^ locals[768] ^ locals[775]) & locals[770] ^
                            locals[768] & (locals[748] ^ locals[775]) ^
                            locals[816] & locals[775] ^ locals[802]) & locals[792]) ^
                         ((locals[802] ^ locals[748] ^ locals[775]) & locals[770] ^ locals[802] ^ locals[748] ^
                          locals[775]) & locals[768] ^
                         ((~locals[802] ^ locals[748]) & locals[770] ^ locals[802] ^ locals[748]) & locals[775] ^
                         locals[770]) &
                        (locals[782] ^ locals[704])) ^
                      ((locals[462] ^ locals[699] ^ locals[814]) & locals[301] ^
                       (~locals[462] ^ locals[814]) & locals[699] ^ locals[814] ^
                       locals[709]) & (locals[777] ^ locals[799]) ^ ~locals[799] & locals[777] ^
                      ~locals[782] & locals[704] ^ locals[782] ^
                      locals[799];
        locals[462] = ~locals[799] & locals[771] & 0x88888888 ^ locals[799] & 0x44444444;
        locals[813] = locals[757] & locals[813];
        locals[301] = ~((~locals[742] & locals[769] ^ locals[813] ^ locals[794]) & locals[752]) ^
                      (~locals[813] ^ ~locals[742] & locals[769] ^ locals[794]) & locals[260] ^ locals[769];
        locals[811] = ~(~((locals[796] & locals[793]) >> 1) & locals[759] >> 1) ^ locals[811];
        locals[816] = ~locals[772];
        locals[802] = ~(((locals[793] ^ locals[759]) & (locals[816] ^ locals[331]) ^ locals[772] ^ locals[331]) &
                        locals[811]) ^
                      (~locals[793] ^ locals[759]) & locals[772] ^ locals[796];
        locals[812] = ~locals[636];
        locals[776] =
            (~(locals[800] & 0x44444444) & locals[812] & locals[720] ^ ~locals[800] & locals[636] & 0xbbbbbbbb) &
            0xcccccccc;
        locals[782] = locals[799] & 0xcccccccc;
        locals[785] = locals[815] & locals[799] & 0x88888888;
        locals[636] = (locals[812] & locals[720] ^ ~locals[800] & locals[636]) & 0x44444444;
        locals[752] =
            ((~locals[752] ^ locals[769]) & locals[794] ^ (locals[752] ^ locals[742]) & locals[769] ^ locals[813]) &
            locals[260] ^
            (~(~locals[794] & locals[752]) ^ ~locals[757] & locals[742]) & locals[769] ^ locals[752];
        locals[813] = ~locals[720] & locals[812] & locals[800] & 0x44444444;
        locals[812] = ((locals[636] ^ locals[776]) & locals[813] ^ locals[636]) >> 1;
        locals[773] = ((locals[749] & 0x88888888 ^ 0x44444444) & locals[301] ^ locals[749] & 0x88888888 ^ 0x44444444) &
            locals[752] ^ locals[301] & locals[749] & 0x44444444;
        locals[800] = (locals[301] ^ locals[749]) & 0x88888888;
        locals[720] = locals[785] >> 1;
        locals[704] = ~((locals[782] & locals[785]) >> 1) & locals[462] >> 1 ^ locals[720];
        locals[683] = ~(locals[813] >> 1) & locals[636] >> 1 & locals[776] >> 1;
        locals[749] = ~(~(locals[749] & 0xbbbbbbbb) & ~locals[301] & locals[752] & 0xcccccccc) ^
                      locals[301] & locals[749] & 0xcccccccc;
        locals[301] = (locals[813] ^ locals[776]) >> 1;
        locals[781] = (locals[785] ^ locals[782]) >> 1;
        locals[720] = ~(~(~(locals[782] >> 1) & locals[720]) & locals[462] >> 1) ^ locals[720];
        locals[260] = ((locals[816] ^ locals[759] ^ locals[331]) & locals[796] ^ locals[793] & locals[779] ^
                       locals[759] ^ locals[331]) &
            locals[811] ^ (~(~locals[759] & locals[793]) ^ locals[772]) & locals[796] ^ locals[793] ^ locals[759];
        locals[815] = (locals[720] ^ locals[785]) & locals[704];
        locals[794] = ((locals[704] ^ locals[785] ^ locals[782] ^ locals[462]) & locals[720] ^ locals[704] ^
                       locals[785] ^ locals[782] ^
                       locals[462]) & locals[781] ^
                      ~(((locals[704] ^ locals[785]) & locals[782] ^ ~locals[815]) & locals[462]) ^
                      (~((~locals[785] ^ locals[782]) & locals[720]) ^ locals[785] & locals[782]) & locals[704];
        locals[759] = ((locals[772] ^ locals[759] ^ locals[796] ^ locals[331]) & locals[811] ^
                       ~locals[796] & locals[759] ^ locals[772] ^
                       locals[796]) & locals[793] ^
                      (~((locals[816] ^ locals[796] ^ locals[331]) & locals[759]) ^
                       (locals[816] ^ locals[331]) & locals[796] ^ locals[331]) &
                      locals[811] ^ locals[772] & locals[779] ^ locals[759];
        locals[816] = locals[781] ^ locals[704];
        locals[779] = (locals[785] ^ locals[462] ^ locals[816]) & locals[782] ^
                      (locals[462] ^ locals[816]) & locals[785] ^
                      (~locals[785] ^ locals[782]) & locals[720] & locals[816] ^ locals[781];
        locals[331] = (~locals[776] & locals[636] ^ (locals[683] ^ locals[812]) & locals[301]) & locals[813] ^
                      (locals[683] ^ locals[812]) & locals[301] ^ locals[812] ^ locals[776];
        locals[796] =
            ~(((~locals[636] ^ locals[813] ^ locals[776]) & locals[301] ^ (locals[813] ^ locals[776]) & locals[636]) &
              locals[812])
            ^ (locals[636] ^ locals[812] ^ locals[813] ^ locals[776]) & locals[301] & locals[683] ^ locals[636] ^
            locals[813];
        locals[776] = (~((locals[301] ^ locals[636]) & locals[776]) ^ locals[301] ^ locals[636]) & locals[812] ^
                      (~((locals[812] ^ locals[776]) & locals[636]) ^ locals[812] ^ locals[776]) & locals[813] ^
                      (locals[812] ^ locals[776]) & locals[301] & locals[683] ^ locals[636] ^ locals[776];
        locals[782] =
            ~(((~locals[704] ^ locals[785]) & locals[782] ^ locals[815] ^ ~locals[720] & locals[781] ^ locals[785]) &
              locals[462]) ^
            (locals[785] & locals[782] ^ ~locals[720] & locals[781] ^ locals[720]) & locals[704] ^ locals[785] ^
            locals[782];
        locals[636] = locals[749] >> 1;
        locals[816] = ~locals[636] & locals[800] >> 1;
        locals[636] = ~((locals[816] ^ locals[636]) & locals[773] >> 1) ^ locals[636];
        locals[462] = (~((locals[304] ^ locals[397]) & locals[331]) ^ locals[304] ^ locals[397]) & locals[378] ^
                      (~(locals[378] & (locals[304] ^ locals[397])) ^ locals[331]) & locals[776] ^ locals[304] ^
                      locals[331];
        locals[815] = locals[259] ^ locals[253];
        locals[720] = ~((~locals[259] ^ locals[253]) & locals[260]);
        locals[813] = ((~locals[259] ^ locals[253]) & locals[759] ^ locals[259] ^ locals[253] ^ locals[720]) &
                      locals[802] ^
                      (locals[259] ^ locals[253] ^ locals[720]) & locals[759] ^ locals[259] ^ locals[815] & locals[260];
        locals[683] = ~((~((~locals[710] ^ locals[260]) & locals[253]) ^ (~locals[260] ^ locals[759]) & locals[802] ^
                         (locals[710] ^ locals[759]) & locals[260] ^ locals[710] ^ locals[759]) & locals[259]) ^
                      (locals[253] & locals[710] ^ locals[759] & locals[802]) & locals[260] ^ locals[253];
        locals[811] = ((locals[397] ^ locals[796] ^ locals[331]) & locals[378] ^
                       (locals[378] ^ locals[796] ^ locals[331]) & locals[304] ^
                       locals[331]) & locals[776] ^
                      (~((locals[304] ^ locals[331]) & locals[397]) ^ locals[304] & ~locals[331]) & locals[378] ^
                      (locals[378] ^ locals[304]) & locals[796] & locals[331] ^ locals[304];
        locals[260] = ((locals[260] ^ locals[759]) & locals[815] ^ locals[259] ^ locals[253]) & locals[802] ^
                      (locals[259] ^ locals[253] ^ locals[815] & locals[260]) & locals[759] ^
                      locals[815] & locals[710] ^ locals[253] ^
                      locals[260];
        locals[815] = (locals[749] ^ locals[800]) >> 1;
        locals[720] = ~locals[816] & locals[773] >> 1 ^ locals[800] >> 1;
        locals[816] = locals[720] & (locals[815] ^ locals[636]);
        locals[812] = (~locals[749] & locals[800] ^ ~locals[816] ^ locals[815] ^ ~locals[815] & locals[636]) &
                      locals[773] ^
                      (locals[815] ^ ~locals[815] & locals[636] ^ locals[816] ^ locals[749]) & locals[800] ^
                      locals[815] ^ locals[636];
        locals[301] =
            ((locals[661] ^ locals[623] ^ locals[782] ^ locals[779]) & locals[794] ^ locals[782] & locals[779]) &
            locals[640] ^
            ~(~locals[794] & locals[782]) & locals[779] ^ locals[661];
        locals[802] = ((locals[720] ^ locals[815] ^ locals[749] ^ locals[800]) & locals[773] ^
                       (~locals[720] ^ locals[815]) & locals[800] ^
                       locals[815] ^ locals[749]) & locals[636] ^
                      ((locals[720] ^ locals[749] ^ locals[800]) & locals[773] ^ ~locals[720] & locals[800] ^
                       locals[749]) & locals[815] ^
                      (~(~locals[800] & locals[773]) ^ locals[800]) & locals[749] ^ locals[800] ^ locals[773];
        locals[816] = ~locals[797];
        locals[799] = (~((locals[797] ^ locals[787] ^ locals[331] ^ locals[776]) & locals[796]) ^
                       (locals[787] ^ locals[816] ^ locals[776]) & locals[331]) & locals[761] ^
                      ((locals[816] ^ locals[331] ^ locals[776]) & locals[796] ^
                       (locals[797] ^ locals[776]) & locals[331]) & locals[787] ^
                      locals[796];
        locals[793] = ~((~((locals[782] ^ locals[779]) & locals[661]) ^ ~locals[779] & locals[782]) & locals[794]) ^
                      ~((~locals[661] ^ locals[779]) & locals[623]) & locals[640] ^
                      ~((locals[640] ^ locals[782]) & locals[779]) & locals[661]
                      ^ locals[779];
        locals[773] = (~((locals[749] ^ locals[800]) & locals[773]) ^ locals[720] ^ locals[749] ^ locals[800]) &
                      (locals[815] ^ locals[636]) ^
                      locals[800] ^ locals[773];
        locals[794] = ~((~((locals[623] ^ locals[794] ^ locals[779]) & locals[661]) ^
                         (locals[623] ^ locals[782] ^ locals[779]) & locals[794]
                         ^ (~locals[623] ^ locals[782]) & locals[779]) & locals[640]) ^
                      ((~locals[782] ^ locals[779]) & locals[794] ^ locals[782] & locals[779]) & locals[661] ^
                      locals[794];
        locals[782] = ((locals[773] ^ locals[802]) & (locals[682] ^ locals[697]) ^ locals[682] ^ locals[697]) &
                      locals[812] ^
                      ((locals[682] ^ locals[697]) & locals[773] ^ locals[682] ^ locals[697]) & locals[802] ^
                      locals[224] & locals[697] & ~locals[682];
        locals[802] = ~((locals[224] ^ locals[682]) & locals[697]) ^ (~locals[773] ^ locals[802]) & locals[812] ^
                      ~locals[773] & locals[802];
        locals[697] = locals[697] ^ ~locals[682];
        locals[815] = (locals[796] ^ locals[331]) & locals[776];
        locals[772] = ((locals[797] ^ locals[331]) & locals[796] ^ locals[787] & (locals[797] ^ locals[796]) ^
                       locals[797] ^ locals[815] ^
                       locals[331]) & locals[761] ^
                      (locals[787] & locals[816] ^ ~locals[331] & locals[776]) & locals[796] ^ locals[787] ^
                      locals[331];
        locals[720] = ~locals[802] ^ locals[697];
        locals[636] = (locals[782] ^ locals[683] ^ locals[813]) & locals[697];
        locals[785] = (~(locals[720] & locals[683]) ^ locals[720] & locals[813] ^ locals[802] ^ locals[697]) &
                      locals[260] ^
                      ((~locals[683] ^ locals[813]) & locals[782] ^ locals[636] ^ locals[683] ^ locals[813]) &
                      locals[802] ^
                      (~locals[697] ^ locals[683] ^ locals[813]) & locals[782] ^ locals[697] ^ locals[683];
        locals[779] = ~locals[782] ^ locals[697];
        locals[704] = ((locals[802] ^ locals[683]) & locals[260] ^ locals[779] & locals[802] ^ locals[782] ^
                       locals[697] ^ locals[683]) &
            locals[813] ^ (~(~locals[683] & locals[260]) ^ locals[683]) & locals[802] ^ locals[697] ^ locals[683];
        locals[683] = ~(((locals[802] ^ locals[697]) & (locals[683] ^ locals[813]) ^ locals[802] ^ locals[697]) &
                        locals[260]) ^
                      ((locals[683] ^ locals[813]) & locals[782] ^ locals[636] ^ locals[813]) & locals[802] ^
                      (locals[779] ^ locals[683]) & locals[813] ^ (locals[697] ^ locals[683]) & locals[782] ^
                      locals[697] ^ locals[683];
        locals[636] = locals[782] ^ locals[697];
        locals[749] = ~(((locals[636] & locals[802] ^ locals[782]) & locals[704] ^ locals[683] ^ locals[782]) &
                        locals[785]) ^
                      (locals[636] & locals[802] ^ locals[683]) & locals[704] ^ locals[683] ^ locals[782];
        locals[779] = ~locals[704] ^ locals[785];
        locals[800] =
            ((~(locals[779] & locals[782]) ^ locals[785]) & locals[683] ^ (~locals[785] ^ locals[782]) & locals[704]) &
            locals[802]
            & locals[697] ^
            (~((~((locals[785] ^ locals[683]) & locals[802]) ^ locals[785] ^ locals[683]) & locals[782]) ^
             locals[683]) &
            locals[704] ^ (~locals[683] ^ locals[782]) & locals[785] ^ locals[683] ^ locals[782];
        locals[813] = locals[704] ^ locals[785];
        locals[781] = ~(((locals[779] & locals[782] ^ locals[704]) & locals[683] ^ ~locals[782] & locals[704]) &
                        locals[802] & locals[697]) ^
                      ((~(~locals[785] & locals[802]) ^ locals[785]) & locals[782] ^ locals[704] ^ locals[785]) &
                      locals[683] ^
                      locals[813] & locals[782];
        locals[812] = ~((locals[781] ^ locals[800]) & locals[749]);
        locals[260] =
            ~(((locals[781] ^ locals[794]) & locals[800] ^ (locals[800] ^ locals[794]) & locals[793] ^ locals[812]) &
              locals[301]) ^
            (~locals[781] & locals[749] ^ ~locals[794] & locals[793] ^ locals[781] ^ locals[794]) & locals[800] ^
            locals[794];
        locals[787] = (~((locals[797] ^ locals[796]) & locals[331]) ^ locals[761] & (locals[797] ^ locals[331]) ^
                       locals[797] ^ locals[815] ^
                       locals[796]) & locals[787] ^
                      (~(locals[761] & locals[816]) ^ ~locals[796] & locals[776]) & locals[331] ^ locals[761] ^
                      locals[796];
        locals[797] = (~((locals[794] ^ locals[301]) & locals[781]) ^ locals[794] ^ locals[301]) & locals[800] ^
                      ~((locals[794] ^ locals[301]) & (locals[781] ^ locals[800]) & locals[749]) ^ locals[794];
        locals[794] =
            ~(((~locals[800] ^ locals[794]) & locals[793] ^ (~locals[781] ^ locals[794]) & locals[800] ^ locals[812]) &
              locals[301])
            ^ (~(~locals[794] & locals[800]) ^ locals[794]) & locals[793] ^ ~locals[800] & locals[781] & locals[749] ^
            locals[794];
        locals[816] = (locals[811] ^ locals[462]) &
                      (((locals[796] ^ locals[331]) & (~locals[378] ^ locals[304]) ^ locals[378] ^ locals[304]) &
                       locals[776] ^
                       ((~locals[378] ^ locals[304]) & locals[796] ^ locals[378] ^ locals[304]) & locals[331] ^
                       ~locals[397] & locals[378] & locals[304]);
        locals[811] = locals[811] & locals[462];
        locals[815] = locals[811] ^ locals[816];
        locals[462] = locals[794] ^ locals[797];
        locals[812] = locals[462] & locals[260];
        locals[301] = locals[797] ^ 0x55555555;
        locals[749] = (locals[797] ^ 0xaaaaaaaa) & locals[794];
        locals[331] = (locals[797] & 0x55555555 ^ locals[301] & locals[794] ^ 0xaaaaaaaa) & locals[260] ^
                      (locals[812] ^ locals[797] ^ 0x55555555) & locals[815] ^ locals[749] ^ locals[797] & 0x55555555 ^
                      0xaaaaaaaa
            ;
        locals[800] = ((~locals[794] ^ locals[797]) & locals[260] ^ locals[794] ^ locals[797] ^ 0xaaaaaaaa) &
                      locals[815] ^
                      (locals[797] & 0xaaaaaaaa ^ locals[749]) & locals[260] ^
                      (locals[794] ^ 0xaaaaaaaa) & locals[797] ^
                      0x55555555;
        locals[815] = ~locals[797];
        locals[796] = (~((~((locals[462] & locals[704] ^ locals[794] ^ locals[797]) & locals[260]) ^
                          locals[815] & locals[704] ^ locals[797])
                         & locals[683]) ^ (~locals[812] ^ locals[797]) & locals[704] ^ locals[794] ^ locals[797]) &
                      locals[785] ^
                      (locals[812] ^ locals[794]) & locals[683] ^ locals[794] ^ locals[797];
        locals[816] = (locals[794] & locals[797] ^ 0x55555555) & locals[260] ^ locals[301] & locals[794] ^ locals[811] ^
                      locals[816];
        locals[749] = locals[816] ^ 0x55555555;
        locals[462] = locals[462] & locals[785];
        locals[793] = ~((~((locals[779] & locals[797] ^ locals[704] ^ locals[785]) & locals[794]) ^
                         locals[813] & locals[797] ^ locals[704] ^
                         locals[785]) & locals[683]) ^ (~(locals[815] & locals[794]) ^ locals[797]) & locals[704] ^
                      locals[462] ^ locals[794] ^
                      locals[797];
        locals[811] = (locals[462] ^ locals[794] ^ locals[797]) & locals[260];
        locals[462] = ~(((~((~locals[794] ^ locals[704]) & locals[797]) ^ locals[794] ^ locals[704]) & locals[785] ^
                         (locals[815] & locals[704] ^ locals[797]) & locals[794] ^ ~(locals[811] & locals[704])) &
                        locals[683]) ^
                      ((locals[794] ^ locals[785]) & locals[797] ^ locals[811] ^ locals[794] ^ locals[785]) &
                      locals[704] ^ locals[462];
        locals[811] = (locals[813] ^ 0xaaaaaaaa) & locals[683];
        locals[811] = ((locals[815] & 0x55555555 ^ locals[811] ^ locals[704]) & locals[794] ^
                       (locals[811] ^ locals[704]) & locals[797]) &
                      locals[260] ^ (locals[301] & locals[813] ^ locals[797] & 0xaaaaaaaa ^ 0x55555555) & locals[683] ^
                      locals[301] & locals[704] ^ 0x55555555;
        locals[813] = ~locals[800] & locals[749];
        locals[301] = (~locals[813] & 0xffff ^ locals[800]) & locals[331] ^ (locals[816] ^ 0x5555aaaa) & locals[800] ^
                      locals[749];
        locals[812] = ((~locals[704] & locals[683] ^ locals[704]) & 0x55555555 ^ 0xaaaaaaaa) & locals[797] ^
                      ~(locals[815] & locals[785] & locals[683]) & 0x55555555 ^ locals[812];
        locals[761] = locals[813] & locals[331] & 0xffff;
        locals[815] = locals[761] >> 1;
        locals[813] = ((~(locals[800] & locals[331]) ^ locals[813]) & 0xffff) >> 1;
        locals[781] = ~(~locals[815] & locals[301] >> 1 & locals[813]) ^ ~locals[813] & locals[815];
        locals[816] = ((locals[260] ^ 0xaaaaaaaa) & locals[797] ^ 0xaaaaaaaa) & locals[704];
        locals[816] = (~(((locals[260] ^ 0xaaaaaaaa) & locals[785] ^ locals[260] ^ 0xaaaaaaaa) & locals[797]) ^
                       locals[816] ^
                       locals[785]) & locals[683] ^ (locals[779] & locals[683] ^ locals[704] ^ 0x55555555) &
                      locals[794] & locals[260] ^
                      ~locals[260] & locals[797] & 0x55555555 ^ locals[816];
        locals[779] = (locals[761] ^ locals[301]) >> 1;
        locals[813] = ~(~(~(locals[301] >> 1) & locals[813]) & locals[815]) ^ locals[813];
        locals[301] = locals[301] >> 0x11 ^ 0xffffffff;
        locals[815] = locals[796] ^ locals[793];
        locals[704] =
            (locals[782] & locals[697] ^ locals[796] & locals[793] ^ locals[815] & locals[462]) & locals[802] ^
            (~(locals[815] & locals[462]) ^ locals[796] & locals[793] ^ locals[782]) & locals[697] ^ locals[782];
        locals[785] = ~(locals[815] & locals[462] & locals[636]) ^ locals[796] & locals[793] & locals[636] ^
                      locals[802] ^ locals[782];
        locals[782] = (locals[815] & (locals[802] ^ locals[697]) ^ locals[796] ^ locals[793]) & locals[462] ^
                      ~(locals[802] & locals[782]) & locals[697] ^ locals[796] & locals[793] & locals[720] ^
                      locals[782];
        locals[815] = ~locals[800] ^ locals[331];
        locals[720] = ~(locals[815] & locals[785]);
        locals[636] = ~locals[785];
        locals[796] = (~((locals[636] ^ locals[704]) & locals[331]) ^ locals[785] ^ locals[704]) & locals[800] ^
                      (locals[815] & locals[704] ^ locals[720] ^ locals[800] ^ locals[331]) & locals[749] ^
                      (~(locals[636] & locals[704]) ^ locals[785]) & locals[782] ^ locals[785] ^ locals[704];
        locals[636] = ~((~((~((locals[720] ^ locals[800] ^ locals[331]) & locals[704]) ^ locals[815] & locals[785] ^
                            locals[800] ^ locals[331]
                          ) & locals[782]) ^ locals[800] ^ locals[331]) & locals[749]) ^
                      (~((~((~(~locals[331] & locals[785]) ^ locals[331]) & locals[704]) ^ ~locals[331] & locals[785] ^
                          locals[331]) &
                         locals[782]) ^ locals[331]) & locals[800] ^ (locals[636] ^ locals[782]) & locals[704] ^
                      locals[782];
        locals[749] = (~(locals[815] & locals[782]) ^ locals[800] ^ locals[331]) & locals[749];
        locals[800] = (~(~locals[782] & locals[331]) ^ locals[782]) & locals[800];
        locals[704] =
            ~(((~locals[749] ^ locals[800] ^ locals[782]) & locals[704] ^ locals[800] ^ locals[749] ^ locals[782]) &
              locals[785]) ^
            locals[704];
        locals[749] = (~locals[636] ^ locals[796]) & locals[704] ^ (~locals[811] ^ locals[812]) & locals[816] ^
                      ~locals[811] & locals[812] ^
                      locals[796];
        locals[815] = ~locals[749];
        locals[462] = ~(locals[815] & locals[478]) ^ locals[749] & 0xffff;
        locals[478] = locals[749] & locals[478];
        locals[800] = (locals[749] ^ locals[478]) >> 1;
        locals[331] = ~(~(locals[462] << 0xf) & locals[749] << 0xf) ^ ~(locals[749] << 0xf) & locals[478] << 0xf;
        locals[720] = ((~locals[704] ^ locals[636]) & locals[749] ^ locals[704]) & locals[796];
        locals[802] = (locals[815] ^ locals[704]) & locals[636] ^ locals[720] ^ locals[749];
        locals[776] = (locals[815] ^ locals[636]) & locals[704] ^ locals[720] ^ locals[636];
        locals[796] = ~(~locals[636] & locals[704]) ^ locals[749] ^ locals[796];
        locals[793] = (locals[478] ^ locals[462]) << 0xf;
        locals[636] = (~(~locals[776] & locals[796] & 0xffff) ^ locals[776] & 0xffff) & locals[802];
        locals[785] = locals[636] ^ 0xffff0000;
        locals[782] = (locals[776] & 0xffff ^ 0xffff0000) & locals[802] & locals[796];
        locals[720] = ~locals[776] & locals[802];
        locals[704] = (~(locals[815] & locals[776]) ^ locals[802] ^ locals[749]) & locals[796] ^ locals[720] ^
                      locals[776];
        locals[797] = ((~locals[720] ^ locals[776]) & locals[749] ^ locals[776] ^ locals[802]) & locals[796] ^
                      ~locals[802] & locals[776];
        locals[761] =
            (~((~(~locals[802] & locals[796]) ^ locals[802]) & locals[776]) ^ locals[802] ^ locals[796]) & locals[749] ^
            locals[776]
            ^ locals[796];
        locals[683] =
            ((locals[816] ^ locals[812]) & (locals[797] ^ locals[704]) ^ locals[797] ^ locals[704]) & locals[811] ^
            locals[797] ^
            locals[812];
        locals[815] = ~locals[704];
        locals[260] = ((~locals[816] ^ locals[812]) & locals[811] ^ (locals[704] ^ locals[812]) & locals[761] ^
                       locals[704] ^ locals[812]) &
                      locals[797] ^
                      (locals[816] & locals[811] ^ locals[815] & locals[761] ^ locals[704]) & locals[812] ^
                      locals[704];
        locals[776] = (~(locals[796] & 0xffff) ^ locals[776]) & locals[802] ^ locals[776];
        locals[802] = (locals[782] ^ locals[785]) << 0x10;
        locals[720] = (locals[478] & locals[749] ^ locals[749] ^ locals[478]) >> 1 &
                      (~((locals[749] ^ locals[462]) >> 1) & locals[478] >> 1 ^ ~(locals[462] >> 1) & locals[749] >> 1);
        locals[749] = (~locals[782] ^ locals[785]) & locals[776] ^ ~locals[720] ^ locals[782] ^ locals[785] ^
                      locals[800];
        locals[812] = (~((~locals[797] ^ locals[812]) & locals[816]) ^ ~locals[812] & locals[797] ^ locals[812]) &
                      locals[811] ^
                      (~((locals[815] ^ locals[812]) & locals[797]) ^ locals[815] & locals[812] ^ locals[704]) &
                      locals[761] ^ locals[704] ^
                      locals[812];
        locals[811] = (locals[782] & locals[785] ^ locals[800] ^ locals[720]) & locals[776] ^
                      (locals[785] ^ locals[800] ^ locals[720]) & locals[782];
        locals[636] = locals[636] << 0x10;
        locals[816] = ~locals[636];
        locals[720] = ~(locals[776] << 0x10) & locals[782] << 0x10 & locals[816];
        locals[704] = locals[478] << 0xf & ~(locals[462] << 0xf);
        locals[636] = ~(locals[782] << 0x10) & locals[636] ^ locals[816] & locals[776] << 0x10 ^ 0xffff;
        locals[462] =
            ((locals[636] ^ locals[331] ^ locals[704] ^ locals[720]) & locals[802] ^ locals[636] ^ locals[331]) &
            locals[793] ^
            (~locals[636] ^ locals[331]) & locals[802] ^ locals[704] ^ locals[636] ^ locals[331];
        locals[782] = ~locals[776] ^ locals[782];
        locals[816] = ~locals[683];
        locals[800] = (locals[260] ^ locals[816]) & locals[812] ^ locals[683];
        locals[815] = (locals[720] ^ locals[636]) & locals[802];
        locals[796] = (locals[704] & locals[331] ^ ~locals[815] ^ locals[636]) & locals[793] ^
                      (locals[636] ^ locals[331] ^ locals[815]) & locals[704] ^ locals[802];
        locals[704] = ((~locals[704] ^ locals[720] ^ locals[636] ^ locals[331]) & locals[802] ^ locals[636]) &
                      locals[793] ^
                      (locals[331] ^ locals[704] ^ locals[720]) & locals[802] ^ locals[704];
        locals[720] = ~(((locals[812] ^ locals[816]) & 0xffff ^ locals[816]) & locals[260]);
        locals[636] = ~(~locals[260] & locals[683] & 0xffff0000);
        locals[816] = (locals[636] ^ locals[720] ^ (locals[812] & locals[816] ^ locals[683]) & 0xffff) & locals[800];
        locals[815] = (locals[636] ^ locals[816]) & locals[781];
        locals[812] = (~locals[813] & locals[781] ^ locals[636] ^ ~locals[816]) & locals[779] ^ locals[636] ^
                      locals[813] ^ locals[815] ^
                      locals[816];
        locals[331] = ~(locals[720] >> 0x10) & locals[636] >> 0x10 ^ locals[800] >> 0x10;
        locals[785] = ~((locals[636] ^ locals[800]) >> 0x10) & locals[720] >> 0x10 ^ locals[800] >> 0x10;
        locals[802] = (locals[779] & locals[781] ^ locals[636] ^ locals[816]) & locals[813] ^
                      (locals[636] ^ locals[779] ^ ~locals[816]) & locals[781] ^ locals[779];
        locals[815] = (~locals[781] & locals[813] ^ locals[636] ^ locals[781] ^ locals[816]) & locals[779] ^
                      locals[813] ^ locals[815];
        locals[779] = ~((locals[800] & locals[720]) >> 0x10) ^ locals[636] >> 0x10;
        locals[816] = locals[796] ^ ~locals[802];
        locals[720] = (~locals[812] ^ locals[462]) & locals[802];
        locals[720] = (locals[462] & locals[816] ^ locals[802] ^ locals[796]) & locals[704] ^
                      ~(locals[815] & locals[816]) & locals[812] ^
                      (locals[812] ^ locals[462] ^ locals[720]) & locals[796] ^ locals[462] ^ locals[720];
        locals[816] = ~locals[779];
        locals[813] = ~((~((locals[779] ^ 0x7fff) & locals[331]) ^ locals[816] & 0x7fff) & locals[785]) ^
                      (~((locals[779] ^ locals[301]) & 0x7fff) ^ locals[779] ^ locals[301]) & locals[331] ^ 0x7fff ^
                      locals[301];
        locals[636] = locals[815] ^ ~locals[802];
        locals[793] = ((locals[802] ^ locals[796]) & locals[462] ^ locals[812] & locals[636]) & locals[704] ^
                      (~(~locals[796] & locals[462]) ^ locals[815] & locals[812]) & locals[802] ^ locals[796];
        locals[815] = (locals[779] ^ locals[331] ^ 0x7fff) & locals[785];
        locals[462] = ~((locals[331] & locals[816] ^ locals[815]) & locals[301]) ^
                      (~locals[331] & locals[779] ^ 0x7fff) & locals[785] ^
                      locals[331] ^ 0x7fff;
        locals[785] = ((locals[331] ^ locals[816]) & locals[785] ^ locals[779] & locals[331]) & 0x7fff ^
                      ((locals[816] ^ 0x7fff) & locals[331] ^ ~locals[815]) & locals[301] ^ locals[785];
        locals[704] = (locals[704] ^ locals[796]) & locals[812] & locals[636] ^ locals[802] ^ locals[704];
        locals[816] = (locals[813] ^ locals[462]) & locals[785];
        locals[815] = ~locals[462] & locals[813];
        locals[812] = ~((~locals[816] ^ locals[782] ^ locals[815]) & locals[811]) ^
                      (locals[815] ^ locals[816]) & locals[782] ^ locals[785] ^
                      locals[749];
        locals[816] = ~locals[704];
        locals[636] = locals[720] & locals[816];
        locals[331] = ((locals[720] & 0xf3fff3ff ^ locals[816]) & locals[793] ^ locals[636] ^ 0xf3fff3ff) & 0x3c003c00;
        locals[802] = ((locals[793] ^ 0xfff3fff3) & locals[720] ^ 0xc000c) & locals[704] & 0xc00cc00c;
        locals[779] = locals[462] ^ locals[782] ^ locals[811] ^ ~locals[813];
        locals[796] = ((locals[782] ^ locals[811] ^ ~locals[813]) & locals[462] ^
                       (locals[782] ^ locals[811]) & locals[813] ^
                       ~(locals[749] & locals[779]) ^ locals[782]) & locals[785] ^
                      ((locals[811] ^ locals[782] ^ locals[749]) & locals[462] ^ locals[782] ^ locals[749] ^
                       locals[811]) & locals[813] ^
                      locals[811] & (locals[782] ^ locals[749]) ^ locals[782];
        locals[797] =
            (((locals[704] ^ 0xffcfffcf) & locals[720] ^ 0xffcfffcf) & locals[793] ^ locals[636] & 0xffcfffcf) &
            0xf000f0 ^ ~(locals[704] & 0x300030) & 0xff3fff3f;
        locals[761] = ((~(locals[704] & 0xfff3fff3) & locals[720] ^ locals[816]) & locals[793] ^
                       ~(locals[704] & 0xc000c) & locals[720]) & 0xc00cc00c ^ 0x3ff33ff3;
        locals[301] = (((locals[704] ^ 0x300030) & locals[720] ^ locals[816]) & locals[793] ^ locals[636] & 0x300030) &
                      0xf000f0 ^
                      0xffcfffcf;
        locals[683] = ((locals[704] ^ 0xfff3fff3) & locals[720] ^ locals[816] & 0xfff3fff3) & locals[793] & 0xc00cc00c ^
                      0x3fff3fff;
        locals[781] = ~(locals[802] << 8) & locals[761] << 8;
        locals[260] = ~(locals[720] & locals[793]) & 0xc000c00;
        locals[776] = (locals[720] ^ locals[793]) & 0xc000c00;
        locals[773] = (locals[704] & locals[720] & 0x300030 ^ 0xc000c0) & locals[793];
        locals[815] = ~((~(locals[785] & locals[779]) ^ locals[811] ^ locals[815]) & locals[749]) ^
                      (~locals[815] ^ locals[811]) & locals[785]
                      ^ locals[782] ^ locals[815];
        locals[779] = ~locals[812];
        locals[813] = locals[815] & locals[779];
        locals[785] = ~((~(locals[812] & 0xfffcfffc) ^ locals[813]) & locals[796] & 0x330033);
        locals[782] = (locals[796] ^ locals[812]) & locals[815] & 0xc000c000;
        locals[794] = ~locals[782];
        locals[811] = (locals[802] ^ locals[761]) << 8;
        locals[749] = locals[761] >> 4;
        locals[462] = locals[802] >> 4;
        locals[800] = locals[683] >> 4;
        locals[764] = (~locals[749] & locals[462] ^ locals[749]) & locals[800] ^ locals[462];
        locals[816] = ~((locals[720] ^ locals[816]) & locals[793]);
        locals[793] = ((locals[704] ^ 0x30003) & locals[720] ^ (locals[704] ^ locals[816]) & 0x30003 ^ locals[704]) &
                      0x3030303;
        locals[704] = (locals[796] & locals[779] ^ locals[812]) & 0xc000c000;
        locals[759] = (locals[773] & locals[301] ^ locals[797]) << 4;
        locals[720] = (locals[815] ^ 0x30003) & locals[812];
        locals[774] = ((locals[720] ^ 0x30003) & locals[796] ^ locals[720]) & 0x330033;
        locals[749] = ~(~(~locals[462] & locals[749]) & locals[800]) ^ locals[749];
        locals[775] = ~locals[796] & locals[815] & locals[812] & 0x30003000 ^ locals[796] & 0xc000c0;
        locals[791] = ~(~(locals[773] << 4) & locals[301] << 4) ^ locals[797] << 4;
        locals[765] = ~(~(locals[301] << 4) & locals[797] << 4) ^ locals[773] << 4;
        locals[720] = locals[812] & 0xc000c;
        locals[766] = locals[796] & locals[813] & 0x3000300 ^ locals[720];
        locals[816] = locals[816] & 0x3000300;
        locals[301] = locals[301] >> 2;
        locals[768] = (~((locals[797] & locals[773]) >> 2) & locals[301] ^ ~(locals[797] >> 2)) & 0x3fffffff;
        locals[769] = locals[812] & 0x300030 ^ locals[796] & locals[813] & 0x30003;
        locals[462] = (locals[774] ^ locals[785]) << 6;
        locals[636] = locals[636] & 0x3000300;
        locals[779] = ((locals[815] ^ 0xff3fff3f) & locals[796] & locals[779] ^ locals[812] & 0xff3fff3f) & 0x30c030c0;
        locals[755] = ~(((locals[260] ^ locals[331]) & locals[776]) >> 10);
        locals[757] = ~((locals[802] ^ locals[761]) >> 4) & 0xfffffff;
        locals[802] = ((locals[774] ^ locals[785]) & locals[769] ^ locals[785]) << 2 ^ 3;
        locals[761] = locals[683] << 8 & ~locals[811];
        locals[683] = (locals[793] ^ locals[816]) << 2;
        locals[709] = ((locals[815] ^ 0xc000c0) & locals[796] ^ ~locals[815]) & locals[812] & 0x30c030c0;
        locals[748] = (locals[775] & locals[779] ^ locals[709]) << 8;
        locals[827] = (locals[785] & locals[769] ^ locals[774]) << 2;
        locals[800] = ((locals[813] & 0xc000c ^ ~locals[720]) & locals[796] ^ locals[720]) & 0x30c030c;
        locals[720] = ~(locals[773] >> 2);
        locals[788] = locals[720] ^ locals[301];
        locals[813] = (locals[709] ^ locals[779]) >> 6;
        locals[301] = ~(locals[720] & locals[301]) & locals[797] >> 2 ^ locals[773] >> 2;
        locals[797] = (locals[776] ^ locals[331]) >> 10;
        locals[773] = ~(locals[260] >> 10) & locals[331] >> 10 & locals[776] >> 10;
        locals[792] = ~(~(locals[775] << 8) & locals[779] << 8) ^ locals[709] << 8;
        locals[408] = ~(~(locals[779] << 8) & locals[709] << 8) ^ locals[775] << 8;
        locals[775] = ~(~(locals[775] >> 6) & locals[779] >> 6) ^ (locals[709] & locals[775]) >> 6;
        locals[760] = (locals[636] ^ locals[816]) >> 6;
        locals[814] = locals[636] << 2 & ~locals[683];
        locals[699] = ~locals[814];
        locals[790] = ~(locals[793] << 2) & locals[816] << 2;
        locals[657] = locals[301] ^ locals[827];
        locals[770] = (locals[791] & (~locals[759] ^ locals[792]) ^ locals[759] ^ locals[792]) & locals[765] ^
                      ~((~locals[791] ^ locals[748]) & locals[792]) & locals[759] ^
                      ~((~locals[759] ^ locals[792]) & locals[748]) & locals[408] ^ locals[792];
        locals[750] = (locals[709] & locals[779]) >> 6;
        locals[720] = ~locals[750] ^ locals[773];
        locals[709] = (locals[720] & locals[813] ^ locals[750] ^ locals[773]) & locals[775] ^
                      (locals[813] ^ locals[755]) & locals[750] & locals[773] ^
                      locals[720] & locals[797] & locals[755] ^ locals[813];
        locals[771] = ((locals[812] & 0xc000c00 ^ ~(locals[815] & 0xc000c00)) & locals[796] ^
                       locals[812] & ~(locals[815] & 0xc000c00)) & 0xcc00cc00;
        locals[782] = ((locals[782] ^ locals[764]) & locals[749] ^ ~locals[764] & locals[794] ^ locals[764]) &
                      locals[757] ^
                      ((locals[749] ^ ~locals[704] ^ locals[771]) & locals[764] ^ locals[749] ^ locals[771]) &
                      locals[794] ^
                      (locals[749] ^ locals[771]) & locals[764] ^ locals[771];
        locals[753] = locals[774] << 6 & ~(locals[785] << 6);
        locals[812] = (locals[815] ^ 0xfff3fff3) & locals[812];
        locals[796] = ((locals[812] ^ 0xfff3fff3) & locals[796] ^ locals[812]) & 0x30c030c;
        locals[742] = (~locals[775] ^ locals[813]) & (locals[773] ^ locals[797]) & locals[755] ^
                      ~(locals[750] & locals[775]) & locals[813] ^
                      locals[750] ^ locals[773] ^ locals[775];
        locals[777] = ((locals[704] ^ locals[771]) & locals[794] ^ locals[771]) & (locals[749] ^ locals[757]) ^
                      locals[794] ^ locals[764];
        locals[636] = locals[636] >> 6;
        locals[778] = ~(~((locals[816] & locals[793]) >> 6) & locals[636]) ^ locals[793] >> 6;
        locals[815] = locals[792] ^ locals[408];
        locals[615] = (~(locals[815] & locals[748]) ^ locals[791] & locals[815] ^ locals[792] ^ locals[408]) &
                      locals[765] ^
                      ((locals[791] ^ locals[748]) & locals[815] ^ locals[792] ^ locals[408]) & locals[759] ^
                      locals[408];
        locals[815] = ~locals[750] ^ locals[775];
        locals[750] = ((locals[750] ^ locals[775] ^ locals[813] ^ locals[797]) & locals[773] ^
                       (locals[815] ^ locals[813]) & locals[797]) &
            locals[755] ^ ~(locals[815] & locals[813]) & locals[773] ^ locals[750];
        locals[797] = ((~locals[765] ^ locals[408]) & locals[748] ^ locals[765] ^ locals[408]) & locals[792] ^
                      ~(locals[791] & (~locals[765] ^ locals[408])) & locals[759] ^
                      locals[765] & (~locals[791] ^ locals[748]) & locals[408];
        locals[757] = ((locals[704] ^ locals[749] ^ locals[764] ^ locals[771]) & locals[757] ^
                       (locals[704] ^ locals[764] ^ locals[771]) & locals[749] ^
                       (~locals[704] ^ locals[771]) & locals[764] ^ locals[704]) &
                      locals[794] ^ (~(~locals[749] & locals[757]) ^ locals[749]) & locals[764] ^
                      (locals[749] ^ locals[764] ^ locals[757]) & locals[771] ^ locals[749] ^ locals[757];
        locals[815] = locals[777] ^ locals[782];
        locals[773] = (locals[815] & locals[709] ^ ~(locals[815] & locals[750]) ^ locals[777] ^ locals[782]) &
                      locals[742] ^
                      (~(locals[815] & locals[750]) ^ locals[777] ^ locals[782]) & locals[709] ^
                      locals[815] & locals[757];
        locals[815] = locals[757] & locals[777] ^ (locals[757] ^ locals[777]) & locals[782] ^ locals[750];
        locals[813] = ~(locals[815] & locals[742]) ^ locals[815] & locals[709] ^ locals[777] ^ locals[782];
        locals[815] = locals[800] << 0xc;
        locals[755] = ~(locals[796] << 0xc) ^ locals[815];
        locals[812] = locals[766] >> 2;
        locals[749] = locals[796] >> 2;
        locals[800] = locals[800] >> 2;
        locals[764] = ~((~locals[812] & locals[749] ^ locals[812]) & locals[800]) ^ locals[749];
        locals[759] = ~(locals[769] << 6 & ~locals[462]) ^ locals[785] << 6;
        locals[815] = ~locals[815];
        locals[775] = ~(locals[766] << 0xc) & locals[815] & locals[796] << 0xc;
        locals[720] = ~((~(locals[785] << 2) & locals[769] << 2 ^ ~(locals[774] << 2)) & 0xfffffffc) ^ locals[802];
        locals[785] = (locals[301] ^ locals[768]) & locals[788] ^ locals[301] & locals[768] ^
                      locals[720] & locals[827] ^ locals[802];
        locals[779] = locals[757] ^ locals[777] ^ locals[750];
        locals[782] = ~((~((locals[779] ^ locals[709]) & locals[782]) ^
                         (locals[757] ^ locals[750] ^ locals[709]) & locals[777] ^ locals[709])
                        & locals[742]) ^ (locals[779] & locals[709] ^ locals[777]) & locals[782] ^
                      ~((locals[757] ^ locals[750]) & locals[777]) & locals[709];
        locals[779] = (locals[813] ^ 0x44444444) & locals[773];
        locals[774] = ((locals[779] ^ 0xbbbbbbbb) & locals[782] ^ locals[779]) & 0xcccccccc;
        locals[791] = (locals[794] ^ locals[771]) << 4;
        locals[779] = ((~locals[301] ^ locals[827]) & locals[768] ^ locals[301] & locals[827]) & locals[788] ^
                      ((locals[720] ^ locals[768]) & locals[301] ^ locals[802]) & locals[827] ^
                      ~locals[301] & locals[802];
        locals[720] = (locals[753] ^ locals[462]) & locals[759];
        locals[768] = (~locals[720] ^ locals[462]) & locals[683] ^ (locals[720] ^ locals[462]) & locals[790] ^
                      locals[759];
        locals[749] = ~(~locals[749] & locals[812]) & locals[800] ^ locals[749];
        locals[815] = (locals[766] ^ locals[796]) << 0xc & locals[815];
        locals[812] = ~locals[815] ^ locals[775];
        locals[800] = ~((~((locals[753] ^ locals[699] ^ locals[462]) & locals[683]) ^
                         (locals[699] ^ locals[683]) & locals[790] ^ locals[753]
                         ^ locals[699]) & locals[759]) ^ (locals[814] & locals[790] ^ locals[462]) & locals[683] ^
                      locals[790];
        locals[720] = ~(locals[771] << 4);
        locals[301] = (~(locals[704] << 4) & locals[794] << 4 ^ locals[720]) & 0xfffffff0;
        locals[802] = (~((~locals[779] ^ locals[785] ^ locals[770]) & locals[657]) ^
                       (locals[770] ^ locals[657]) & locals[615] ^ locals[779] ^
                       locals[785]) & locals[797] ^ ~locals[657] & locals[615] & locals[770] ^
                      (locals[779] ^ locals[785]) & locals[657] ^
                      locals[779];
        locals[765] = ~((~((locals[779] ^ locals[785] ^ locals[770]) & locals[657]) ^
                         (~locals[770] ^ locals[657]) & locals[615] ^ locals[779]
                         ^ locals[770]) & locals[797]) ^ (locals[615] & locals[770] ^ locals[785]) & locals[657] ^
                      locals[785];
        locals[462] = (~((~locals[753] ^ locals[462]) & locals[759]) ^ locals[699] ^ locals[462]) & locals[790] ^
                      ~(((~locals[753] ^ locals[462]) & locals[683] ^ locals[753] ^ locals[462]) & locals[759]) ^
                      (locals[699] ^ locals[462]) & locals[683] ^ locals[699] ^ locals[462];
        locals[796] = (locals[766] ^ locals[796]) >> 2;
        locals[636] = ~(~locals[636] & locals[816] >> 6) & locals[793] >> 6 ^ locals[636];
        locals[793] = ~((~((~locals[636] ^ locals[764] ^ locals[760]) & locals[778]) ^ locals[636] ^ locals[764]) &
                        locals[749]) ^
                      (~locals[749] ^ locals[778]) & locals[796] & locals[764] ^
                      (locals[636] ^ locals[764]) & locals[778] ^ locals[636];
        locals[779] = ~locals[657] & locals[779];
        locals[657] = ~(((~locals[785] ^ locals[770]) & locals[615] ^ (~locals[770] ^ locals[657]) & locals[785] ^
                         locals[779] ^ locals[770] ^
                         locals[657]) & locals[797]) ^ (locals[779] ^ locals[615] & locals[770]) & locals[785] ^
                      locals[657];
        locals[813] = ~locals[773] & locals[813];
        locals[779] = ~((locals[813] & 0x44444444 ^ 0x88888888) & locals[782]) ^ locals[773] & 0x44444444;
        locals[794] = ~(locals[720] & locals[794] << 4) & locals[704] << 4 ^ locals[771] << 4;
        locals[785] = (~((locals[636] ^ locals[796] ^ locals[749] ^ locals[760]) & locals[764]) ^ locals[636]) &
                      locals[778] ^
                      ~locals[764] & locals[636] ^ locals[749];
        locals[704] = ((locals[781] ^ locals[761]) & (locals[815] ^ locals[775]) ^ locals[815] ^ locals[775]) &
                      locals[811] ^
                      (locals[781] & (locals[815] ^ locals[775]) ^ locals[815] ^ locals[775]) & locals[761] ^
                      ~locals[815] & locals[755] & locals[775];
        locals[759] = (locals[765] ^ locals[802]) & 0x44444444;
        locals[813] = (locals[773] & 0xbbbbbbbb ^ locals[813]) & locals[782] & 0xcccccccc;
        locals[749] = (~((locals[636] ^ locals[764] ^ locals[760]) & locals[778]) ^ locals[636] ^ locals[764]) &
                      locals[749] ^
                      ~((locals[749] ^ locals[778]) & locals[796]) & locals[764] ^ locals[778] & locals[760];
        locals[773] = ~(~(locals[779] >> 1) & locals[774] >> 1) & locals[813] >> 1 ^ (locals[774] & locals[779]) >> 1;
        locals[796] = ~((locals[301] ^ locals[791]) & (locals[331] ^ ~locals[776]) & locals[260]) ^
                      ~locals[301] & locals[794] & locals[791] ^
                      locals[776] ^ locals[301];
        locals[816] = ~(locals[813] >> 1);
        locals[720] = (~(locals[816] & locals[779] >> 1) & locals[774] >> 1 ^ locals[816]) & 0x7fffffff;
        locals[797] = (~((locals[260] ^ locals[301]) & locals[776]) ^ locals[260] ^ locals[301]) & locals[791] ^
                      ~((locals[301] & (locals[776] ^ locals[791]) ^ locals[776] ^ locals[791]) & locals[794]) ^
                      locals[260] & locals[331] & (locals[776] ^ locals[791]) ^ locals[301];
        locals[683] = (locals[813] ^ locals[779]) >> 1 ^ 0x80000000;
        locals[816] = ~locals[683];
        locals[782] = (~((locals[779] ^ locals[816]) & locals[773]) ^ locals[779] & locals[816] ^ locals[683]) &
                      locals[720] ^
                      ((locals[683] ^ locals[774]) & locals[779] ^ locals[774] & locals[816]) & locals[813] ^
                      ~(~locals[774] & locals[779]) & locals[683] ^ locals[773];
        locals[794] =
            (~((~locals[260] ^ locals[794] ^ locals[791]) & locals[776]) ^ locals[260] ^ locals[794] ^ locals[791]) &
            locals[301] ^
            ~((~locals[776] ^ locals[301]) & locals[331]) & locals[260] ^
            (locals[260] ^ locals[794] ^ locals[791]) & locals[776] ^
            locals[794];
        locals[301] =
            ~(((locals[794] ^ locals[796]) & (locals[785] ^ locals[793]) ^ locals[794] ^ locals[796]) & locals[749]) ^
            locals[796] ^
            locals[785];
        locals[331] = (~((locals[773] ^ locals[779]) & locals[720]) ^ locals[773] ^ locals[779]) & locals[683] ^
                      (~((locals[720] ^ locals[774]) & locals[773]) ^ locals[720] ^ locals[774]) & locals[779] ^
                      (locals[773] & (locals[779] ^ locals[774]) ^ ~locals[774] & locals[779]) & locals[813];
        locals[816] = locals[802] & 0x44444444;
        locals[260] = ~(((locals[816] ^ 0x88888888) & locals[765] ^ locals[816] ^ 0x88888888) & locals[657]) ^
                      ~locals[802] & locals[765] & 0xcccccccc;
        locals[720] = (locals[796] ^ ~locals[794]) & locals[797];
        locals[636] = (locals[749] ^ ~locals[794]) & locals[796];
        locals[636] = (~(locals[794] & ~locals[796]) ^ locals[796]) & locals[797] ^
                      ~((locals[785] ^ ~locals[796]) & locals[793]) & locals[749] ^
                      (locals[794] ^ locals[749] ^ locals[636] ^ locals[720]) & locals[785] ^ locals[636];
        locals[773] = (~(locals[774] & (locals[683] ^ locals[773])) ^ locals[683] ^ locals[773]) & locals[779] ^
                      locals[813] & (locals[683] ^ locals[773]) & (locals[779] ^ locals[774]) ^ locals[773];
        locals[794] = ((locals[794] ^ locals[749]) & locals[796] ^ locals[749] & locals[793] ^ ~locals[720]) &
                      locals[785] ^
                      (~locals[797] & locals[794] ^ ~locals[793] & locals[749]) & locals[796] ^ locals[794];
        locals[720] = (~locals[773] ^ locals[331]) & locals[782];
        locals[779] = ~locals[758];
        locals[749] = (~((locals[758] ^ locals[773]) & locals[331]) ^ (locals[758] ^ locals[331]) & locals[658] ^
                       locals[758] ^ locals[720]) &
            locals[102] ^ (~locals[782] & locals[773] ^ locals[658] & locals[779]) & locals[331] ^ locals[773];
        locals[755] = (locals[755] ^ locals[775]) & locals[815] ^ (locals[761] ^ ~locals[781]) & locals[811] ^
                      locals[761] & ~locals[781] ^
                      locals[755];
        locals[811] = ~(~locals[765] & ~locals[816] & locals[657] & 0xcccccccc) ^
                      ~locals[802] & locals[765] & 0x88888888;
        locals[802] = (locals[811] ^ locals[759]) >> 1;
        locals[816] = (locals[755] ^ locals[704]) & locals[812];
        locals[683] = (~locals[755] & locals[812] ^ locals[462] & locals[800]) & locals[704] ^
                      ~(((locals[800] ^ ~locals[704]) & locals[462] ^ locals[816]) & locals[768]);
        locals[815] = locals[301] & 0x44444444;
        locals[813] = ~locals[815] & locals[794];
        locals[796] = ((locals[813] ^ 0xbbbbbbbb) & locals[636] ^ locals[813] ^ locals[815]) & 0xcccccccc ^ 0x33333333;
        locals[812] = ~(~(locals[260] >> 1) & locals[811] >> 1) ^ ~(locals[759] >> 1) & locals[260] >> 1;
        locals[793] = ~(((locals[102] ^ locals[758]) & (locals[773] ^ locals[331]) ^ locals[773] ^ locals[331]) &
                        locals[658]) ^
                      ~(locals[758] & (locals[773] ^ locals[331])) & locals[102] ^ locals[331];
        locals[785] = ~(locals[759] >> 1) & locals[811] >> 1;
        locals[813] = locals[812] & (locals[785] ^ locals[802]);
        locals[797] = (~locals[260] & locals[811] ^ locals[785] ^ locals[813]) & locals[759] ^
                      (~locals[813] ^ locals[785]) & locals[260] ^
                      locals[812];
        locals[761] = (~((locals[811] ^ locals[260] ^ locals[785] ^ locals[802]) & locals[812]) ^ locals[785]) &
                      locals[759] ^
                      ~locals[812] & locals[785] ^ locals[260];
        locals[759] =
            ((~locals[785] ^ locals[802]) & locals[260] ^ (~locals[811] ^ locals[260]) & locals[759] ^ locals[802]) &
            locals[812] ^
            (locals[811] & locals[759] ^ locals[785]) & locals[260] ^ locals[759];
        locals[813] = ~locals[663] ^ locals[761] ^ locals[173];
        locals[812] = (locals[797] ^ locals[761] ^ locals[173]) & locals[759];
        locals[813] = (~((locals[797] ^ locals[813]) & locals[759]) ^ locals[797] & locals[813] ^ locals[663] ^
                       locals[761] ^ locals[173]) &
                      locals[48] ^
                      (locals[797] & (locals[761] ^ locals[173]) ^ ~locals[812] ^ locals[761] ^ locals[173]) &
                      locals[663] ^
                      locals[759];
        locals[816] = (locals[800] ^ locals[768]) & locals[462] ^ locals[816];
        locals[811] = (~((locals[773] ^ locals[779]) & locals[102]) ^ locals[773] & locals[779] ^ locals[758]) &
                      locals[658] ^
                      (~((locals[331] ^ locals[779]) & locals[773]) ^ locals[331] ^ locals[720]) & locals[102] ^
                      (~(~locals[331] & locals[773]) ^ locals[331]) & locals[782] ^ locals[773] & locals[331];
        locals[462] = (locals[636] & 0x88888888 ^ 0x44444444) & locals[301];
        locals[768] = locals[768] ^ ~locals[704];
        locals[800] = ((locals[815] ^ 0x88888888) & locals[636] ^ locals[815] ^ 0x88888888) & locals[794] ^
                      ((locals[636] ^ 0x44444444) & locals[301] ^ 0xbbbbbbbb) & 0xcccccccc;
        locals[815] = ~locals[761];
        locals[720] = ~locals[173];
        locals[301] =
            ((locals[759] ^ locals[173]) & locals[48] ^ locals[173] ^ ~locals[797] & locals[761] ^ locals[812]) &
            locals[663] ^
            (locals[720] & locals[48] ^ locals[797] & locals[815]) & locals[759] ^ locals[797] ^ locals[48];
        locals[636] = locals[800] >> 1;
        locals[779] = locals[796] >> 1;
        locals[812] = ~locals[636] & locals[779] & locals[462] >> 1 ^ ~locals[779] & locals[636] ^ 0x80000000;
        locals[331] = ~((locals[462] ^ locals[800]) >> 1) & 0x7fffffff;
        locals[802] = ((locals[797] ^ locals[720]) & locals[663] ^ (locals[797] ^ locals[815]) & locals[759] ^
                       (locals[173] ^ locals[815]) & locals[797] ^ locals[761]) & locals[48] ^
                      (locals[797] & locals[720] ^ locals[173]) & locals[663] ^
                      (locals[761] ^ locals[797] & locals[815]) & locals[759] ^
                      ~locals[797] & locals[761];
        locals[785] = (~(~(locals[683] & 0xbbbbbbbb) & locals[768]) & ~locals[816] ^
                       (locals[816] ^ 0xbbbbbbbb) & locals[683]) &
                      0xcccccccc;
        locals[779] = ~(~(locals[462] >> 1) & locals[779]) & locals[636] ^ locals[779];
        locals[815] = ~(locals[768] & ~locals[816]);
        locals[704] = locals[683] & 0x88888888 ^ locals[815] & 0x44444444;
        locals[797] = ~(((~locals[812] ^ locals[462]) & locals[779] ^ locals[812] ^ locals[462]) & locals[796]) ^
                      ~(locals[462] & (locals[779] ^ locals[796])) & locals[800] ^
                      locals[812] & locals[331] & (locals[779] ^ locals[796]) ^
                      locals[779] ^ locals[462];
        locals[720] = (locals[331] ^ ~locals[779]) & locals[812];
        locals[761] = ~((locals[800] & locals[796] ^ locals[720]) & locals[462]) ^
                      (locals[796] ^ locals[720]) & locals[800] ^ locals[779] ^
                      locals[796];
        locals[683] = (locals[816] & 0x44444444 ^ locals[815] & 0x88888888) & locals[683];
        locals[781] = ~locals[683];
        locals[816] = (~locals[800] ^ locals[796]) & locals[779];
        locals[816] = (~((locals[462] ^ locals[800] ^ locals[796] ^ ~locals[779]) & locals[331]) ^
                       (~locals[462] ^ locals[800] ^ locals[796]) & locals[779] ^ locals[462] ^ locals[800] ^
                       locals[796]) & locals[812] ^
                      (locals[800] ^ locals[796] ^ locals[816]) & locals[462] ^ locals[796] ^ locals[816];
        locals[779] = locals[781] >> 1;
        locals[815] = ~(locals[785] >> 1);
        locals[812] = locals[779] & locals[815];
        locals[462] = ~locals[812];
        locals[720] = (locals[797] ^ ~locals[816]) & locals[761];
        locals[636] = ~locals[720];
        locals[800] =
            (locals[483] & ~locals[789] ^ locals[789] ^ locals[816] & locals[797] ^ locals[720]) & locals[624] ^
            (locals[636] ^ locals[816] & locals[797]) & locals[789] ^ locals[816] ^ locals[483];
        locals[720] = (~(~(locals[704] >> 1) & locals[779]) ^ locals[704] >> 1 & locals[815]) & 0x7fffffff;
        locals[779] = ~locals[779] & locals[785] >> 1;
        locals[260] = ~(((locals[781] ^ locals[704]) & (locals[779] ^ locals[462]) ^ locals[779] ^ locals[462]) &
                        locals[720]) ^
                      ((locals[683] ^ locals[704]) & locals[462] ^ locals[781] ^ locals[704]) & locals[779] ^
                      locals[781];
        locals[815] = ~locals[779];
        locals[331] = ((locals[462] ^ locals[704]) & locals[779] ^ ~locals[704] & locals[462]) & locals[720] ^
                      ~((locals[812] ^ locals[785]) & locals[779]) & locals[704] ^
                      ~((locals[704] ^ locals[815]) & locals[785]) & locals[781];
        locals[462] = (locals[462] & locals[815] ^ locals[781] & (locals[779] ^ locals[462])) & locals[720] ^
                      ((locals[781] ^ locals[815]) & locals[785] ^ locals[779] ^ locals[781]) & locals[704] ^
                      ~((locals[462] ^ locals[785]) & locals[781]) & locals[779];
        locals[815] = ~locals[331];
        locals[779] = locals[462] & locals[815];
        locals[796] = (~((locals[238] ^ locals[331]) & locals[462]) ^ (locals[438] ^ locals[815]) & locals[238] ^
                       (locals[238] ^ locals[438]) & locals[140] ^ locals[438]) & locals[260] ^
                      (~(~locals[438] & locals[140]) ^ locals[331] ^ locals[779]) & locals[238] ^ locals[438];
        locals[785] = ~(((~locals[797] ^ locals[789]) & locals[816] ^ locals[789] ^ locals[636]) & locals[483]) ^
                      ~((locals[483] ^ ~locals[816]) & locals[789]) & locals[624] ^
                      (~(locals[816] & ~locals[797]) ^ locals[797]) & locals[761] ^ locals[816] & ~locals[789];
        locals[704] = ((locals[238] ^ locals[260]) & locals[438] ^ ~locals[260] & locals[238]) & locals[140] ^
                      ((locals[238] ^ locals[462] ^ locals[331]) & locals[260] ^ locals[331] ^ locals[779]) &
                      locals[438] ^
                      (~locals[779] ^ locals[331]) & locals[260] ^ locals[238] ^ locals[331] ^ locals[779];
        locals[720] = locals[797] ^ locals[624] ^ locals[483];
        locals[624] = ((locals[720] ^ locals[789]) & locals[816] ^
                       (locals[624] ^ locals[483] ^ locals[789]) & locals[797] ^ locals[624] ^
                       locals[483] ^ locals[789]) & locals[761] ^
                      ((~locals[624] ^ locals[483]) & locals[797] ^ ~(locals[720] & locals[789]) ^ locals[624] ^
                       locals[483]) & locals[816] ^
                      (locals[624] ^ locals[483]) & locals[789] ^ locals[624];
        locals[238] = ((locals[462] ^ locals[331] ^ ~locals[238]) & locals[260] ^
                       (locals[260] ^ ~locals[238]) & locals[140] ^ locals[331] ^
                       locals[779]) & locals[438] ^
                      (~locals[140] & locals[238] ^ locals[462] & locals[331]) & locals[260] ^ locals[238];
        locals[816] = ~locals[785];
        locals[812] = (locals[301] ^ locals[802]) & locals[813];
        locals[797] = (~((locals[301] ^ locals[816]) & locals[624]) ^ (locals[785] ^ locals[802]) & locals[301] ^
                       locals[802] ^ locals[812]) &
            locals[800] ^ (~locals[802] & locals[813] ^ ~(locals[785] & ~locals[624])) & locals[301];
        locals[761] = (~((locals[462] ^ locals[331] ^ locals[787]) & locals[260]) ^
                       (locals[260] ^ locals[787]) & locals[799] ^ locals[331] ^
                       locals[779]) & locals[772] ^
                      (~locals[787] & locals[799] ^ locals[462] & locals[331] ^ locals[787]) & locals[260] ^
                      locals[787];
        locals[683] = locals[796] & 0xaaaaaaaa ^ locals[704];
        locals[781] = (~locals[704] & locals[238] & 0xaaaaaaaa ^ locals[704]) & locals[796] ^ locals[704] & 0xaaaaaaaa;
        locals[799] = ((~locals[462] ^ locals[331]) & (locals[787] ^ locals[772]) ^ locals[462] ^ locals[331]) &
                      locals[260] ^
                      (~((~locals[787] ^ locals[772]) & locals[331]) ^ locals[787] ^ locals[772]) & locals[462] ^
                      (locals[815] ^ locals[787] ^ locals[799]) & locals[772] ^
                      (locals[331] ^ locals[799]) & locals[787] ^ locals[331] ^
                      locals[799];
        locals[779] = locals[260] & (locals[462] ^ locals[331]) ^ locals[331] ^ locals[779];
        locals[260] = (locals[779] ^ locals[787]) & locals[772] ^ locals[779] & locals[787] ^ locals[260];
        locals[462] = locals[800] ^ locals[301];
        locals[812] = ~locals[301] & locals[802] ^ locals[785] & ~locals[800] ^
                      locals[624] & (locals[785] ^ locals[800]) ^ locals[812];
        locals[301] = (locals[704] ^ 0xaaaaaaaa) & locals[796] ^ ~locals[704] & locals[238] ^ 0xaaaaaaaa;
        locals[776] = (((~((locals[816] ^ locals[462]) & locals[812]) ^ locals[785] ^ locals[462]) & locals[624] ^
                        (~(locals[816] & locals[812]) ^ locals[785]) & locals[462] ^ locals[812]) & locals[797] ^
                       (~((~(locals[816] & locals[462]) ^ locals[785]) & locals[624]) ^ locals[462]) & locals[812] ^
                       locals[462]) &
            locals[800] ^ ~(~((~(~locals[812] & locals[624]) ^ locals[812]) & locals[785]) & locals[462]) & locals[797];
        locals[815] = ~locals[797];
        locals[720] = (~((((locals[797] ^ locals[785]) & locals[624] ^ locals[797] & locals[816] ^ locals[785]) &
                          locals[462] ^
                          (~(locals[624] & locals[815]) ^ locals[797]) & locals[785]) & locals[812]) ^
                       locals[624] & locals[797] & locals[816]
                       ^ locals[462]) & locals[800] ^
                      (~((~(locals[815] & locals[462]) ^ locals[797]) & locals[624]) ^ locals[797] ^
                       locals[815] & locals[462]) & locals[785]
                                                  & locals[812] ^ locals[797] & locals[462];
        locals[636] =
            (~(((locals[785] ^ ~locals[624]) & locals[462] ^ locals[624] ^ locals[785]) & locals[797]) ^ locals[462]) &
            locals[800]
            ^ (~((~(locals[624] & ~locals[462]) ^ locals[462]) & locals[785]) ^ locals[462]) & locals[797] ^
            locals[462];
        locals[331] = (~((locals[793] ^ locals[720]) & locals[776]) ^ (~locals[720] ^ locals[776]) & locals[636] ^
                       (~locals[793] ^ locals[776]) & locals[811] ^ locals[793] ^ locals[720]) & locals[749] ^
                      (locals[811] & locals[793] ^ locals[720] & locals[636]) & locals[776] ^ locals[636];
        locals[802] =
            (~((~locals[793] ^ locals[720]) & locals[776]) ^ (locals[720] ^ locals[776]) & locals[636] ^ locals[720]) &
            locals[749]
            ^ ((locals[793] ^ locals[776]) & locals[749] ^ ~locals[776] & locals[793]) & locals[811] ^
            (~(~locals[776] & locals[636]) ^ locals[776]) & locals[720] ^ locals[636];
        locals[776] = (~((locals[776] ^ locals[636]) & locals[793]) ^ locals[776] ^ locals[636]) & locals[749] ^
                      (locals[793] ^ locals[749]) & (locals[776] ^ locals[636]) & locals[811] ^ locals[776];
        locals[720] = ~locals[776];
        locals[636] = (~((locals[720] ^ locals[331]) & locals[797]) ^ locals[776] ^ locals[331]) & locals[802];
        locals[779] = (locals[720] ^ locals[331]) & locals[802];
        locals[793] =
            ((locals[779] ^ locals[797] ^ 0xaaaaaaaa) & locals[462] ^ locals[815] & 0xaaaaaaaa ^ locals[636]) &
            locals[812]
            ^ ((locals[797] ^ 0x55555555) & (locals[776] ^ locals[331]) ^ locals[797] ^ 0x55555555) & locals[802] ^
            locals[797] ^ locals[776];
        locals[772] = ((locals[776] ^ locals[462]) & locals[812] ^ locals[776] ^ 0xaaaaaaaa) & locals[797] ^
                      (~locals[462] & locals[812] ^ 0xaaaaaaaa) & locals[776] ^ locals[779] ^ 0x55555555;
        locals[813] = (locals[815] ^ locals[462]) & locals[776];
        locals[811] =
            ~((~((~((~((locals[815] ^ locals[462]) & locals[331]) ^ locals[797] ^ locals[462]) & locals[776]) ^
                  locals[797] ^
                  locals[462]) & locals[802]) ^ locals[813] ^ locals[797] ^ locals[462]) & locals[812]) ^
            (~(~(~locals[331] & locals[776]) & locals[797]) ^ locals[776] ^ locals[331]) & locals[802] ^
            (locals[797] ^ locals[331]) & locals[776] ^ locals[797];
        locals[787] = ((locals[779] ^ locals[776] ^ 0x55555555) & locals[462] ^
                       (locals[776] ^ 0x55555555) & locals[797] ^ locals[636]
                       ^ locals[776] ^ 0x55555555) & locals[812] ^
                      ((locals[776] ^ 0x55555555) & locals[331] ^ locals[720] & 0x55555555) & locals[802] ^
                      locals[797] ^
                      0x55555555;
        locals[812] = (~locals[813] ^ locals[797] ^ locals[462]) & locals[812];
        locals[779] = (~locals[812] ^ locals[720] & locals[797] ^ locals[776]) & locals[331] ^ locals[779] ^
                      locals[776];
        locals[813] = ~(~((locals[720] & locals[797] ^ locals[812]) & locals[331]) & locals[802]) ^ locals[331];
        locals[815] = (locals[776] ^ locals[331]) & locals[238];
        locals[462] = ~(((locals[776] ^ locals[802] ^ locals[331]) & locals[238] ^
                         (locals[238] ^ locals[776] ^ locals[802] ^ locals[331]) & locals[796] ^ locals[776] ^
                         locals[802] ^ locals[331]) &
                        locals[704]) ^ (locals[238] ^ locals[331]) & locals[776] ^
                      (locals[815] ^ locals[776]) & locals[802] ^ locals[331];
        locals[812] = (~((locals[785] ^ locals[811] ^ locals[779]) & locals[813]) ^
                       (locals[785] ^ locals[813]) & locals[800] ^ locals[785] ^
                       locals[811] ^ locals[779]) & locals[624] ^ ~(locals[800] & locals[816]) & locals[813] ^
                      locals[785] ^ locals[811];
        locals[749] = ((locals[800] ^ locals[811]) & locals[785] ^
                       (locals[785] ^ locals[800] ^ locals[811]) & locals[624] ^ locals[800] ^
                       locals[811]) & locals[813] ^
                      ((locals[624] ^ locals[785] ^ locals[811]) & locals[813] ^ locals[624] ^ locals[785] ^
                       locals[811]) & locals[779] ^
                      ((locals[800] ^ locals[816]) & locals[624] ^ locals[800] & locals[816] ^ locals[785]) &
                      locals[811] ^ locals[785];
        locals[636] = (~locals[800] ^ locals[813]) & locals[785];
        locals[636] = (locals[816] & locals[811] ^ (locals[816] ^ locals[811]) & locals[800] ^ locals[785]) &
                      locals[624] ^
                      (~((locals[816] ^ locals[811]) & locals[813]) ^ locals[785] ^ locals[811]) & locals[779] ^
                      (~locals[636] ^ locals[800] ^ locals[813]) & locals[811] ^ locals[800] ^ locals[636];
        locals[816] = ~locals[812];
        locals[779] = (~(locals[636] & locals[816]) ^ locals[812]) & locals[749];
        locals[813] = ~((~(~locals[301] & locals[749]) ^ locals[301]) & locals[812] & locals[683]) & locals[636] ^
                      ((~locals[779] ^ locals[636]) & locals[781] ^ locals[636] ^ locals[779]) & locals[301];
        locals[785] = (~((~locals[238] ^ locals[776] ^ locals[802] ^ locals[331]) & locals[796]) ^
                       (locals[720] ^ locals[802] ^ locals[331]) & locals[238] ^ locals[776] ^ locals[802] ^
                       locals[331]) & locals[704] ^
                      (~locals[815] ^ locals[776]) & locals[802] ^ (locals[238] ^ locals[776]) & locals[331] ^
                      locals[238];
        locals[776] = ((locals[704] ^ locals[776] ^ locals[331]) & locals[238] ^ locals[704] ^ locals[331]) &
                      locals[802] ^
                      ~((~locals[238] ^ locals[802]) & locals[796]) & locals[704] ^
                      (locals[704] ^ locals[331]) & locals[238] ^ locals[776];
        locals[331] = ~(locals[785] & locals[776] & locals[462]) & 0xffff;
        locals[815] = ~(locals[301] & locals[816]) ^ locals[812];
        locals[800] = ((locals[812] ^ locals[683] ^ locals[781]) & locals[301] ^
                       (locals[301] ^ locals[816]) & locals[749] ^ locals[683]) &
            locals[636] ^ locals[815] & locals[749] ^ ~locals[301] & locals[683];
        locals[802] = (locals[776] ^ locals[462]) & locals[785] ^ locals[776];
        locals[775] = locals[802] >> 0x11 ^ 0xffffffff;
        locals[749] = (~(((~locals[749] & locals[781] ^ locals[749]) & locals[812] ^ locals[749] ^ locals[781]) &
                         locals[301]) ^
                       ~locals[749] & locals[812]) & locals[636] ^
                      (~((~(locals[815] & locals[636]) ^ locals[301] & locals[816] ^ locals[812]) & locals[749]) ^
                       locals[301]) & locals[683]
                      ^ (~(locals[749] & locals[816]) ^ locals[781]) & locals[301];
        locals[301] = (locals[802] >> 0x11 ^ 0xffffffff) & 0x7fff;
        locals[816] = locals[749] ^ locals[800];
        locals[796] = ~((locals[787] ^ locals[793]) & locals[816] & locals[813]) ^ locals[749] ^ locals[787];
        locals[815] = ~locals[749];
        locals[704] = (~(~locals[800] & locals[813]) ^ ~locals[793] & locals[772]) & locals[749] ^
                      ((locals[749] ^ locals[793]) & locals[772] ^ locals[815] & locals[793] ^
                       locals[816] & locals[813]) & locals[787] ^
                      locals[793];
        locals[789] = (locals[816] & locals[793] ^ locals[749] ^ locals[800]) & locals[813] ^
                      (locals[749] ^ locals[816] & locals[813] ^ locals[772]) & locals[787] ^
                      (locals[815] ^ locals[772]) & locals[793] ^
                      locals[772];
        locals[816] = locals[704] & 0xffff;
        locals[797] = ~locals[816] & locals[789] & locals[796] ^ 0xffff0000;
        locals[683] = ~(locals[789] & 0xffff0000) & locals[704] ^ 0xffff;
        locals[720] = ~locals[704];
        locals[781] =
            (~((locals[796] ^ locals[720]) & locals[789]) ^ (locals[704] ^ locals[813]) & locals[800] ^ locals[796]) &
            locals[749] ^
            (~(~locals[789] & locals[796]) ^ ~locals[813] & locals[800]) & locals[704] ^ locals[789] ^ locals[796];
        locals[782] = ((locals[816] ^ 0xffff0000) & locals[796] ^ locals[816] ^ 0xffff0000) & locals[789];
        locals[773] = locals[802] >> 0x11 ^ 0xffff8000;
        locals[812] = locals[683] << 0xf;
        locals[811] = locals[797] << 0xf;
        locals[758] = ~locals[812] & locals[782] << 0xf ^ ~locals[811] & locals[812];
        locals[816] = locals[704] ^ locals[796];
        locals[794] = ((locals[789] ^ locals[749] ^ locals[704] ^ locals[796]) & locals[813] ^
                       (locals[789] ^ locals[704] ^ locals[796]) & locals[749] ^ locals[789] ^ locals[704] ^
                       locals[796]) & locals[800] ^
                      ~(locals[749] & locals[816]) & locals[789] ^ locals[796];
        locals[636] = ~(locals[683] >> 1);
        locals[779] = locals[797] >> 1 & locals[636];
        locals[764] = (locals[782] & locals[683]) >> 1 ^ locals[779];
        locals[636] = (locals[782] & locals[797]) >> 1 & locals[636];
        locals[813] = ~((locals[796] & locals[720] ^ (locals[815] ^ locals[813]) & locals[800]) & locals[789]) ^
                      (~(locals[796] & (locals[815] ^ locals[813])) ^ locals[749] ^ locals[813]) & locals[800] ^
                      locals[749] ^ locals[704];
        locals[815] = ~locals[813];
        locals[800] = ~((locals[813] ^ locals[794]) & locals[781]) ^ locals[794] & locals[815] ^ locals[813];
        locals[797] = ~(((~(locals[813] & (~locals[794] ^ locals[781])) ^ locals[794] ^ locals[781]) & locals[816] ^
                         locals[794] ^ locals[781]
                          ) & locals[789]) ^
                      (~(locals[704] & (~locals[794] ^ locals[781])) ^ locals[794] ^ locals[781]) & locals[813] ^
                      (locals[794] ^ locals[704]) & locals[781] ^ locals[704] ^ locals[794] & locals[720];
        locals[759] =
            ~((((~(locals[813] & locals[816]) ^ locals[704]) & locals[781] ^ locals[796] & locals[815] ^ locals[813]) &
               locals[794]
               ^ (~(~locals[781] & locals[796]) ^ locals[781]) & locals[813] ^ locals[781] ^ locals[796]) &
              locals[789]) ^
            ~((locals[813] & locals[720] ^ locals[704]) & locals[794]) & locals[781] ^ locals[794];
        locals[749] = locals[331] >> 1;
        locals[813] = ~(locals[802] >> 1) & locals[749];
        locals[462] = (~locals[776] & ~locals[462] & locals[785] & 0xffff) >> 1;
        locals[785] = (locals[813] ^ locals[802] >> 1) & locals[462] ^ locals[749];
        locals[774] = ~((locals[782] & locals[683]) << 0xf) ^ locals[811];
        locals[811] = ~(~(locals[782] << 0xf) & locals[812]) ^ locals[811];
        locals[812] = ~locals[779] & locals[782] >> 1 ^ locals[683] >> 1;
        locals[683] = locals[781] & locals[815] & 0xffff;
        locals[776] = ~locals[683];
        locals[789] = ~(((locals[794] & locals[816] ^ locals[704] ^ locals[796]) & locals[789] ^ locals[704] ^
                         locals[794] & locals[720]) &
                        locals[781]) ^ locals[789];
        locals[749] = ~locals[813] & locals[462] ^ locals[749];
        locals[462] = (locals[802] ^ locals[331]) >> 1;
        locals[816] = ~locals[772] ^ locals[793];
        locals[720] = ~locals[797];
        locals[331] = (~(locals[816] & locals[789]) ^ locals[816] & locals[759] ^ locals[772] ^ locals[793]) &
                      locals[787] ^
                      (locals[720] & locals[789] ^ locals[797] ^ locals[772]) & locals[759] ^
                      (locals[720] ^ locals[772]) & locals[789] ^
                      locals[772];
        locals[779] = (locals[781] ^ locals[815]) & locals[794] & 0xffff;
        locals[813] = locals[779] ^ 0xffff0000;
        locals[815] = (locals[813] ^ locals[776]) & locals[636];
        locals[802] = ((locals[813] ^ locals[776]) & locals[764] ^ ~locals[815] ^ locals[813] ^ locals[776]) &
                      locals[812] ^
                      (locals[815] ^ locals[813] ^ locals[776]) & locals[764] ^ locals[815] ^ locals[776];
        locals[791] = (~((~locals[813] ^ locals[776]) & locals[800]) ^ (locals[776] ^ locals[636]) & locals[764] ^
                       locals[776] & locals[636] ^
                       locals[813]) & locals[812] ^
                      (~locals[800] & locals[813] ^ ~locals[636] & locals[764] ^ locals[636]) & locals[776] ^
                      locals[813];
        locals[812] = (~((locals[683] ^ locals[636]) & locals[812]) ^ locals[683] & locals[636] ^ locals[776]) &
                      locals[764] ^
                      (~((~locals[636] ^ locals[800]) & locals[776]) ^ locals[636] ^ locals[800]) & locals[812] ^
                      ~((~locals[812] ^ locals[776]) & locals[800]) & locals[813] ^
                      (locals[636] ^ locals[800]) & locals[776] ^ locals[636] ^
                      locals[800];
        locals[800] = locals[800] << 0x10;
        locals[779] = locals[779] << 0x10;
        locals[796] = ~(~locals[800] & locals[779]) & locals[776] << 0x10 ^ locals[800];
        locals[779] = ~locals[779];
        locals[793] = ~(locals[779] & locals[776] << 0x10) & locals[800] ^ (locals[813] & locals[776]) << 0x10;
        locals[704] = ~((locals[759] ^ locals[797]) & locals[816] & locals[787]) ^
                      (locals[759] ^ locals[797]) & locals[772] ^ locals[789] ^
                      locals[797];
        locals[779] = locals[779] ^ locals[800];
        locals[815] = (locals[796] ^ locals[758]) & locals[811];
        locals[636] = locals[779] & ~locals[793];
        locals[800] = ((locals[796] ^ locals[779]) & locals[793] ^ locals[796] ^ locals[779] ^ locals[815]) &
                      locals[774] ^
                      (~(~locals[758] & locals[811]) ^ locals[793] ^ locals[636]) & locals[796] ^ locals[793] ^
                      locals[811];
        locals[813] = ~locals[796] ^ locals[779];
        locals[636] = ~((~((locals[813] ^ locals[811]) & locals[793]) ^ locals[796] ^ locals[779] ^ locals[815]) &
                        locals[774]) ^
                      ((~locals[779] ^ locals[758]) & locals[793] ^ locals[779] ^ locals[758]) & locals[811] ^
                      ((~locals[793] ^ locals[758]) & locals[811] ^ locals[636]) & locals[796] ^ locals[793];
        locals[815] = locals[704] & locals[331] & 0xffff;
        locals[683] = ~locals[815];
        locals[774] = (~((locals[813] ^ locals[774] ^ locals[758]) & locals[811]) ^ locals[796] ^ locals[779]) &
                      locals[793] ^
                      locals[813] & locals[811] ^ locals[779] ^ locals[774];
        locals[811] =
            ((locals[720] & locals[759] ^ locals[816] & locals[787] ^ locals[797] ^ locals[772]) & locals[789] ^
             (locals[816] & locals[787] ^ locals[772]) & locals[797] ^ locals[759]) & (locals[704] ^ locals[331]) ^
            locals[704] & locals[331];
        locals[720] = (~locals[331] & locals[704] ^ locals[331]) & 0xffff;
        locals[815] = locals[815] & locals[720];
        locals[779] = ~((~((locals[683] ^ ~locals[720] ^ locals[462] ^ locals[749]) & locals[785]) ^
                         locals[683] & ~locals[720] ^ locals[749])
                        & locals[811]) ^ (~locals[815] ^ locals[462]) & locals[785] ^ locals[462];
        locals[816] = locals[720] ^ locals[683];
        locals[720] = (~(locals[816] & locals[462]) ^ locals[816] & locals[785]) & locals[811] ^
                      ((locals[462] ^ locals[785]) & locals[683] ^ locals[462] ^ locals[785]) & locals[720] ^
                      (~locals[785] & locals[749] ^ locals[785]) & locals[462];
        locals[749] =
            ((locals[816] ^ locals[462] ^ locals[749]) & locals[785] ^ locals[815] ^ locals[462] ^ locals[749]) &
            locals[811] ^
            (~locals[815] ^ locals[462] ^ locals[749]) & locals[785] ^ locals[815] ^ locals[749];
        locals[815] = (locals[749] ^ locals[779]) & locals[774];
        locals[331] = (~((locals[749] ^ locals[779]) & locals[800]) ^ locals[815]) & locals[636] ^
                      (~locals[720] & locals[779] ^ locals[720]) & locals[749] ^
                      (locals[815] ^ locals[749] ^ locals[779]) & locals[800];
        locals[813] = locals[683] >> 0x10;
        locals[776] = (locals[811] & locals[816]) >> 0x10;
        locals[796] = ((locals[749] ^ locals[800]) & locals[636] ^ ~locals[749] & locals[800]) & locals[774] ^
                      (~((~locals[749] ^ locals[636]) & locals[779]) ^ locals[749] ^ locals[636]) & locals[720] ^
                      ((locals[779] ^ locals[800]) & locals[749] ^ locals[779] ^ locals[800]) & locals[636] ^
                      (~locals[779] ^ locals[800]) & locals[749] ^ locals[800];
        locals[749] = ~(((locals[749] ^ locals[720] ^ locals[800]) & locals[779] ^
                         (~locals[779] ^ locals[800]) & locals[774] ^ locals[749] ^
                         locals[720]) & locals[636]) ^ ~(~locals[774] & locals[800]) & locals[779] ^ locals[749];
        locals[815] = (locals[796] ^ locals[749]) & locals[331];
        locals[720] = locals[796] & locals[749];
        locals[793] = (locals[815] & 0xffcfffcf ^ locals[720]) & 0xc300c30;
        locals[800] = ((locals[796] ^ 0xff3fff3f) & locals[331] ^ locals[796] & 0xc000c0) & locals[749] & 0x3c003c0;
        locals[815] = locals[815] & 0x300030;
        locals[636] = ~locals[813];
        locals[462] = (~((locals[813] ^ 0xffff ^ locals[301]) & locals[776]) ^ (locals[636] ^ locals[301]) & 0xffff ^
                       locals[301]) &
                      locals[775] ^ (locals[636] & 0xffff ^ (locals[813] ^ 0xffff) & locals[776]) & locals[301] ^
                      (~((~locals[776] ^ 0xffff ^ locals[301]) & locals[775]) ^ locals[776] ^ 0xffff ^ locals[301]) &
                      locals[773] ^
                      locals[776];
        locals[779] = ~locals[749];
        locals[772] = ((locals[331] ^ 0x30003) & locals[779] & locals[796] ^ locals[749] & 0xfffcfffc) & 0x30033003;
        locals[787] = ((locals[749] ^ 0xc000c0) & ~locals[796] & locals[331] ^ locals[796] & 0xff3fff3f) & 0x3c003c0;
        locals[785] = ~(locals[779] & locals[796] & 0x300030) ^ locals[749] & 0x300030;
        locals[704] = ~((locals[815] & locals[785]) >> 2) ^ locals[793] >> 2;
        locals[797] = ~((~((locals[813] ^ locals[773] ^ locals[301]) & locals[775]) ^
                         (locals[636] ^ locals[775]) & 0xffff ^ locals[813] ^
                         locals[773] ^ locals[301]) & locals[776]) ^ ~(locals[813] & locals[775]) & 0xffff ^
                      locals[301] ^ locals[775];
        locals[781] = (~locals[796] & locals[331] ^ locals[796]) & 0xc000c000;
        locals[775] = ~(((locals[636] ^ locals[301]) & locals[776] ^ (locals[636] ^ locals[775]) & locals[301] ^
                         ~locals[775] & locals[773] ^
                         locals[813]) & 0xffff) ^
                      ((locals[683] & locals[811] & locals[816]) >> 0x10 ^ ~(~locals[775] & locals[773]) ^
                       locals[775]) & locals[301] ^
                      locals[776] ^ locals[775];
        locals[683] = ~(locals[796] & locals[331] & 0xc000c000);
        locals[816] = locals[775] ^ locals[791];
        locals[811] =
            ((~(locals[749] & 0xc000c0) & locals[796] ^ locals[749]) & locals[331] ^ locals[720] & 0xff3fff3f) &
            0x3c003c0;
        locals[776] = (locals[811] ^ locals[787]) >> 6;
        locals[636] = ~locals[797] & locals[462];
        locals[742] = ((locals[797] ^ locals[791]) & locals[462] ^ (~locals[797] ^ locals[812]) & locals[791] ^
                       locals[797] ^ locals[812]) &
                      locals[775] ^ (locals[816] & locals[812] ^ locals[775] ^ locals[791]) & locals[802] ^
                      ~locals[636] & locals[791];
        locals[782] = ((locals[796] & 0xc000c ^ locals[749]) & locals[331] ^ locals[720]) & 0xc00cc00c;
        locals[773] = ~(~(locals[815] >> 2) & locals[785] >> 2) & locals[793] >> 2 ^ locals[815] >> 2;
        locals[758] = (locals[781] & locals[683] ^ locals[782]) << 8;
        locals[794] = ((locals[749] & 0x30003000 ^ 0x30003) & locals[796] ^ locals[749] & 0x30033003) & locals[331] ^
                      locals[720] & 0x30033003;
        locals[791] = (~locals[802] ^ locals[791]) & locals[812] ^ (locals[797] ^ locals[462]) & locals[775] ^
                      locals[636] ^ locals[802] ^
                      locals[791];
        locals[802] = (locals[785] ^ locals[793]) >> 2;
        locals[797] = (locals[791] & 0xc000c ^ 0x30003000) & locals[742];
        locals[720] = ~(locals[800] << 4);
        locals[778] = ~(locals[811] << 4 & locals[720]) & locals[787] << 4 ^ locals[800] << 4;
        locals[764] = ~(locals[787] >> 6 & ~(locals[800] >> 6)) ^ locals[811] >> 6 & ~(locals[800] >> 6);
        locals[759] = (locals[811] & locals[787]) >> 6;
        locals[789] = (~(locals[781] << 8) & locals[683] << 8 ^ ~(locals[782] << 8)) & 0xffffff00;
        locals[636] = ~locals[742];
        locals[813] = locals[636] & locals[791];
        locals[462] = ((locals[742] & 0x30003000 ^ 0xc000c) & locals[791] ^ locals[742] & 0x30003000 ^ 0xc000c) &
                      locals[816]
                      ^ locals[813] & 0xc000c;
        locals[774] = (~locals[813] & locals[816] ^ locals[813]) & 0x30003 ^ locals[742] & 0x3000300;
        locals[775] = ~(~((locals[782] ^ locals[781]) << 8) & locals[683] << 8) ^ locals[781] << 8;
        locals[331] = (locals[779] & locals[331] ^ locals[749] & 0x30003) & locals[796] & 0x30033003;
        locals[811] = (locals[811] ^ locals[800]) << 4;
        locals[753] = ((locals[791] ^ locals[742]) & locals[816] ^ locals[813]) & 0xc000c0;
        locals[796] = (((locals[742] ^ 0xfffcfffc) & locals[791] ^ locals[636] & 0xfffcfffc) & locals[816] ^
                       (locals[813] ^ locals[742]) & 0xfffcfffc) & 0x3030303;
        locals[787] = locals[787] << 4 & locals[720] ^ locals[811];
        locals[765] = ~(locals[794] << 2) & locals[772] << 2 ^ locals[331] << 2;
        locals[766] = (~(locals[742] & 0xfff3fff3) & ~locals[791] & locals[816] ^ locals[813] & 0xfff3fff3) &
                      0x300c300c;
        locals[768] = (locals[331] & locals[794] ^ locals[772]) << 2;
        locals[769] = (~locals[791] & 0xc000c000 ^ locals[742] & 0xc000c0) & locals[816] ^ locals[813] & 0xc000c000 ^
                      locals[742] & 0xc000c0;
        locals[779] = locals[462] << 0xc;
        locals[615] = ~locals[779] ^ locals[797] << 0xc;
        locals[755] = ((locals[791] ^ 0xfffcfffc) & locals[742] ^ 0x30003) & locals[816] & 0x3030303;
        locals[709] = ~(locals[331] << 2) & locals[794] << 2 ^ locals[772] << 2;
        locals[748] = ~((locals[766] & locals[797]) << 0xc) & locals[779] ^ locals[766] << 0xc;
        locals[462] = locals[462] >> 6;
        locals[749] = locals[797] >> 6;
        locals[827] = ~locals[462] ^ locals[749];
        locals[800] = locals[796] >> 2;
        locals[788] = ~(locals[755] >> 2) & locals[774] >> 2 ^ locals[800];
        locals[720] = ~locals[749] & locals[766] >> 6;
        locals[792] = locals[720] ^ locals[462];
        locals[812] = (locals[742] ^ locals[816]) & 0xc000c0;
        locals[301] = locals[774] << 6;
        locals[777] = ~(~(~(locals[755] << 6) & locals[301]) & locals[796] << 6) ^ locals[755] << 6;
        locals[771] = ~((locals[720] ^ locals[749]) & locals[462]) ^ locals[766] >> 6;
        locals[749] = (locals[755] & locals[796]) << 6 & ~locals[301] ^ ~(locals[796] << 6) & locals[301];
        locals[462] = (locals[755] ^ locals[774]) << 6;
        locals[301] = ~((locals[683] & locals[781]) >> 4) ^ locals[782] >> 4;
        locals[796] = ~(~((locals[772] & locals[331]) >> 10) & locals[794] >> 10) ^ locals[331] >> 10;
        locals[331] = ~(~(~(locals[794] >> 10) & locals[772] >> 10) & locals[331] >> 10) ^ locals[772] >> 10;
        locals[408] = (locals[812] & locals[753] ^ locals[769]) << 8;
        locals[797] = ~(locals[766] << 0xc) & locals[779] ^ locals[797] << 0xc;
        locals[766] = ~(~(locals[753] << 8) & locals[769] << 8) ^ locals[812] << 8;
        locals[760] = ~((locals[774] & locals[755]) >> 2) ^ locals[800];
        locals[772] = (locals[794] ^ locals[772]) >> 10;
        locals[720] = locals[775] ^ locals[758];
        locals[779] = locals[720] & locals[789];
        locals[794] = (locals[720] & locals[748] ^ locals[775] ^ locals[758]) & locals[789] ^
                      (~locals[615] ^ locals[758]) & locals[748] ^
                      (~locals[748] & locals[615] ^ locals[779] ^ locals[758]) & locals[797] ^ locals[758];
        locals[789] = ~(locals[812] << 8) & locals[753] << 8 ^ locals[769] << 8;
        locals[800] = ~(locals[774] >> 2) & locals[800] ^ locals[755] >> 2;
        locals[774] = ~(((locals[742] & 0xc000c00 ^ 0x300030) & locals[791] ^ locals[742] & 0xc000c00 ^ 0x300030) &
                        locals[816]) ^ locals[813] & 0x300030;
        locals[775] =
            ((locals[408] ^ locals[766]) & (locals[811] ^ locals[778]) ^ locals[811] ^ locals[778]) & locals[787] ^
            locals[408] ^
            locals[778];
        locals[720] = (locals[772] ^ locals[331]) & locals[796];
        locals[813] = locals[331] & (~locals[772] ^ locals[792]);
        locals[755] = ~((locals[771] ^ ~locals[331]) & locals[827]) & locals[792] ^
                      (~locals[720] ^ locals[772] ^ locals[813]) & locals[771] ^
                      (locals[796] & ~locals[331] ^ locals[331]) & locals[772] ^ locals[331];
        locals[683] = (~(locals[781] >> 4 & ~(locals[683] >> 4)) & locals[782] >> 4 ^ ~(locals[683] >> 4)) & 0xfffffff;
        locals[814] =
            (~((locals[772] ^ locals[796] ^ locals[827]) & locals[331]) ^ (locals[827] ^ ~locals[796]) & locals[772]) &
            locals[792]
            ^ ~(((locals[772] ^ locals[827]) & locals[792] ^ locals[813] ^ locals[720]) & locals[771]) ^ locals[772];
        locals[813] = ~((locals[782] ^ locals[781]) >> 4) & 0xfffffff;
        locals[781] = (locals[779] ^ locals[797] ^ locals[758]) & locals[615] ^
                      (locals[797] ^ locals[758] ^ ~locals[779]) & locals[748] ^
                      locals[797];
        locals[782] = ((locals[791] ^ 0xffcfffcf) & locals[816] ^ locals[791]) & locals[636] & 0xc300c30;
        locals[699] = ((locals[778] ^ ~locals[408]) & locals[789] ^ locals[787] & (locals[811] ^ locals[778]) ^
                       locals[408] ^ locals[778]) &
            locals[766] ^ (~locals[789] & locals[408] ^ ~locals[811] & locals[787]) & locals[778] ^ locals[408];
        locals[720] = ~locals[777];
        locals[790] = (~((locals[777] ^ locals[768]) & locals[765]) ^ locals[768] & locals[720]) & locals[709] ^
                      (~((locals[765] ^ locals[720]) & locals[749]) ^ locals[777] ^ locals[765] & locals[720]) &
                      locals[462] ^
                      (~(locals[765] & locals[720]) ^ locals[777]) & locals[749] ^ locals[777];
        locals[770] = ((locals[301] ^ locals[812]) & locals[813] ^ locals[301] ^ locals[812]) & locals[753] ^
                      (locals[812] & (locals[813] ^ locals[753]) ^ locals[813] ^ locals[753]) & locals[769] ^
                      ~(locals[683] & (locals[813] ^ locals[753])) & locals[301] ^ locals[813];
        locals[771] = (~locals[792] & locals[772] ^ locals[796] & (~locals[772] ^ locals[792]) ^ locals[792]) &
                      locals[331] ^
                      (locals[771] ^ locals[827] ^ ~locals[796]) & locals[772] & locals[792] ^ locals[771];
        locals[827] = ((locals[813] ^ locals[301]) & (locals[769] ^ locals[753]) ^ locals[769] ^ locals[753]) &
                      locals[812] ^
                      (~locals[683] & locals[813] ^ locals[769] ^ locals[753]) & locals[301] ^
                      (~locals[769] ^ locals[753]) & locals[813] ^
                      locals[769];
        locals[812] = locals[812] & (locals[769] ^ locals[753]);
        locals[753] = (~locals[813] & locals[683] ^ locals[813] ^ locals[769] ^ locals[812]) & locals[301] ^
                      (locals[769] ^ locals[812]) & locals[813] ^ locals[753];
        locals[742] = (locals[791] & locals[816] & 0x300030 ^ 0xc000c00) & locals[742];
        locals[816] = ~locals[827];
        locals[636] = ~locals[755];
        locals[301] = (~((locals[755] ^ locals[816]) & locals[814]) ^ locals[755] ^ locals[827] & locals[636]) &
                      locals[771] ^
                      ((~locals[753] ^ locals[755]) & locals[827] ^ locals[755]) & locals[814] ^
                      ~((locals[814] ^ locals[816]) & locals[770]) & locals[753] ^ locals[755] ^
                      locals[827] & locals[636];
        locals[331] = ((locals[777] ^ locals[709]) & locals[749] ^ locals[709] & locals[720]) & locals[462] ^
                      (~((locals[749] ^ locals[768] ^ locals[765]) & locals[777]) ^ locals[749] ^ locals[768] ^
                       locals[765]) & locals[709] ^
                      locals[765];
        locals[813] = locals[760] & (locals[800] ^ locals[788]);
        locals[720] = (~locals[749] ^ locals[777]) & locals[462] ^ locals[749] & locals[720];
        locals[777] = (~locals[768] & locals[709] ^ locals[777] ^ locals[720]) & locals[765] ^
                      (locals[777] ^ locals[768] ^ locals[720]) & locals[709] ^ locals[777];
        locals[778] = ((locals[408] ^ locals[778]) & locals[766] ^ ~locals[778] & locals[408]) & locals[789] ^
                      (locals[811] ^ ~locals[408]) & locals[778] & locals[787] ^ locals[766] ^ locals[778];
        locals[811] = ~((locals[742] & locals[782] & locals[774]) << 4);
        locals[615] = (~locals[748] & locals[615] ^ locals[758] ^ ~locals[779]) & locals[797] ^
                      (locals[779] ^ locals[758]) & locals[748] ^
                      locals[615];
        locals[749] = ~((locals[782] ^ locals[774]) << 2) & locals[742] << 2 ^ locals[774] << 2;
        locals[462] = (locals[742] ^ locals[774]) << 4;
        locals[796] = (locals[742] ^ locals[782]) << 2;
        locals[772] = locals[782] << 2 & ~(locals[774] << 2) & ~(locals[742] << 2);
        locals[787] = ~(locals[774] << 4) & locals[742] << 4 ^ (locals[782] & locals[774]) << 4;
        locals[797] = ~(locals[462] & locals[787]) & locals[811] ^
                      locals[785] & locals[793] & (~locals[462] ^ locals[787]) ^ locals[462] ^
                      locals[787];
        locals[683] = (~((locals[827] ^ locals[755]) & locals[771]) ^ ~locals[770] & locals[753] ^
                       locals[827] & (locals[753] ^ locals[755]))
                      & locals[814] ^ (locals[753] & locals[770] ^ locals[771] & locals[636] ^ locals[755]) &
                      locals[827] ^
                      locals[753];
        locals[720] = (~locals[781] ^ locals[615]) & locals[794];
        locals[779] = ~locals[720] ^ locals[615];
        locals[812] = locals[779] ^ locals[331];
        locals[779] = locals[790] & locals[812] ^ locals[779] & locals[331] ^ locals[777];
        locals[827] = (locals[814] & (locals[753] ^ locals[755]) ^ locals[753] & locals[636]) & locals[771] ^
                      ((locals[770] ^ locals[755] ^ locals[816]) & locals[814] ^ locals[827] ^ locals[770] ^
                       locals[755]) & locals[753] ^
                      locals[827];
        locals[816] = ~locals[802] ^ locals[749];
        locals[636] = locals[704] ^ locals[796];
        locals[782] = ~((locals[704] & locals[816] ^ locals[802] ^ locals[749]) & locals[773]) ^
                      (locals[816] & locals[796] ^ locals[802] ^ locals[749]) & locals[772] ^
                      (locals[802] & locals[636] ^ locals[796]) & locals[749] ^ ~locals[802] & locals[796];
        locals[812] = (locals[720] ^ locals[615] ^ locals[331]) & locals[790] ^ locals[812] & locals[777] ^ locals[331];
        locals[615] = (~(locals[781] & (~locals[790] ^ locals[777])) ^ (~locals[790] ^ locals[777]) & locals[615] ^
                       locals[790] ^ locals[777])
                      & locals[794] ^ (~locals[615] ^ locals[331]) & locals[777] ^
                      (locals[615] ^ locals[331]) & locals[790] ^
                      locals[615];
        locals[331] = ~locals[683] & ~locals[301] & locals[827] & 0x44444444;
        locals[758] =
            ((locals[772] ^ locals[749]) & (locals[802] ^ locals[773]) ^ locals[802] ^ locals[773]) & locals[636] ^
            locals[773] ^
            locals[772];
        locals[781] = ~(~locals[779] & locals[812] & 0x44444444);
        locals[749] = (locals[636] & locals[772] ^ locals[704] ^ locals[796]) & locals[773] ^
                      ~(locals[704] & (locals[773] ^ locals[772])) & locals[802] ^
                      ~((locals[773] ^ locals[772]) & locals[796]) & locals[749];
        locals[802] = ((~(locals[827] & 0x44444444) & locals[683] ^ ~locals[827] & 0xbbbbbbbb) & locals[301] ^
                       (~locals[827] & locals[683] ^ locals[827]) & 0x44444444 ^ locals[827]) & 0xcccccccc;
        locals[816] = ~locals[779] & locals[615];
        locals[794] = (~((locals[615] ^ locals[779]) & locals[812]) ^ locals[816]) & 0x44444444;
        locals[796] = (~locals[462] ^ locals[787] ^ locals[811]) & locals[785] & locals[793] ^ 0xffffffff ^ locals[811];
        locals[773] = (~((~locals[800] ^ locals[788] ^ locals[759] ^ locals[776]) & locals[764]) ^
                       ~locals[759] & locals[776] ^ locals[800]) &
            locals[760] ^ (~(~locals[776] & locals[759]) ^ locals[788]) & locals[764] ^ locals[776];
        locals[720] = (~locals[773] ^
                       ((~locals[764] ^ locals[776]) & (locals[800] ^ locals[788]) ^ locals[764] ^ locals[776]) &
                       locals[760] ^
                       locals[788] & (~locals[764] ^ locals[776]) ^ locals[776]) &
                      (~((locals[788] ^ locals[759] ^ locals[813]) & locals[764]) ^
                       (~locals[813] ^ locals[788] ^ locals[759]) & locals[776] ^
                       locals[760]);
        locals[813] = (~locals[720] ^ locals[773]) & locals[797] ^
                      (locals[720] ^ locals[773] ^ locals[797]) & locals[796];
        locals[812] = (~locals[816] & 0xbbbbbbbb ^ locals[779]) & 0xcccccccc ^
                      (locals[615] & 0x88888888 ^ 0x44444444) & locals[812];
        locals[779] = (locals[812] ^ locals[794]) >> 1;
        locals[772] = locals[796] ^ locals[797];
        locals[764] = ~(locals[683] & 0x44444444) ^ locals[301] & 0x44444444;
        locals[301] = (~(locals[764] >> 1) & locals[331] >> 1 ^ ~(locals[802] >> 1)) & 0x7fffffff;
        locals[816] = ~(locals[812] >> 1) & locals[794] >> 1;
        locals[636] = locals[758] ^ locals[782];
        locals[704] = ~(((locals[699] ^ locals[778]) & locals[636] ^ locals[758] ^ locals[782]) & locals[775]) ^
                      (~(locals[699] & locals[636]) ^ locals[758] ^ locals[782]) & locals[778] ^
                      locals[636] & locals[749] ^ locals[782];
        locals[636] = locals[699] & (~locals[758] ^ locals[782]);
        locals[683] = (~((~locals[758] ^ locals[782]) & locals[778]) ^ locals[636] ^ locals[758] ^ locals[782]) &
                      locals[775] ^
                      ~locals[636] & locals[778] ^ locals[758];
        locals[758] = ~(((locals[699] ^ locals[782]) & locals[775] ^ (locals[749] ^ locals[782]) & locals[758] ^
                         (~locals[699] ^ locals[749]) & locals[782] ^ locals[699]) & locals[778]) ^
                      (~locals[749] & locals[758] ^ locals[775] & ~locals[699] ^ locals[749]) & locals[782] ^
                      locals[758];
        locals[636] = (locals[781] >> 1 & ~locals[779] ^ ~locals[816]) & 0x7fffffff;
        locals[749] = ~(locals[331] >> 1) & locals[802] >> 1 ^ locals[764] >> 1 ^ 0x80000000;
        locals[800] = (~((locals[816] ^ locals[779] ^ locals[812]) & locals[794]) ^ locals[779]) & locals[636] ^
                      ~((locals[636] ^ locals[794]) & locals[812]) & locals[781] ^
                      (locals[816] ^ locals[812]) & locals[794];
        locals[776] = ~((~((~locals[794] ^ locals[781]) & locals[636]) ^ locals[794] ^ locals[781]) & locals[816]) ^
                      ~((~locals[794] ^ locals[781]) & locals[779]) & locals[636] ^ locals[794];
        locals[773] = (~((locals[793] & locals[811] ^ ~locals[815] & locals[793]) & locals[785]) ^
                       ((~locals[815] ^ locals[811]) & locals[462] ^ locals[811]) & locals[787] ^ locals[462]) &
                      (~locals[796] ^ locals[797])
                      ^ ~locals[797] & locals[796] ^ locals[720] ^ locals[773];
        locals[811] = ~(locals[683] & locals[758]) & 0x88888888;
        locals[462] = (locals[764] & locals[331] ^ locals[802]) >> 1;
        locals[782] = (~locals[773] & ~locals[813] & locals[772] & 0xbbbbbbbb ^
                       ~(locals[813] & 0xbbbbbbbb) & locals[773]) &
            0xcccccccc ^ 0x77777777;
        locals[815] = (~locals[462] ^ locals[802] ^ locals[331]) & locals[764];
        locals[789] = (~((~locals[764] ^ locals[301]) & locals[462]) ^ locals[764] ^ locals[301]) & locals[749] ^
                      (locals[815] ^ locals[462] ^ locals[802] ^ locals[331]) & locals[301] ^ locals[815] ^
                      locals[462] ^ locals[331];
        locals[815] = (~locals[749] ^ locals[301]) & locals[462];
        locals[720] = ~locals[764] & locals[331];
        locals[796] = (locals[720] ^ locals[815] ^ locals[749] ^ locals[764] ^ locals[301]) & locals[802] ^
                      (locals[815] ^ locals[749] ^ locals[301]) & locals[764] ^ locals[301];
        locals[759] = ((locals[772] ^ 0xbbbbbbbb) & locals[773] ^ 0xbbbbbbbb) & locals[813] & 0xcccccccc;
        locals[793] = ((~(locals[813] & 0x44444444) & locals[773] ^ ~locals[813]) & locals[772] ^ locals[773]) &
                      0xcccccccc ^
                      0x33333333;
        locals[794] = ((~locals[636] ^ locals[794]) & locals[812] ^ (~locals[816] ^ locals[779]) & locals[636] ^
                       locals[816] ^ locals[794]) &
            locals[781] ^ (~locals[812] & locals[794] ^ locals[779]) & locals[636] ^ locals[794];
        locals[812] = locals[782] >> 1;
        locals[772] = ~(~(~(locals[793] >> 1) & locals[812]) & locals[759] >> 1) ^ locals[812];
        locals[764] =
            ((locals[301] ^ locals[331]) & locals[764] ^ ~locals[815] ^ locals[749] ^ locals[301] ^ locals[331]) &
            locals[802] ^
            (~locals[462] & locals[749] ^ ~locals[720] ^ locals[764]) & locals[301] ^ locals[764];
        locals[812] = ~((locals[759] & locals[782]) >> 1) & locals[793] >> 1 ^ locals[812];
        locals[816] = (locals[764] ^ locals[796] ^ locals[789]) & locals[804];
        locals[815] = (locals[804] ^ locals[789]) & locals[764];
        locals[720] = ~locals[789];
        locals[462] = ((locals[804] ^ locals[764] ^ locals[796] ^ locals[789]) & locals[809] ^ locals[816] ^
                       locals[764] ^ locals[796] ^
                       locals[789]) & locals[493] ^
                      (locals[816] ^ locals[764] ^ locals[796] ^ locals[789]) & locals[809] ^
                      (locals[804] & locals[720] ^ locals[815] ^ locals[789]) & locals[796] ^
                      (~(locals[804] & locals[720]) ^ locals[789]) & locals[764] ^ locals[804];
        locals[816] = locals[759] ^ locals[793];
        locals[749] = locals[816] >> 1;
        locals[636] = ~locals[772];
        locals[779] = locals[636] ^ locals[812];
        locals[331] =
            ~(((locals[812] ^ locals[782]) & locals[772] ^ ~(locals[779] & locals[749]) ^ locals[759] & locals[782]) &
              locals[793])
            ^ (~locals[749] & locals[812] ^ ~locals[759] & locals[782]) & locals[772] ^ locals[759];
        locals[802] = (~(locals[683] & locals[704]) ^ ~locals[704] & locals[758]) & 0xcccccccc;
        locals[787] = ~locals[683] & ~locals[758] & 0x88888888;
        locals[785] = (locals[761] ^ locals[799]) & (locals[794] ^ locals[800]) & locals[260] ^ locals[800] ^
                      locals[799];
        locals[704] = (~((locals[762] ^ locals[402] ^ locals[794] ^ locals[776]) & locals[800]) ^
                       (locals[762] ^ locals[402] ^ locals[776]) & locals[794] ^ locals[776]) & locals[660] ^
                      ((locals[762] ^ locals[794] ^ locals[776]) & locals[800] ^
                       (locals[762] ^ locals[776]) & locals[794] ^ locals[776]) &
                      locals[402] ^ (locals[794] ^ locals[800]) & locals[762] ^ locals[794];
        locals[813] = ~locals[794];
        locals[797] = (~((locals[813] ^ locals[799]) & locals[800]) ^ locals[813] & locals[799] ^ locals[794]) &
                      locals[776] ^
                      ~((locals[794] ^ locals[260]) & locals[800]) & locals[799] ^
                      (~locals[800] ^ locals[799]) & locals[260] & locals[761] ^
                      locals[794];
        locals[770] = (~((~locals[800] ^ locals[260]) & locals[794]) ^ locals[800] ^ locals[260]) & locals[799] ^
                      ((locals[794] ^ locals[799]) & locals[800] ^ locals[813] & locals[799]) & locals[776] ^
                      (locals[794] ^ locals[799]) & locals[260] & locals[761] ^ locals[794] ^ locals[800];
        locals[761] = (locals[802] ^ locals[811]) >> 1;
        locals[782] = ~((~(locals[779] & locals[793]) ^ locals[636] & locals[812] ^ locals[772]) & locals[749]) ^
                      ((locals[636] ^ locals[793]) & locals[782] ^ locals[772] ^ locals[793]) & locals[759] ^
                      ((~locals[812] ^ locals[782]) & locals[772] ^ locals[782]) & locals[793] ^
                      ~locals[782] & locals[772] ^ locals[782];
        locals[636] = ~(locals[804] & (~locals[764] ^ locals[789]));
        locals[793] = ((~locals[764] ^ locals[789]) & locals[809] ^ locals[636] ^ locals[764] ^ locals[789]) &
                      locals[493] ^
                      (locals[636] ^ locals[764] ^ locals[789]) & locals[809] ^
                      (locals[764] ^ locals[789]) & locals[804] ^ locals[796];
        locals[759] = ~(locals[816] & locals[812]) & locals[772] ^ locals[779] & locals[816] & locals[749] ^
                      locals[759];
        locals[816] = ~locals[402];
        locals[301] = (~((locals[816] ^ locals[800]) & locals[660]) ^ locals[816] & locals[800] ^ locals[402]) &
                      locals[762] ^
                      (~((locals[816] ^ locals[794]) & locals[800]) ^ locals[813] & locals[402] ^ locals[794]) &
                      locals[776] ^
                      ~((locals[660] ^ locals[794]) & locals[402]) & locals[800] ^ locals[660] ^ locals[402] ^
                      locals[794];
        locals[789] = ~((~((~locals[804] ^ locals[809]) & locals[493]) ^ (locals[720] ^ locals[809]) & locals[804] ^
                         locals[815] ^ locals[789]
                         ^ locals[809]) & locals[796]) ^
                      (locals[720] & locals[764] ^ locals[493] & locals[809]) & locals[804] ^ locals[764] ^
                      locals[789];
        locals[815] = (locals[629] ^ locals[331]) & locals[759];
        locals[796] =
            (~((locals[759] ^ locals[629]) & locals[562]) ^ locals[782] & locals[331] ^ locals[815] ^ locals[629]) &
            locals[55] ^
            (~locals[629] & locals[562] ^ ~locals[782] & locals[331]) & locals[759] ^ locals[562];
        locals[772] =
            ((locals[562] ^ locals[55]) & (locals[782] ^ locals[759]) ^ locals[782] ^ locals[759]) & locals[331] ^
            locals[759] ^
            locals[562];
        locals[800] = ((locals[402] ^ locals[800]) & locals[794] ^ (locals[402] ^ locals[794]) & locals[762] ^
                       (locals[813] ^ locals[800]) & locals[776] ^ locals[800]) & locals[660] ^
                      (locals[816] & locals[762] ^ locals[800] & locals[776] ^ locals[402]) & locals[794] ^
                      locals[402] ^ locals[800];
        locals[812] = (locals[787] & locals[811] ^ locals[802]) >> 1;
        locals[816] = ~locals[800];
        locals[720] = ~(locals[816] & locals[704]);
        locals[683] = (locals[704] ^ 0x55555555) & locals[301] ^ locals[720] & 0xaaaaaaaa ^ locals[800];
        locals[776] = locals[802] >> 1 & ~(locals[787] >> 1) & locals[811] >> 1 ^
                      ~(locals[811] >> 1) & locals[787] >> 1;
        locals[781] = (~(locals[816] & locals[301] & 0xaaaaaaaa) ^ locals[800]) & locals[704] ^ locals[301] ^
                      0xaaaaaaaa;
        locals[260] = (~locals[704] & locals[301] ^ locals[704]) & 0x55555555 ^ locals[800];
        locals[636] = locals[776] ^ locals[761] ^ locals[787] ^ locals[811];
        locals[779] = (locals[787] ^ ~locals[776]) & locals[811];
        locals[813] = ~locals[787];
        locals[749] =
            ((locals[776] ^ locals[811]) & locals[761] ^ ~(locals[802] & locals[636]) ^ locals[776] ^ locals[779]) &
            locals[812] ^
            locals[802];
        locals[55] =
            ~(((locals[759] ^ locals[629]) & locals[55] ^ locals[782] & locals[331] ^ locals[815] ^ locals[629]) &
              locals[562]) ^
            (~(~locals[629] & locals[55]) ^ ~locals[782] & locals[331]) & locals[759] ^ locals[55];
        locals[779] = (~((locals[787] ^ ~locals[812]) & locals[776]) ^ locals[812]) & locals[811] ^
                      (locals[776] & locals[813] ^ locals[787] ^ locals[779]) & locals[802] ^
                      (locals[811] ^ ~locals[776]) & locals[812] & locals[761] ^ locals[776] & ~locals[812];
        locals[776] = ~((locals[812] & locals[636] ^ locals[811] & locals[813]) & locals[802]) ^
                      (locals[812] & locals[813] ^ locals[787]) & locals[811] ^ locals[776];
        locals[815] = locals[747] & (~locals[726] ^ locals[336]);
        locals[811] = ((locals[747] ^ locals[749] ^ locals[726] ^ locals[336]) & locals[776] ^
                       (locals[749] ^ locals[726] ^ locals[336]) & locals[747] ^
                       locals[749] & (~locals[726] ^ locals[336])) & locals[779] ^
                      (~((locals[726] ^ locals[336] ^ ~locals[747]) & locals[776]) ^ locals[747] ^ locals[726] ^
                       locals[336]) & locals[749] ^
                      locals[336] ^ locals[815];
        locals[636] = locals[776] & (locals[747] ^ locals[336]);
        locals[331] = (locals[749] & (locals[747] ^ locals[336]) ^ ~locals[636]) & locals[779] ^
                      ~(~locals[336] & locals[747]) & locals[726] ^
                      (locals[747] ^ locals[336] ^ locals[636]) & locals[749];
        locals[336] =
            ((~locals[749] ^ locals[726]) & locals[776] ^ locals[749] & locals[726] ^ locals[336] ^ locals[815]) &
            locals[779] ^
            (~locals[776] & locals[749] ^ locals[336] & ~locals[747]) & locals[726] ^ locals[747] ^ locals[336];
        locals[815] = locals[55] ^ locals[772];
        locals[636] = locals[331] & locals[815];
        locals[636] = (locals[811] & locals[815] ^ ~locals[636] ^ locals[55] ^ locals[772]) & locals[336] ^
                      (locals[55] ^ locals[772] ^ locals[636]) & locals[811] ^ locals[55] ^ locals[636];
        locals[779] = ~locals[55];
        locals[813] = locals[772] ^ locals[779];
        locals[812] = locals[796] & locals[813];
        locals[787] = (locals[331] & locals[813] ^ locals[55] ^ locals[772] ^ ~(locals[336] & locals[813])) &
                      locals[811] ^
                      (locals[55] ^ locals[772] ^ ~(locals[336] & locals[813])) & locals[331] ^ locals[336] ^
                      locals[55] ^ locals[812];
        locals[331] = (~((locals[331] ^ locals[55]) & locals[811]) ^ (locals[331] ^ locals[772]) & locals[55] ^
                       locals[772] ^ locals[812]) &
                      locals[336] ^
                      (~locals[331] & locals[811] ^ locals[772] & locals[796] ^ locals[331]) & locals[55] ^
                      locals[772];
        locals[811] = ~locals[331];
        locals[802] = (~((((locals[331] ^ locals[55]) & locals[787] ^ locals[331] ^ locals[55]) & locals[772] ^
                          (~(locals[787] & locals[779]) ^ locals[55]) & locals[331]) & locals[796]) ^
                       ~((~(~locals[787] & locals[772]) ^ locals[787]) & locals[55]) & locals[331] ^ locals[772]) &
                      locals[636] ^
                      (locals[55] & locals[796] & locals[787] & locals[811] ^ locals[331]) & locals[772];
        locals[749] = ~locals[636] ^ locals[331];
        locals[761] = ~(((~(locals[55] & locals[749]) ^ locals[636] ^ locals[331] ^ locals[772] & locals[749]) &
                         locals[796] ^
                         (~(locals[772] & locals[749]) ^ locals[636] ^ locals[331]) & locals[55]) & locals[787]) ^
                      ((locals[55] & ~locals[772] ^ ~locals[812]) & locals[331] ^ locals[772]) & locals[636] ^
                      locals[331] & ~locals[772];
        locals[773] = ((~(locals[331] & locals[813]) ^ locals[55] ^ locals[772]) & locals[796] ^
                       (~(locals[772] & locals[811]) ^ locals[331]) & locals[55]) & locals[636] ^ locals[331] ^
                      locals[772];
        locals[776] = ~((~((locals[462] ^ locals[761] ^ locals[802]) & locals[773]) ^
                         (~locals[773] ^ locals[462]) & locals[789] ^ locals[761]
            ) & locals[793]) ^ (~locals[789] & locals[462] ^ locals[802]) & locals[773] ^ locals[789];
        locals[813] = (~locals[761] ^ locals[802]) & locals[773];
        locals[812] = locals[773] & (locals[761] ^ locals[802]);
        locals[782] = (~locals[813] ^ locals[761] ^ locals[462]) & locals[793] ^
                      (locals[761] ^ locals[462] ^ locals[813]) & locals[789] ^
                      locals[761] ^ locals[462] ^ locals[812];
        locals[773] = (~locals[812] ^ locals[761]) & locals[789] ^ (locals[761] ^ locals[812]) & locals[793] ^
                      locals[773];
        locals[813] = locals[773] ^ locals[776];
        locals[812] = locals[782] & (locals[813] ^ 0xaaaaaaaa);
        locals[462] = (locals[773] ^ locals[776] ^ locals[812] ^ 0x55555555) & locals[800];
        locals[793] =
            ((locals[704] & (locals[813] ^ 0xaaaaaaaa) ^ locals[773] ^ locals[776] ^ 0xaaaaaaaa) & locals[782] ^
             (locals[813] ^ 0x55555555) & locals[704] ^ locals[773] ^ locals[776] ^ locals[462] ^ 0x55555555) &
            locals[301]
            ^ (locals[773] ^ locals[776] ^ locals[462] ^ locals[812] ^ 0x55555555) & locals[704] ^
            (locals[782] & 0xaaaaaaaa ^ 0x55555555) & locals[776] ^ ~locals[782] & locals[773] & 0xaaaaaaaa;
        locals[812] = locals[782] & locals[813];
        locals[800] = (locals[773] ^ locals[812] ^ 0xaaaaaaaa) & locals[800];
        locals[761] = ((locals[704] & locals[813] ^ locals[773] ^ locals[776]) & locals[782] ^
                       (locals[773] ^ 0xaaaaaaaa) & locals[704] ^
                       locals[773] ^ locals[800] ^ 0xaaaaaaaa) & locals[301] ^
                      ((locals[776] ^ 0xaaaaaaaa) & locals[782] ^ locals[776] ^ 0xaaaaaaaa) & locals[773] ^
                      (locals[773] ^ locals[800] ^ locals[812] ^ 0xaaaaaaaa) & locals[704] ^
                      (locals[782] ^ 0x55555555) & locals[776]
                      ^ 0x55555555;
        locals[301] = (locals[816] ^ locals[704]) & locals[301];
        locals[704] = ((locals[720] ^ locals[301]) & 0xaaaaaaaa ^ locals[773] ^ locals[776]) & locals[782] ^
                      (locals[816] & locals[704] ^ locals[301] ^ 0xaaaaaaaa) & locals[776] ^ locals[773] ^ 0x55555555;
        locals[816] = ~locals[773];
        locals[720] = (~(locals[782] & ~locals[776]) ^ locals[776]) & locals[773];
        locals[301] = ~((~(((~((locals[331] ^ locals[816]) & locals[636]) ^ locals[331] & locals[816] ^ locals[773]) &
                            locals[782] ^
                            locals[773] & locals[749]) & locals[776]) ^
                         ~(locals[331] & ~locals[782] & locals[773]) & locals[636] ^ locals[331]
            ) & locals[787]) ^ ~locals[720] & locals[636] ^ locals[773] ^ locals[812];
        locals[764] = ((locals[776] ^ locals[331]) & locals[787] ^ locals[773] ^ locals[776] ^ locals[812]) &
                      locals[636] ^
                      (~(locals[782] & locals[816]) ^ locals[773] ^ locals[787] & locals[811]) & locals[776];
        locals[816] = ~locals[704];
        locals[813] = (locals[761] ^ locals[816]) & locals[793];
        locals[462] = locals[813] & 0xffff0000 ^ 0xffff;
        locals[812] = locals[704] ^ locals[761];
        locals[758] = ~locals[813] & 0xffff ^ locals[761] & locals[816];
        locals[802] = locals[758] & locals[462];
        locals[769] = locals[802] >> 1;
        locals[800] = (locals[761] & locals[816]) >> 0x11;
        locals[794] = ~(locals[813] >> 0x11 & ~locals[800]) & locals[812] >> 0x11 ^ locals[800] ^ 0xffff8000;
        locals[749] = (~(locals[782] & locals[811]) ^ locals[331]) & locals[773];
        locals[720] = ((~(((locals[773] ^ locals[331]) & locals[776] ^ locals[773] & locals[811]) & locals[782]) ^
                        (locals[331] ^ ~locals[776]) & locals[773] ^ locals[776] ^ locals[331]) & locals[787] ^
                       locals[776] ^ locals[720]) &
                      locals[636] ^ (~((~locals[749] ^ locals[331]) & locals[776]) ^ locals[331] ^ locals[749]) &
                      locals[787] ^
                      locals[720];
        locals[462] = locals[758] ^ locals[462];
        locals[787] = locals[462] >> 1;
        locals[776] = ~((locals[812] & locals[813]) >> 0x11 & ~locals[800]) ^ ~(locals[812] >> 0x11) & locals[800];
        locals[782] = (locals[812] & 0xffff0000 & locals[462] ^ locals[758]) >> 1;
        locals[773] = locals[462] >> 0x11 ^ 0xffff8000;
        locals[749] = ((locals[301] ^ locals[55]) & locals[772] ^ locals[301] & locals[779]) & locals[796] ^
                      ((locals[720] ^ locals[764] ^ locals[772]) & locals[301] ^ locals[720] ^ locals[764] ^
                       locals[772]) & locals[55] ^
                      locals[720] ^ locals[301];
        locals[636] = locals[720] ^ locals[301];
        locals[800] = ~((locals[636] & locals[815] ^ locals[720] ^ locals[301]) & locals[796]) ^
                      (~locals[301] & locals[764] ^ locals[301]) & locals[720] ^
                      ~(locals[772] & locals[636]) & locals[55];
        locals[815] = locals[55] ^ ~locals[720];
        locals[331] = (~(locals[772] & locals[815]) ^ locals[720] & locals[779] ^ locals[55]) & locals[796] ^
                      (~((locals[301] ^ locals[772]) & locals[55]) ^ locals[301]) & locals[720] ^
                      (~(locals[301] & locals[815]) ^ locals[720] ^ locals[55]) & locals[764] ^
                      locals[301] & locals[55];
        locals[815] = locals[331] ^ ~locals[749];
        locals[779] = ~(locals[683] & locals[815]) ^ locals[749] ^ locals[331];
        locals[813] = ~locals[683];
        locals[796] = ~((locals[749] & locals[331] ^ (locals[260] ^ locals[781]) & locals[779]) & locals[800]) ^
                      ~((~(locals[683] & (locals[260] ^ locals[781])) ^ locals[260] ^ locals[781]) & locals[331]) &
                      locals[749] ^
                      (locals[260] & locals[813] ^ locals[749] ^ locals[683]) & locals[781];
        locals[779] = ((~(locals[331] & locals[813]) ^ locals[683]) & locals[749] ^ locals[800] & locals[779]) &
                      locals[260];
        locals[811] = (~(locals[331] & ~locals[749]) ^ locals[749]) & locals[800];
        locals[813] = ~((~(locals[800] & locals[813]) ^ locals[683]) & locals[331]) ^ locals[683];
        locals[772] = ~((locals[683] & locals[811] ^ ~locals[779]) & locals[781]) ^
                      ~(locals[260] & locals[813]) & locals[749];
        locals[813] = ~((~locals[811] & locals[683] ^ locals[779]) & locals[781]) ^
                      (~(locals[749] & locals[813]) ^ locals[683]) & locals[260]
                      ^ ~locals[331] & locals[749] ^ locals[800] & locals[815];
        locals[815] = ~locals[813];
        locals[683] = ((locals[301] ^ ~locals[720]) & locals[764] ^ (locals[813] ^ locals[720]) & locals[796] ^
                       locals[720] & locals[815]) &
                      locals[772] ^
                      (locals[301] & locals[764] ^ locals[796] & locals[815] ^ locals[813]) & locals[720] ^
                      locals[301];
        locals[779] = ~locals[772];
        locals[764] = (~((locals[720] ^ locals[815]) & locals[772]) ^ locals[813] ^ locals[720] & locals[815]) &
                      locals[796] ^
                      ((locals[813] ^ locals[764]) & locals[720] ^ locals[813] ^ locals[764]) & locals[772] ^
                      ((locals[720] ^ locals[779]) & locals[764] ^ locals[772] ^ locals[720]) & locals[301] ^
                      (locals[764] ^ locals[815]) & locals[720] ^ locals[813] ^ locals[764];
        locals[781] = ((locals[772] ^ locals[813]) & locals[636] ^ locals[720] ^ locals[301]) & locals[796] ^
                      (~(locals[813] & locals[636]) ^ locals[720] ^ locals[301]) & locals[772] ^ locals[720] ^
                      locals[813] & locals[636];
        locals[260] = (~(~(locals[683] & 0xffff0000) & locals[781]) ^ locals[683]) & locals[764] ^ locals[683];
        locals[815] = (~locals[781] ^ locals[683]) & locals[764];
        locals[815] = (locals[813] & locals[779] ^ locals[781] ^ locals[683] ^ locals[815]) & locals[796] ^
                      (locals[781] ^ locals[683] ^ locals[815]) & locals[813] ^ locals[772] ^ locals[683] ^ locals[815];
        locals[720] = ~locals[764];
        locals[636] = ~(locals[683] & locals[720]);
        locals[758] = ~(((locals[813] ^ locals[779]) & locals[796] ^ locals[764] & (locals[772] ^ locals[683]) ^
                         locals[772] ^ locals[683] ^
                         locals[813]) & locals[781]) ^
                      (~locals[796] & locals[813] ^ locals[764] ^ locals[636]) & locals[772] ^ locals[796] ^
                      locals[813];
        locals[779] = (locals[772] ^ locals[796] ^ locals[813]) & locals[764];
        locals[779] = ~((~((locals[813] ^ locals[772] ^ locals[683]) & locals[764]) ^
                         (locals[772] ^ locals[813] ^ locals[720]) & locals[796]
                         ^ locals[772] ^ locals[683] ^ locals[813]) & locals[781]) ^
                      (locals[772] ^ locals[796] ^ locals[813] ^ locals[779]) & locals[683] ^ locals[796] ^
                      locals[813] ^ locals[779];
        locals[796] = ((locals[764] ^ 0xffff) & locals[683] ^ 0xffff) & locals[781];
        locals[813] = ~locals[758];
        locals[766] = (~(~(locals[758] & 0xffff0000) & locals[815]) ^ locals[758]) & locals[779] ^
                      locals[815] & locals[813];
        locals[772] =
            (~(~locals[683] & locals[764]) ^ (locals[764] ^ locals[683] & locals[720]) & locals[781]) & 0xffff ^
            locals[683];
        locals[759] = ~(locals[772] << 0xf) & locals[260] << 0xf ^ locals[772] << 0xf & ~(locals[796] << 0xf);
        locals[811] = ~((locals[683] ^ locals[720]) & locals[758]) ^ locals[764] ^ locals[683];
        locals[789] = ((~(locals[683] & (~locals[779] ^ locals[758])) ^ locals[779] ^ locals[758]) & locals[815] ^
                       locals[779] & locals[811])
                      & locals[781] ^
                      (~((~(locals[758] & locals[720]) ^ locals[764]) & locals[683]) ^ locals[764] ^
                       locals[758] & locals[720]) & locals[779]
                      ^ locals[758] ^ locals[683];
        locals[774] = (locals[796] ^ locals[260]) << 0xf;
        locals[301] = locals[796] >> 1;
        locals[762] = ~(locals[260] >> 1 & ~locals[301]) & locals[772] >> 1 ^ locals[301] ^ 0x80000000;
        locals[749] = ((locals[758] ^ 0xffff) & locals[815] ^ locals[813] & 0xffff) & locals[779];
        locals[331] = locals[815] & 0xffff ^ locals[749];
        locals[775] = locals[331] ^ locals[758] & 0xffff0000;
        locals[791] = locals[260] << 0xf & ~(locals[796] << 0xf);
        locals[768] = ~locals[791];
        locals[331] = locals[331] << 0x10;
        locals[765] = ~((locals[766] & locals[749]) << 0x10) ^ locals[331];
        locals[809] = (locals[775] & locals[749]) << 0x10 ^ ~(locals[749] << 0x10) & locals[766] << 0x10;
        locals[800] = locals[764] & (~locals[779] ^ locals[758]);
        locals[720] = ((~(locals[683] & (locals[815] ^ locals[813])) ^ locals[815] & locals[720] ^ locals[758]) &
                       locals[779] ^
                       locals[815] & locals[811] ^ locals[758] ^ locals[683]) & locals[781] ^
                      (~((~locals[800] ^ locals[779] ^ locals[758]) & locals[683]) ^ locals[779] ^ locals[758] ^
                       locals[800]) & locals[815] ^
                      (locals[758] ^ locals[683]) & locals[779] ^ locals[758] ^ locals[683];
        locals[636] = (~(((locals[779] & (locals[815] ^ locals[813]) ^ locals[815] & locals[813]) & locals[683] ^
                          locals[779] & locals[758] & locals[815]) & locals[764]) ^ locals[758] ^ locals[683]) &
                      locals[781] ^
                      (~((locals[764] ^ locals[636]) & locals[758] & locals[815]) ^ locals[758] ^ locals[683]) &
                      locals[779];
        locals[779] =
            (~((locals[704] ^ locals[793] ^ locals[636] ^ locals[720]) & locals[761]) ^ locals[704] ^ locals[720]) &
            locals[789] ^
            (locals[816] ^ locals[720]) & locals[761] ^ locals[793] ^ locals[720];
        locals[331] = ~(~(locals[766] << 0x10) & locals[749] << 0x10) ^ locals[331];
        locals[816] = locals[789] & (~locals[636] ^ locals[720]);
        locals[683] = (locals[704] ^ locals[816] ^ locals[720]) & locals[793] ^
                      (~locals[816] ^ locals[720]) & locals[704] ^ locals[789] ^
                      locals[761];
        locals[813] = ((locals[774] ^ locals[809] ^ locals[765] ^ locals[768]) & locals[759] ^
                       (locals[774] ^ locals[768]) & (~locals[809] ^ locals[765]) ^ locals[809]) & locals[331] ^
                      (~locals[759] ^ locals[774] ^ locals[768]) & locals[809] ^ locals[759] ^ locals[774];
        locals[811] = (locals[796] ^ locals[260]) >> 1 ^ 0x80000000;
        locals[800] = ~(locals[772] >> 1) & locals[301] ^ (locals[772] & locals[260]) >> 1 & ~locals[301];
        locals[816] = ~locals[811] ^ locals[800] ^ locals[775];
        locals[301] = (~((locals[816] ^ locals[749]) & locals[766]) ^ locals[749]) & locals[762] ^
                      locals[766] & locals[816] ^ locals[800];
        locals[815] = ~locals[779];
        locals[816] = (locals[815] ^ locals[683]) &
                      (~(((locals[761] ^ locals[636] ^ locals[720]) & locals[793] ^
                          (locals[704] ^ locals[636] ^ locals[720]) & locals[761] ^
                          locals[704] & (~locals[636] ^ locals[720]) ^ locals[636]) & locals[789]) ^
                       (locals[793] ^ locals[812]) & locals[720]
                       ^ (locals[761] ^ locals[793]) & locals[704] ^ locals[793]);
        locals[815] = locals[815] & locals[683];
        locals[636] = locals[815] & 0xffff ^ locals[816];
        locals[812] = (~((~locals[766] ^ locals[800]) & locals[762]) ^ locals[766] ^ locals[800]) & locals[811] ^
                      ((locals[775] ^ locals[762] ^ locals[749]) & locals[766] ^ locals[749]) & locals[800] ^
                      ~locals[749] & locals[766] ^
                      locals[762] ^ locals[749];
        locals[720] = (locals[775] ^ locals[749]) & locals[766];
        locals[766] = (locals[811] & locals[800] ^ locals[720] ^ locals[749]) & locals[762] ^
                      (~locals[720] ^ locals[811] ^ locals[749]) & locals[800] ^ locals[766];
        locals[720] = ~(locals[815] & 0xffff0000);
        locals[811] =
            ((locals[774] ^ locals[331]) & locals[759] ^ ~((~locals[809] ^ locals[765]) & locals[331]) ^ locals[809]) &
            locals[768]
            ^ (~locals[774] & locals[759] ^ locals[765]) & locals[331] ^ locals[759] ^ locals[774];
        locals[683] = (locals[683] & 0xffff ^ 0xffff0000) & locals[779] ^ locals[816] & 0xffff ^ locals[683];
        locals[815] = (locals[809] ^ locals[765]) & locals[331];
        locals[768] = ~((locals[791] & locals[774] ^ locals[815] ^ locals[809]) & locals[759]) ^
                      (~locals[815] ^ locals[809] ^ locals[768]) & locals[774] ^ locals[331] ^ locals[768];
        locals[815] = (~locals[636] ^ locals[720]) & locals[683];
        locals[749] = (locals[815] ^ locals[769] ^ locals[720]) & locals[782] ^
                      (~locals[815] ^ locals[720]) & locals[769] ^ locals[815] ^
                      locals[636] ^ locals[720];
        locals[800] = ~((locals[683] ^ locals[720]) >> 0x10) & locals[816] >> 0x10 ^ 0xffff0000;
        locals[331] = (~locals[815] ^ locals[787] ^ locals[636] ^ locals[720]) & locals[782] ^
                      (locals[815] ^ locals[787] ^ locals[636] ^ locals[720]) & locals[769] ^ locals[636];
        locals[769] = (~locals[683] & locals[720] ^ (locals[462] & locals[802]) >> 1) & locals[636] ^
                      ((~locals[769] ^ locals[636]) & locals[787] ^ locals[815] ^ locals[636] ^ locals[720]) &
                      locals[782] ^ locals[769];
        locals[815] = locals[769] ^ locals[811];
        locals[462] = ~((locals[769] & ~locals[811] ^ locals[813] & locals[815]) & locals[768]) ^
                      ((locals[749] ^ locals[813]) & locals[769] ^ locals[749] ^ locals[813]) & locals[811] ^
                      locals[331] & locals[749] & locals[815];
        locals[636] = ~((locals[683] & locals[636] & locals[720]) >> 0x10) & 0xffff;
        locals[796] = ~(locals[816] >> 0x10) ^ locals[720] >> 0x10;
        locals[779] = ~((locals[773] & (~locals[636] ^ locals[796]) ^ locals[636] ^ locals[796]) & locals[776]) ^
                      (~(locals[776] & (~locals[636] ^ locals[796])) ^ locals[636] ^ locals[796]) & locals[794] ^
                      locals[636];
        locals[816] = ~locals[776];
        locals[802] = ((locals[636] ^ locals[816]) & locals[800] ^ locals[776] ^ locals[636]) & locals[796] ^
                      ((locals[773] ^ locals[794] ^ locals[800]) & locals[776] ^ locals[794]) & locals[636] ^
                      locals[794] & locals[816] ^
                      locals[776];
        locals[769] = (~locals[331] ^ locals[769]) & locals[749] ^ (locals[813] ^ ~locals[811]) & locals[768] ^
                      ~locals[813] & locals[811] ^
                      locals[769];
        locals[720] = locals[769] & 0xc000c;
        locals[331] = ~((~locals[720] & locals[815] ^ locals[720]) & locals[462] & 0xcc00cc);
        locals[809] = ~(((locals[769] & 0x3000300 ^ 0x30003) & locals[462] ^ locals[769] & 0x30003) & locals[815]) ^
                      locals[769] & 0x30003;
        locals[792] = ~(~locals[462] & locals[815] & 0xc000c00) ^ locals[462] & 0xc000c000;
        locals[796] =
            ((~locals[773] ^ locals[794]) & locals[776] ^ (locals[796] ^ locals[816]) & locals[800] ^ locals[794]) &
            locals[636] ^
            (locals[796] & locals[800] ^ locals[773]) & locals[776] ^ locals[796];
        locals[793] = (~locals[769] & locals[815] ^ locals[769]) & 0xc000c0 ^ locals[462] & 0xc000c;
        locals[816] = ~(locals[769] & 0x300030) & locals[462];
        locals[772] = ((locals[816] ^ 0xffcfffcf) & locals[815] ^ locals[769] & 0x300030) & 0x30303030;
        locals[636] = locals[766] & (locals[802] ^ locals[779]);
        locals[787] = (locals[301] & (locals[802] ^ locals[779]) ^ ~locals[636]) & locals[812] ^
                      (locals[802] ^ locals[779] ^ locals[636]) & locals[301] ^
                      locals[796] & locals[779] & ~locals[802] ^ locals[802];
        locals[704] =
            ((locals[779] ^ locals[301]) & locals[766] ^ (locals[802] ^ locals[301]) & locals[779] ^ locals[301]) &
            locals[812] ^
            (~((locals[812] ^ ~locals[779]) & locals[802]) ^ locals[779] ^ locals[812]) & locals[796] ^
            (~(locals[766] & ~locals[779]) ^ locals[779]) & locals[301] ^ locals[802] ^ locals[779];
        locals[408] = (locals[769] ^ locals[815]) & 0x3000300;
        locals[761] = (~(locals[769] & 0xf3fff3ff) & locals[462] ^ locals[769] & 0xc000c00) & locals[815] & 0xcc00cc00 ^
                      (locals[462] & 0xc000c000 ^ 0xc000c00) & locals[769];
        locals[683] = ((~(locals[769] & 0xfffcfffc) & locals[462] ^ locals[769]) & locals[815] ^ locals[769]) &
                      0x3030303;
        locals[781] = ~(locals[815] & locals[816] & 0x30303030);
        locals[260] = ~(locals[462] & 0xf3fff3ff) & ~locals[815] & locals[769] & 0xcc00cc00;
        locals[776] = (locals[761] ^ locals[792]) >> 4;
        locals[782] = (locals[683] ^ locals[408]) >> 6;
        locals[773] = ((locals[720] ^ 0xc000c0) & locals[462] ^ locals[769] & 0xcc00cc) & locals[815] ^
                      ~(locals[462] & 0xc000c) & locals[769] & 0xcc00cc;
        locals[758] = ((locals[462] & 0x300030 ^ locals[769]) & locals[815] ^ locals[769]) & 0x30303030;
        locals[760] = ~(~(locals[408] >> 6) & ~(locals[683] >> 6) & locals[809] >> 6) & 0x3ffffff;
        locals[779] = locals[779] ^ ~(((~locals[796] ^ locals[779] ^ locals[301]) & locals[802] ^
                                       (locals[301] ^ ~locals[802]) & locals[766] ^
                                       locals[796] ^ locals[779]) & locals[812]) ^
                      ~locals[766] & locals[802] & locals[301];
        locals[301] = ((locals[787] & 0xc000c00 ^ 0x30003000) & locals[779] ^ locals[787] & 0x3c003c00) & locals[704] ^
                      locals[779] & locals[787] & 0x3c003c00;
        locals[802] = ((locals[787] ^ 0xc000c00) & locals[779] ^ locals[787] & 0xf3fff3ff) & locals[704] & 0x3c003c00;
        locals[796] = ~((locals[408] ^ locals[809]) >> 6) & locals[683] >> 6 ^ locals[809] >> 6 ^ 0xfc000000;
        locals[794] = (locals[779] ^ locals[787]) & 0xc000c0;
        locals[764] = ((locals[787] & 0xff3fff3f ^ locals[704] ^ 0xc000c0) & locals[779] ^
                       (locals[704] ^ 0xc000c0) & locals[787])
                      & 0x3c003c0;
        locals[816] = (locals[779] ^ 0x30003) & locals[787];
        locals[759] = ~((locals[816] ^ 0xfffcfffc) & locals[704] & 0x330033) ^ locals[816] & 0x330033;
        locals[816] = (locals[704] ^ 0xc000c00) & locals[787];
        locals[789] = ~((locals[816] ^ 0xf3fff3ff) & locals[779] & 0x3c003c00) ^ locals[816] & 0x3c003c00;
        locals[774] = locals[779] & locals[787] & 0xc000c0;
        locals[814] = ~(locals[789] >> 6) & locals[301] >> 6;
        locals[812] = (locals[789] ^ locals[301]) >> 6;
        locals[811] = locals[792] >> 4;
        locals[762] = (locals[761] & locals[260]) >> 4 & ~locals[811] ^ ~(locals[260] >> 4) & locals[811];
        locals[816] = locals[301] << 4;
        locals[775] = ~(~((locals[789] & locals[802]) << 4) & locals[816]) ^ locals[802] << 4;
        locals[813] = locals[789] << 4;
        locals[791] = ~locals[813] ^ locals[816];
        locals[765] = (locals[772] & locals[758]) >> 2;
        locals[699] = ~locals[765];
        locals[813] = ~(~(~locals[816] & locals[813]) & locals[802] << 4) ^ locals[813];
        locals[408] = locals[408] << 2;
        locals[809] = locals[809] << 2;
        locals[766] = locals[809] ^ ~locals[408];
        locals[749] = locals[774] << 8;
        locals[768] = ~(locals[794] << 8) & locals[764] << 8 ^ locals[749];
        locals[811] = ~(~(locals[761] >> 4 & ~locals[811]) & locals[260] >> 4) ^ locals[811];
        locals[816] = locals[779] & ~locals[787];
        locals[769] = (locals[787] & 0xfffcfffc ^ locals[816]) & locals[704] & 0x330033;
        locals[462] = locals[764] >> 2;
        locals[755] = ~((locals[794] & locals[774]) >> 2) & locals[462] ^ locals[794] >> 2;
        locals[709] = ~((locals[764] & locals[794]) << 8) ^ locals[749];
        locals[815] = locals[792] ^ ~locals[260];
        locals[720] = locals[813] & locals[815];
        locals[636] = locals[792] & ~locals[260];
        locals[720] = ((locals[813] ^ locals[775]) & locals[815] ^ locals[260] ^ locals[792]) & locals[791] ^
                      (~locals[720] ^ locals[260] ^ locals[792]) & locals[775] ^
                      (locals[260] ^ locals[636]) & locals[761] ^ locals[260] ^
                      locals[792] ^ locals[720];
        locals[790] = ~((locals[773] ^ locals[793]) << 4) & 0xfffffff0;
        locals[748] = ~(((locals[813] ^ locals[260] ^ locals[761] ^ locals[792]) & locals[791] ^
                         (locals[792] ^ locals[260] ^ locals[761]) & locals[813] ^ locals[260] ^ locals[761] ^
                         locals[792]) & locals[775]) ^
                      ((locals[260] ^ locals[761] ^ ~locals[813]) & locals[791] ^ locals[813] ^ locals[260] ^
                       locals[761]) & locals[792] ^
                      (locals[791] & (locals[260] ^ locals[761]) ^ locals[260] ^ locals[761]) & locals[813] ^
                      locals[260];
        locals[827] = ((locals[793] ^ locals[331]) & locals[773] ^ locals[331]) << 8 ^ 0xff;
        locals[800] = locals[331] << 4;
        locals[788] = ~(~(locals[773] << 4) & locals[800]) & locals[793] << 4 ^ locals[800];
        locals[301] = locals[802] >> 6 & ~locals[812] ^ ~(locals[301] >> 6) & locals[789] >> 6;
        locals[815] = ~(locals[794] >> 2);
        locals[462] = ~(locals[815] & locals[462]) & locals[774] >> 2 ^ locals[462];
        locals[802] = ~(locals[773] << 8) & (locals[793] & locals[331]) << 8;
        locals[792] =
            ~((~((locals[813] ^ locals[761]) & locals[775]) ^ (locals[813] ^ locals[792]) & locals[761] ^ locals[636]) &
              locals[791]
                ) ^ (~(locals[775] & ~locals[813]) ^ locals[260] & locals[792] ^ locals[813]) & locals[761] ^
            locals[260] ^ locals[792]
            ;
        locals[331] = ~(~(locals[793] << 4) & locals[800]) & locals[773] << 4 ^ (locals[793] & locals[331]) << 4;
        locals[636] = ~(locals[758] >> 10);
        locals[800] = locals[772] >> 10;
        locals[761] = (~((locals[772] & locals[758]) >> 10) ^ locals[781] >> 10 & locals[636]) & 0x3fffff;
        locals[260] = ~(locals[758] >> 2) ^ locals[772] >> 2;
        locals[789] = (locals[816] & 0x30003 ^ 0x300030) & locals[704] ^ locals[787] & 0x30003;
        locals[775] = (locals[809] & ~locals[408] ^ locals[408]) & locals[683] << 2 ^ locals[809];
        locals[791] = (~((locals[772] & locals[781]) >> 10) & locals[758] >> 10 ^ ~locals[800]) & 0x3fffff;
        locals[813] = (locals[773] ^ locals[793]) << 8;
        locals[816] = ~(locals[764] << 8) & locals[749] ^ locals[794] << 8;
        locals[749] = ((~locals[816] ^ locals[331] ^ locals[790] ^ locals[768]) & locals[788] ^
                       locals[331] & ~locals[790] ^ locals[768]) &
                      locals[709] ^ (~(locals[788] & ~locals[790]) ^ locals[790]) & locals[331] ^
                      ~locals[788] & locals[768] ^ locals[790] ^
                      locals[788];
        locals[331] = ~(((locals[816] ^ locals[331] ^ locals[790] ^ locals[768]) & locals[788] ^
                         ~locals[331] & locals[790] ^ locals[816] ^
                         locals[331]) & locals[709]) ^ (~(locals[331] & locals[790]) ^ locals[768]) & locals[788] ^
                      locals[790];
        locals[790] = (~(locals[816] & (locals[790] ^ locals[788])) ^ locals[790] ^ locals[788]) & locals[709] ^
                      (locals[709] & (locals[790] ^ locals[788]) ^ locals[790] ^ locals[788]) & locals[768] ^
                      locals[790];
        locals[800] = ~(~(locals[800] & locals[636]) & locals[781] >> 10) ^ locals[800];
        locals[768] = (locals[789] & locals[769] & locals[759]) << 6;
        locals[636] = ~((~locals[704] & locals[779] & 0xc000c ^ 0xc000c000) & locals[787]) ^ locals[704] & 0xc000c;
        locals[815] = ~(locals[815] & locals[774] >> 2) ^ (locals[764] & locals[794]) >> 2;
        locals[793] = ((locals[779] ^ 0xc000c) & locals[704] & ~locals[787] ^ locals[787] & 0xfff3fff3) & 0xc00cc00c;
        locals[773] = ~((locals[769] ^ locals[759]) << 6) & locals[789] << 6;
        locals[794] = ~locals[773];
        locals[779] = ((locals[779] ^ 0xfff3fff3) & locals[704] ^ locals[779]) & locals[787] & 0xc00cc00c;
        locals[816] = locals[791] & (locals[800] ^ locals[761]);
        locals[787] = (~locals[814] & locals[812] ^ ~locals[816] ^ locals[761]) & locals[301] ^
                      (locals[761] ^ locals[816]) & locals[814] ^
                      locals[761];
        locals[704] =
            ((locals[815] ^ locals[755]) & (locals[796] ^ locals[760]) ^ locals[796] ^ locals[760]) & locals[462] ^
            locals[815] ^
            locals[796];
        locals[764] = locals[769] << 6 ^ ~(locals[789] << 6);
        locals[774] = (~((~locals[462] ^ locals[782]) & locals[760]) ^ locals[462] ^ locals[782]) & locals[815] ^
                      ((~locals[815] ^ locals[760]) & locals[782] ^ locals[815] ^ locals[760]) & locals[796] ^
                      ~((~locals[815] ^ locals[760]) & locals[755]) & locals[462] ^
                      (locals[462] ^ locals[782]) & locals[760] ^ locals[782];
        locals[408] = ~(~locals[809] & locals[408]) & locals[683] << 2 ^ locals[408];
        locals[760] = ~((~((locals[755] ^ locals[796]) & locals[462]) ^ (~locals[796] ^ locals[760]) & locals[782]) &
                        locals[815]) ^
                      (~locals[755] & locals[462] ^ locals[782] & locals[760]) & locals[796] ^ locals[760];
        locals[462] = ~(locals[793] << 0xc) & (locals[779] & locals[636]) << 0xc;
        locals[815] = locals[636] ^ ~locals[779];
        locals[796] = (~(locals[815] & locals[811]) ^ locals[815] & locals[762]) & locals[793] ^
                      (~locals[762] & locals[776] ^ locals[762]) & locals[811] ^
                      (locals[811] ^ locals[762]) & locals[779] & locals[636];
        locals[683] = ((~locals[814] ^ locals[812]) & locals[761] ^ locals[816] ^ locals[814] ^ locals[812]) &
                      locals[301] ^
                      ~locals[800] & locals[791] & locals[761] ^ locals[814];
        locals[782] = ((locals[779] ^ locals[636] ^ locals[762] ^ locals[776]) & locals[811] ^
                       locals[636] & ~locals[779] ^ locals[779]) &
            locals[793] ^ (~(locals[779] & locals[636]) ^ locals[762] ^ locals[776]) & locals[811] ^ locals[762];
        locals[762] = (~((locals[779] ^ locals[762]) & locals[636]) ^ (locals[779] ^ locals[811]) & locals[762]) &
                      locals[793] ^
                      ~((~locals[793] ^ locals[762]) & locals[776]) & locals[811] ^
                      locals[779] & locals[636] & ~locals[762];
        locals[811] = (~(locals[769] << 2) & locals[789] << 2 ^ ~(locals[759] << 2)) & 0xfffffffc;
        locals[776] = (locals[793] ^ locals[636]) << 0xc;
        locals[636] = ((locals[793] ^ locals[779]) & locals[636]) << 0xc ^ 0xfff;
        locals[814] = ((locals[800] ^ locals[761]) & locals[814] ^ locals[800] ^ locals[761]) & locals[791] ^
                      (locals[814] & locals[812] ^ locals[816]) & locals[301] ^ locals[761] ^ locals[814];
        locals[816] = (locals[802] ^ locals[827]) & locals[813];
        locals[815] = ~locals[816];
        locals[779] = (locals[636] & locals[776] ^ locals[815] ^ locals[827]) & locals[462] ^
                      (locals[776] ^ locals[816] ^ locals[827]) & locals[636] ^ locals[776];
        locals[761] = (~locals[462] & locals[776] ^ locals[815] ^ locals[827]) & locals[636] ^
                      (locals[462] ^ locals[815] ^ locals[827]) & locals[776] ^ locals[462];
        locals[816] = locals[796] & (locals[782] ^ locals[762]);
        locals[812] = ((locals[814] ^ locals[683] ^ locals[762]) & locals[782] ^ locals[816]) & locals[787] ^
                      ~(locals[796] & ~locals[782]) & locals[762] ^ locals[814];
        locals[800] = ~(((locals[760] ^ locals[774]) & (locals[792] ^ locals[720]) ^ locals[792] ^ locals[720]) &
                        locals[704]) ^
                      ~(locals[774] & (locals[792] ^ locals[720])) & locals[760] ^ locals[792] ^ locals[748] ^
                      locals[720];
        locals[813] = (~locals[776] ^ locals[462]) & locals[813];
        locals[776] = (~locals[813] ^ locals[776] ^ locals[462]) & locals[827] ^ locals[813] & locals[802] ^
                      locals[636] ^ locals[776];
        locals[813] = (~(locals[794] & (~locals[408] ^ locals[766])) ^ locals[768] & (~locals[408] ^ locals[766])) &
                      locals[775] ^
                      ((locals[794] ^ locals[768]) & locals[408] ^ locals[794] ^ locals[768]) & locals[766] ^
                      ~(~locals[768] & locals[764]) & locals[794];
        locals[699] = ~((~(~(locals[759] << 2) & locals[769] << 2) ^ locals[811] ^ locals[789] << 2) &
                        (locals[769] & locals[759] ^ locals[789]) << 2) ^
                      ~(((locals[758] ^ locals[772]) & locals[781]) >> 2) & (locals[260] ^ locals[699]) ^
                      locals[765] & locals[260] ^
                      locals[811] ^ locals[699];
        locals[811] = (~((locals[773] ^ locals[768]) & locals[775]) ^ locals[794] ^ locals[768]) & locals[766] ^
                      ((locals[775] ^ locals[766]) & (locals[794] ^ locals[768]) ^ locals[775] ^ locals[766]) &
                      locals[408] ^
                      ~(locals[764] & locals[794]) & locals[768] ^ locals[775];
        locals[768] = ((locals[773] ^ locals[766]) & locals[775] ^ locals[794] & locals[766]) & locals[408] ^
                      ((~locals[764] ^ locals[768] ^ locals[766]) & locals[775] ^ locals[764] ^ locals[768] ^
                       locals[766]) & locals[794] ^
                      locals[768];
        locals[462] = ~((locals[749] ^ locals[790]) & locals[699]) & locals[331] ^ locals[749];
        locals[815] = (~locals[768] ^ locals[811]) & locals[813];
        locals[301] = ((locals[768] ^ locals[779]) & locals[776] ^ locals[768] & ~locals[779] ^ locals[815]) &
                      locals[761] ^
                      (~(~locals[779] & locals[776]) ^ locals[811] & locals[813] ^ locals[779]) & locals[768] ^
                      locals[811] ^ locals[779];
        locals[636] = ~locals[813] ^ locals[776] ^ locals[779];
        locals[802] = (~(locals[768] & locals[636]) ^ locals[811] & locals[636] ^ locals[813]) & locals[761] ^
                      ((locals[768] ^ locals[811]) & locals[779] ^ locals[768] ^ locals[811]) & locals[776] ^
                      (locals[768] ^ locals[811] ^ locals[815]) & locals[779] ^ locals[811];
        locals[793] = ~(~locals[749] & locals[331] & locals[790]) ^ locals[699] ^ locals[790];
        locals[815] = ~locals[811];
        locals[761] = (~((locals[815] ^ locals[779]) & locals[761]) ^ locals[815] & locals[779] ^ locals[811]) &
                      locals[776] ^
                      (~((~locals[813] ^ locals[761]) & locals[811]) ^ locals[813]) & locals[779] ^
                      ((locals[815] ^ locals[779]) & locals[813] ^ locals[811] ^ locals[779]) & locals[768] ^
                      locals[815] & locals[813] ^
                      locals[811] ^ locals[761];
        locals[815] = ~locals[774];
        locals[636] = locals[815] ^ locals[748];
        locals[779] = ((locals[748] ^ locals[720]) & locals[792] ^ (locals[815] ^ locals[720]) & locals[748]) &
                      locals[760] ^
                      (~(locals[636] & locals[760]) ^ locals[815] & locals[748] ^ locals[774]) & locals[704] ^
                      ~(~locals[748] & locals[720]) & locals[792] ^ locals[720];
        locals[790] = ((~locals[749] ^ locals[790]) & locals[699] ^ locals[749]) & locals[331] ^
                      (locals[699] ^ locals[790]) & locals[749] ^
                      locals[699] ^ locals[790];
        locals[813] = ~((~((locals[782] ^ locals[683] ^ locals[762]) & locals[814]) ^
                         (locals[683] ^ locals[796] ^ ~locals[782]) & locals[762]
                         ^ (locals[683] ^ locals[796]) & locals[782]) & locals[787]) ^
                      (~locals[762] & locals[782] ^ locals[816]) & locals[814]
                      ^ locals[782];
        locals[794] = (~locals[462] & locals[790] ^ ~(locals[462] & 0xbbbbbbbb)) & locals[793] & 0xcccccccc ^
                      0x77777777;
        locals[762] = ~((~locals[814] ^ locals[762]) & locals[683]) & locals[787] ^
                      ~((locals[814] & (locals[782] ^ locals[762]) ^ ~locals[762] & locals[782]) & locals[796]) ^
                      ~((locals[782] ^ locals[787]) & locals[762]) & locals[814] ^ locals[782] ^ locals[762];
        locals[811] = (locals[761] & locals[301] & 0x44444444 ^ 0x88888888) & locals[802];
        locals[816] = ((locals[774] ^ locals[792] ^ locals[748] ^ locals[720]) & locals[760] ^
                       (locals[792] ^ locals[748] ^ locals[720]) & locals[774] ^ locals[792] ^ locals[748] ^
                       locals[720]) & locals[704] ^
                      ((locals[636] ^ locals[720]) & locals[792] ^ locals[636] & locals[720] ^
                       locals[815] & locals[748] ^ locals[774]) &
                      locals[760] ^ ~(locals[792] & locals[720]) & locals[748];
        locals[749] =
            (((locals[779] ^ 0x44444444) & locals[816] ^ 0x44444444) & locals[800] ^ locals[816] & 0x44444444) &
            0xcccccccc ^ (locals[816] & 0x44444444 ^ 0x88888888) & locals[779];
        locals[331] = ~((locals[800] & ~locals[816] & 0x44444444 ^ 0x88888888) & locals[779]);
        locals[796] = (~locals[793] & locals[790] & 0x44444444 ^ 0x88888888) & locals[462] ^ 0xbbbbbbbb;
        locals[636] = ~((~locals[813] & 0x44444444 ^ locals[812]) & locals[762] & 0xcccccccc) ^
                      (locals[812] ^ 0x44444444) & locals[813] & 0xcccccccc;
        locals[800] = ((locals[779] & ~locals[816] ^ ~(locals[816] & 0xbbbbbbbb)) & locals[800] ^
                       ~locals[779] & locals[816] & 0xbbbbbbbb) & 0xcccccccc;
        locals[462] = (~locals[790] & locals[462] & 0x88888888 ^ 0x44444444) & locals[793] ^
                      locals[790] & locals[462] & 0x88888888;
        locals[812] = locals[794] >> 1;
        locals[793] = ~(~((locals[794] & locals[462]) >> 1) & locals[796] >> 1) ^ locals[812];
        locals[816] = ~locals[802];
        locals[815] = ~locals[301];
        locals[779] = (((locals[802] ^ 0x44444444) & locals[301] ^ locals[816] & 0x44444444) & locals[761] ^
                       locals[802] & locals[815]
                       ^ 0x44444444) & 0xcccccccc;
        locals[301] = (locals[761] & locals[815] & locals[816] ^ ~(locals[301] & 0xcccccccc)) & 0x77777777 ^
                      locals[761] & locals[815] & locals[816];
        locals[815] = locals[811] >> 1;
        locals[720] = locals[779] >> 1;
        locals[802] = ~(~locals[815] & locals[720]) & locals[301] >> 1 ^ locals[815];
        locals[772] = (locals[331] ^ locals[749]) >> 1;
        locals[781] = ((locals[779] ^ locals[301]) & locals[811] ^ locals[301]) >> 1;
        locals[787] = ~(locals[813] & locals[762] & 0x88888888);
        locals[704] = (locals[813] ^ locals[762]) & 0x88888888;
        locals[816] = ~(locals[796] >> 1);
        locals[761] = locals[816] ^ locals[462] >> 1;
        locals[720] = ~((~locals[720] & locals[301] >> 1 ^ locals[720]) & locals[815]) ^ locals[720];
        locals[812] = ~(~(locals[816] & locals[812]) & locals[462] >> 1) ^ locals[812];
        locals[816] = ~locals[781];
        locals[683] = (~((locals[301] ^ locals[816]) & locals[720]) ^ locals[301] & locals[816] ^ locals[781]) &
                      locals[802] ^
                      (~((locals[720] ^ locals[779] ^ locals[811]) & locals[781]) ^ locals[779]) & locals[301] ^
                      locals[779] & locals[816] ^
                      locals[720];
        locals[802] = (~((locals[779] ^ locals[811] ^ locals[816]) & locals[301]) ^
                       (locals[781] ^ locals[301]) & locals[802] ^ locals[779]) &
            locals[720] ^ (~(locals[802] & locals[816]) ^ locals[781] ^ locals[811]) & locals[301] ^ locals[781];
        locals[781] = (locals[301] & (locals[720] ^ locals[781]) ^ locals[720] ^ locals[781]) & locals[779] ^
                      ~(locals[811] & (locals[720] ^ locals[781])) & locals[301] ^ locals[781];
        locals[816] = ~(locals[704] >> 1);
        locals[815] = locals[636] >> 1;
        locals[773] = ~(locals[787] >> 1 & locals[816]) & locals[815] ^ locals[704] >> 1;
        locals[720] = ~(~(locals[815] & locals[816]) & locals[787] >> 1) ^ locals[815];
        locals[815] = (~((locals[787] & locals[704]) >> 1) & locals[815] ^ locals[816]) & 0x7fffffff;
        locals[301] = (~((locals[815] ^ ~locals[636] ^ locals[720]) & locals[704]) ^
                       locals[787] & (locals[704] ^ locals[636]) ^ locals[636] ^
                       locals[815]) & locals[773] ^ (locals[787] & ~locals[636] ^ locals[720]) & locals[704] ^
                      locals[815] ^ locals[720];
        locals[260] = (locals[683] ^ locals[802]) & locals[781] ^ locals[683] & locals[802] ^ locals[559];
        locals[813] = (~locals[559] ^ locals[802]) & locals[683] ^ locals[559] & locals[802];
        locals[816] = locals[815] ^ locals[720];
        locals[776] = ~((~((~locals[704] ^ locals[815] ^ locals[720] ^ locals[773]) & locals[787]) ^
                         (~locals[815] ^ locals[720] ^ locals[773]) & locals[704] ^ locals[815] ^ locals[720] ^
                         locals[773]) & locals[636]) ^
                      ((locals[816] ^ locals[773]) & locals[787] ^ (~locals[815] ^ locals[720]) & locals[773] ^
                       locals[815]) & locals[704] ^
                      (~locals[720] ^ locals[773]) & locals[815] ^ locals[720];
        locals[782] = ~(((locals[559] ^ locals[802]) & locals[683] ^ ~locals[559] & locals[802]) & locals[781]) ^
                      ~(~locals[802] & locals[683]) & locals[559] ^ locals[802];
        locals[773] = (locals[704] & locals[816] ^ locals[815] ^ locals[720]) & locals[636] ^
                      locals[787] & locals[816] & (locals[704] ^ locals[636]) ^ ~locals[720] & locals[815] ^
                      locals[704] ^ locals[773];
        locals[816] = locals[785] ^ locals[770];
        locals[815] = locals[770] ^ ~locals[785];
        locals[720] = locals[797] & locals[815];
        locals[787] = ((~locals[781] ^ locals[802]) & locals[816] ^ locals[781] ^ locals[802]) & locals[683] ^
                      (~(locals[815] & locals[781]) ^ locals[785] ^ locals[770]) & locals[802] ^ locals[770] ^
                      locals[720];
        locals[815] = ~locals[796] ^ locals[794];
        locals[636] = ~((locals[761] ^ locals[794]) & locals[812]);
        locals[779] = locals[761] & ~locals[794];
        locals[704] = (locals[796] & ~locals[794] ^ ~(locals[793] & locals[815]) ^ locals[794]) & locals[462] ^
                      (locals[794] & ~locals[761] ^ locals[636]) & locals[793] ^ ~locals[779] & locals[812];
        locals[811] = locals[800] >> 1;
        locals[758] = ~((locals[749] & locals[800]) >> 1) & locals[331] >> 1 ^ locals[811];
        locals[636] = (locals[796] & locals[462] ^ locals[812] & ~locals[761]) & locals[794] ^
                      (locals[462] & locals[815] ^ locals[779] ^ locals[636]) & locals[793] ^ locals[812];
        locals[761] = (locals[782] ^ locals[813]) & 0x22222222;
        locals[794] =
            (~(locals[812] & locals[815]) ^ locals[796] ^ locals[794] ^ locals[793] & locals[815]) & locals[462] ^
            locals[812] ^
            locals[794];
        locals[755] = (locals[683] & locals[816] ^ locals[785] ^ locals[770]) & locals[802] ^
                      locals[816] & (locals[683] ^ locals[802]) & locals[781] ^ locals[683] ^ locals[785];
        locals[816] = locals[446] ^ locals[522];
        locals[815] = locals[585] & locals[816];
        locals[812] = (~locals[815] ^ locals[522] ^ locals[636]) & locals[704] ^
                      ~((locals[522] ^ locals[815] ^ locals[636]) & locals[794]) ^
                      locals[585];
        locals[770] =
            ~(((~locals[785] ^ locals[802]) & locals[781] ^ (locals[770] ^ locals[802]) & locals[785] ^ ~locals[720]) &
              locals[683])
            ^ (~locals[797] & locals[770] ^ ~locals[781] & locals[802]) & locals[785] ^ locals[770];
        locals[462] = locals[782] & locals[813] & locals[260] & 0x22222222 ^ 0xdddddddd;
        locals[802] = (~(locals[782] & 0x22222222) & locals[813] & locals[260] ^ ~locals[813] & locals[782]) &
                      0xaaaaaaaa ^
                      0x77777777;
        locals[811] = ~(~(~(locals[331] >> 1) & locals[811]) & locals[749] >> 1) ^ locals[811];
        locals[796] = ~(~(locals[802] >> 1) & locals[761] >> 1) ^ locals[462] >> 1;
        locals[813] = (locals[782] ^ locals[260]) & locals[813];
        locals[815] = (locals[755] & locals[770] ^ ~locals[813] ^ locals[782]) & locals[787];
        locals[793] = (locals[813] ^ locals[770] ^ locals[782]) & locals[755] ^ locals[815] ^ locals[770];
        locals[446] = ~locals[446];
        locals[785] = ((~locals[585] ^ locals[794]) & locals[636] ^ locals[585] ^ locals[794]) & locals[704] ^
                      ((locals[522] ^ locals[446] ^ locals[636]) & locals[585] ^ locals[522]) & locals[794] ^
                      ~locals[522] & locals[585] ^
                      locals[522];
        locals[720] = ~locals[776] ^ locals[773];
        locals[797] = ((locals[801] ^ locals[529]) & locals[773] ^ locals[801] ^ locals[529]) & locals[776] ^
                      (~locals[801] ^ locals[529]) & locals[780] ^
                      ~((locals[801] ^ locals[529]) & locals[720] & locals[301]) ^ locals[529];
        locals[779] = locals[802] >> 3;
        locals[683] = ~(~locals[779] & locals[761] >> 3) & locals[462] >> 3 ^ locals[779] ^ 0xe0000000;
        locals[789] = ~((locals[802] ^ locals[761]) >> 3) & 0x1fffffff;
        locals[781] = (locals[462] ^ locals[761]) >> 1;
        locals[260] = (~(locals[720] & locals[529]) ^ locals[780] & locals[720] ^ locals[776] ^ locals[773]) &
                      locals[301] ^
                      (~((~locals[780] ^ locals[529]) & locals[773]) ^ locals[780] ^ locals[529]) & locals[776] ^
                      ~locals[529] & locals[780] ^
                      locals[801];
        locals[704] = ((locals[816] ^ locals[636]) & locals[585] ^ locals[522] ^ locals[636]) & locals[704] ^
                      ~((locals[585] ^ locals[704]) & locals[636]) & locals[794] ^ locals[585] & locals[446];
        locals[802] = ~(~((locals[462] & locals[761]) >> 1) & locals[802] >> 1) ^ locals[462] >> 1;
        locals[816] = ~locals[800];
        locals[636] = (~locals[811] ^ locals[758]) & locals[772];
        locals[794] = ((locals[749] ^ locals[816] ^ locals[758]) & locals[811] ^ ~locals[749] & locals[800] ^
                       locals[636] ^ locals[758]) &
            locals[331] ^ (locals[749] & locals[816] ^ locals[772] & locals[758]) & locals[811] ^ locals[758];
        locals[764] = (((locals[704] ^ 0x22222222) & locals[812] ^ locals[704]) & locals[785] ^ 0xdddddddd) &
                      0xaaaaaaaa;
        locals[759] = (locals[813] ^ locals[782]) & locals[755] ^ ~locals[815] ^ locals[813] ^ locals[770] ^
                      locals[782];
        locals[755] = (~locals[813] ^ locals[755] ^ locals[782]) & locals[770] ^
                      (locals[755] & locals[770] ^ locals[813] ^ locals[782]) & locals[787] ^ locals[755];
        locals[815] = ~locals[773] & locals[776] ^ locals[720] & locals[301];
        locals[801] = (locals[815] ^ locals[529]) & locals[780] ^ locals[815] & locals[529] ^ locals[801];
        locals[813] =
            ~(((locals[816] ^ locals[758]) & locals[749] ^ (locals[800] ^ locals[811]) & locals[758] ^ locals[636]) &
              locals[331]) ^
            (~(~locals[758] & locals[811]) ^ locals[758]) & locals[772] ^
            (~(locals[816] & locals[758]) ^ locals[800]) & locals[749]
            ^ locals[811] ^ locals[758];
        locals[811] = (~((locals[800] ^ locals[749]) & locals[811]) ^ (locals[800] ^ locals[749]) & locals[758]) &
                      locals[331] ^
                      ((locals[811] ^ locals[758]) & locals[800] ^ locals[811] ^ locals[758]) & locals[749] ^
                      locals[811];
        locals[749] = ((locals[801] ^ 0x22222222) & ~locals[797] & locals[260] ^ locals[797] & 0x22222222) & 0xaaaaaaaa;
        locals[816] = ~locals[813] ^ locals[794];
        locals[815] = (locals[816] ^ locals[786]) & locals[811];
        locals[800] = ((locals[811] ^ locals[786]) & locals[798] ^ ~locals[794] & locals[813] ^ locals[815]) &
                      locals[526] ^
                      (~locals[813] & locals[794] ^ ~locals[786] & locals[798] ^ locals[786]) & locals[811] ^
                      locals[794];
        locals[301] = (~locals[785] & locals[704] & 0x22222222 ^ 0x88888888) & locals[812] ^ 0xdddddddd;
        locals[462] = ~(~(locals[761] >> 3) & locals[462] >> 3) & locals[779] ^ (locals[462] & locals[761]) >> 3;
        locals[812] = (~locals[785] & locals[704] ^ locals[785]) & locals[812] & 0x88888888 ^ locals[785] & 0x22222222;
        locals[720] = locals[301] ^ locals[781];
        locals[331] = ~((~((locals[812] ^ locals[764] ^ locals[796]) & locals[781]) ^ locals[812]) & locals[301]) ^
                      (~locals[764] ^ locals[796]) & locals[781] ^ locals[720] & locals[802] & locals[796];
        locals[801] = ~locals[260] & locals[801];
        locals[772] = ~((locals[260] & 0x22222222 ^ locals[801]) & locals[797] & 0xaaaaaaaa);
        locals[802] = (locals[802] ^ locals[781]) & locals[796] ^ (locals[812] ^ locals[764]) & locals[301] ^
                      locals[764];
        locals[796] = (locals[801] & 0x88888888 ^ 0x22222222) & locals[797] ^ locals[260] & 0x88888888;
        locals[529] = locals[772] << 2 & ~(locals[749] << 2);
        locals[801] = (locals[772] ^ locals[749]) << 2;
        locals[787] = ~(~(~(locals[812] >> 2) & locals[301] >> 2) & locals[764] >> 2) ^ locals[301] >> 2;
        locals[785] = ~((locals[796] ^ locals[749]) << 2) & locals[772] << 2 ^ locals[796] << 2 & ~(locals[749] << 2) ^
                      3;
        locals[636] = (~locals[811] ^ locals[794]) & locals[786];
        locals[779] = (locals[813] ^ locals[786]) & locals[794];
        locals[815] = (~(locals[526] & (~locals[811] ^ locals[794])) ^ locals[636] ^ locals[811] ^ locals[794]) &
                      locals[798] ^
                      (locals[636] ^ locals[811] ^ locals[794]) & locals[526] ^ locals[779] ^ locals[815] ^
                      locals[813] ^ locals[786];
        locals[704] = ~((locals[764] & locals[301]) >> 2) & locals[812] >> 2 ^ locals[764] >> 2;
        locals[812] = (locals[812] ^ locals[301]) >> 2;
        locals[636] = (~locals[800] & locals[815] ^ locals[800]) & 0x22222222 ^ 0xdddddddd;
        locals[816] =
            ~((~((locals[794] ^ locals[786]) & locals[798]) ^ locals[816] & locals[811] ^ locals[779] ^ locals[813]) &
              locals[526] ^
              (locals[811] & locals[813] ^ ~locals[786] & locals[798] ^ locals[786]) & locals[794] ^ locals[811]);
        locals[813] =
            ((locals[800] & 0xdddddddd ^ locals[816]) & locals[815] ^ locals[816] & locals[800]) & 0xaaaaaaaa ^
            0x77777777;
        locals[815] = locals[815] & locals[800] & 0x22222222 ^ 0xdddddddd;
        locals[811] = (locals[636] >> 1 & ~(locals[813] >> 1) ^ ~(locals[815] >> 1)) & 0x7fffffff;
        locals[779] = locals[636] * 2;
        locals[816] = ~(locals[815] * 2);
        locals[800] = ~(locals[813] * 2) & locals[779] & locals[816];
        locals[301] = ~locals[779] & locals[815] * 2 ^ locals[813] * 2 & locals[816];
        locals[797] = (~(locals[636] >> 1) & locals[815] >> 1 ^ ~(locals[813] >> 1)) & 0x7fffffff;
        locals[779] = locals[779] ^ locals[816];
        locals[813] = (locals[813] & locals[636] ^ locals[815]) >> 1;
        locals[816] = ~locals[812];
        locals[260] = (~((locals[812] ^ locals[787]) & locals[704]) ^ (locals[816] ^ locals[462]) & locals[787] ^
                       locals[462] & locals[683]) &
                      locals[789] ^ (~(locals[816] & locals[704]) ^ ~locals[683] & locals[462] ^ locals[812]) &
                      locals[787] ^
                      locals[812];
        locals[815] = ~locals[785];
        locals[636] = (locals[815] ^ locals[529]) & locals[801];
        locals[761] =
            (~((~locals[301] ^ locals[785] ^ locals[801] ^ locals[529]) & locals[779]) ^ locals[636] ^ locals[785]) &
            locals[800] ^
            (~((locals[815] ^ locals[801] ^ locals[529]) & locals[301]) ^ locals[785] ^ locals[801] ^ locals[529]) &
            locals[779] ^
            (locals[801] ^ locals[529]) & locals[785] ^ locals[801];
        locals[781] = ((locals[301] ^ locals[800]) & (locals[785] ^ locals[529]) ^ locals[785] ^ locals[529]) &
                      locals[779] ^
                      locals[815] & locals[529] ^ locals[800] ^ locals[801];
        locals[815] = (~locals[789] ^ locals[683]) & locals[462];
        locals[704] = (~locals[815] ^ locals[704] ^ locals[789]) & locals[812] ^
                      (locals[815] ^ locals[704] ^ locals[789]) & locals[787] ^
                      locals[789];
        locals[789] = ~((~((locals[816] ^ locals[787]) & locals[789]) ^ (locals[816] ^ locals[787]) & locals[683] ^
                         locals[812] ^ locals[787])
                        & locals[462]) ^ locals[787] ^ locals[789];
        locals[812] = ~locals[811] ^ locals[749];
        locals[529] = ~((~((locals[301] ^ locals[801]) & locals[779]) ^ locals[636] ^ locals[529]) & locals[800]) ^
                      (~locals[301] & locals[779] ^ locals[785]) & locals[801] ^ locals[785] ^ locals[529];
        locals[816] = ~locals[529];
        locals[636] = (~((locals[529] ^ locals[761]) & locals[331]) ^ locals[816] & locals[761]) & locals[781] ^
                      ~((~locals[761] ^ locals[802]) & locals[331]) & locals[529] ^
                      (locals[816] ^ locals[331]) & locals[802] & locals[720];
        locals[779] = (locals[331] ^ locals[720]) & (locals[816] ^ locals[781]) & locals[802] ^ locals[781] ^
                      locals[331];
        locals[816] = locals[797] ^ locals[813];
        locals[462] = locals[816] & locals[811] ^ (locals[772] ^ locals[749]) & locals[796] ^ locals[813] ^ locals[772];
        locals[720] = (~((locals[781] ^ locals[761]) & locals[331]) ^ ~locals[781] & locals[761]) & locals[529] ^
                      ~((~locals[761] ^ locals[802]) & locals[781]) & locals[331] ^
                      (~locals[781] ^ locals[331]) & locals[802] & locals[720];
        locals[800] = ~((locals[779] & 0xff ^ locals[720]) & locals[636] & 0xffff) ^ locals[720] & locals[779] & 0xffff;
        locals[815] = (locals[779] ^ 0xff00ffff) & locals[720];
        locals[301] = ((locals[815] ^ 0xff0000) & locals[636] ^ locals[815]) & 0xffff0000;
        locals[331] = (~locals[720] & locals[779] & 0xff000000 ^ 0xff0000) & locals[636] ^ locals[720] & 0xff000000;
        locals[813] = ((locals[816] ^ locals[796]) & locals[749] ^ ~locals[796] & locals[772] ^ locals[797]) &
                      locals[811] ^
                      (~locals[796] & locals[772] ^ locals[813] ^ locals[796]) & locals[749];
        locals[811] = locals[779] & locals[636] & 0xff00;
        locals[749] = (~locals[779] & locals[636] ^ locals[779]) & 0xff00;
        locals[797] = ~(~(locals[800] << 8) & locals[749] << 8) ^ (locals[811] & locals[800]) << 8;
        locals[636] = ~(((locals[779] ^ 0xff0000) & locals[720] ^ locals[779]) & locals[636] & 0xffff0000);
        locals[779] = (locals[749] & locals[811]) << 8;
        locals[800] = locals[800] << 0x18 ^ 0xffffffff;
        locals[720] = locals[331] >> 8;
        locals[802] = ~(locals[636] >> 8) & locals[720] ^ locals[301] >> 8 ^ 0xff000000;
        locals[816] = ~locals[789];
        locals[796] = ((locals[462] ^ locals[789]) & locals[704] ^ (locals[813] ^ locals[462]) & locals[812] ^
                       locals[462] ^ locals[789]) &
                      locals[260] ^
                      (~locals[813] & locals[812] ^ locals[816] & locals[704] ^ locals[789]) & locals[462] ^
                      locals[813];
        locals[815] = (locals[816] ^ locals[260]) & locals[704];
        locals[812] = ~((locals[815] ^ locals[812] ^ locals[789] ^ locals[260]) & locals[813]) ^
                      (~locals[815] ^ locals[812] ^ locals[789] ^ locals[260]) & locals[462] ^ locals[260];
        locals[815] = ~locals[813] ^ locals[462];
        locals[260] = (~(locals[815] & locals[789]) ^ locals[815] & locals[260] ^ locals[813] ^ locals[462]) &
                      locals[704] ^
                      (locals[813] ^ locals[789]) & locals[462] ^ locals[816] & locals[813] ^ locals[789] ^ locals[260];
        locals[813] = ~((locals[301] & locals[331] & locals[636]) >> 0x18) & 0xff;
        locals[529] = ~(locals[301] >> 8) & locals[720] ^ ~locals[720] & locals[636] >> 8;
        locals[816] = ~locals[260];
        locals[462] = ~(~(locals[816] & locals[796]) & locals[812] & 0xff000000) ^ locals[260] & 0xff000000;
        locals[811] = (locals[749] ^ locals[811]) << 8;
        locals[782] = ~((locals[636] ^ locals[301]) >> 0x18) & locals[331] >> 0x18 ^ 0xffffff00;
        locals[749] = (locals[636] & locals[331] ^ locals[301]) >> 8;
        locals[301] = (((locals[260] ^ 0xff00) & locals[796] ^ locals[260]) & locals[812] ^ 0xffff00ff) & 0xffff00;
        locals[331] = ~(locals[636] >> 0x18) ^ locals[331] >> 0x18;
        locals[636] = locals[816] & locals[796] & ~locals[812] ^ ~(locals[260] & locals[812]);
        locals[720] = locals[816] & locals[796] ^ locals[260] & locals[812];
        locals[801] = locals[720] & 0xff0000ff;
        locals[720] = locals[720] >> 0x18;
        locals[772] = (~locals[720] & locals[462] >> 0x18 ^ ~(locals[636] >> 0x18)) & 0xff;
        locals[787] = locals[800] & locals[797] & 0xff000000 ^
                      (~((~locals[797] ^ 0xff000000) & locals[811]) ^ locals[797] ^ 0xff000000) & locals[779] ^
                      locals[811];
        locals[779] = (locals[797] & locals[800] ^ 0xffffffff ^ locals[800]) & 0xff000000 ^
                      (locals[811] & locals[797] ^ locals[797]) & locals[779] ^ locals[797];
        locals[815] = locals[636] & 0xff000000 ^ locals[462];
        locals[785] = locals[815] >> 0x18;
        locals[800] = (locals[801] ^ locals[462]) << 0x18;
        locals[462] = ~((locals[636] & locals[462]) >> 0x18) & locals[720] ^ locals[462] >> 0x18 ^ 0xffffff00;
        locals[704] = ~(locals[260] & ~locals[812]) & locals[796] & 0xff0000 ^ locals[812] & 0xff00;
        locals[776] = ((locals[801] & locals[815]) << 0x18 ^ 0xffffffff) & 0xff000000;
        locals[797] = locals[811] ^ 0xff000000 ^ locals[797];
        locals[812] = (~(locals[260] & 0xff00) ^ locals[816] & locals[812] & 0xff00) & locals[796] & 0xffff00 ^
                      0xffff00ff;
        locals[816] = ~(locals[704] >> 8);
        locals[636] = locals[812] >> 8;
        locals[811] = ~(locals[301] >> 8 & locals[816]) ^ (locals[812] & locals[704]) >> 8;
        locals[796] = ~(locals[636] & locals[816]) & locals[301] >> 8 ^ locals[636];
        locals[816] = ~(locals[704] << 8);
        locals[720] = locals[301] << 8;
        locals[801] = ~(locals[812] << 8) & locals[720] ^ locals[812] << 8 & locals[816] ^ 0xff;
        locals[761] = locals[720] ^ locals[816];
        locals[815] = ~locals[787] ^ locals[779];
        locals[683] =
            ~(((locals[749] ^ ~locals[779]) & locals[802] ^ locals[787] & ~locals[779] ^ ~(locals[797] & locals[815])) &
              locals[529]
                ) ^ (locals[797] & locals[787] ^ locals[749] & locals[802]) & locals[779] ^ locals[802];
        locals[781] = (~(locals[529] & locals[815]) ^ locals[802] & locals[815] ^ locals[787] ^ locals[779]) &
                      locals[797] ^
                      (~((~locals[529] ^ locals[802]) & locals[779]) ^ locals[529] ^ locals[802]) & locals[787] ^
                      (~(locals[749] & locals[802]) ^ locals[779]) & locals[529] ^ locals[779] & locals[802];
        locals[720] = locals[720] & locals[816];
        locals[816] = locals[801] ^ ~locals[720];
        locals[260] = ~(locals[720] & locals[776]) & locals[800] ^
                      ~((locals[801] & ~locals[720] ^ locals[776] & locals[816] ^ locals[720]) & locals[761]);
        locals[529] = ~(((locals[787] ^ locals[749] ^ locals[529]) & locals[779] ^ locals[787] ^ locals[749] ^
                         locals[529] ^
                         locals[797] & locals[815]) & locals[802]) ^ ~(locals[797] & locals[787]) & locals[779] ^
                      locals[529];
        locals[815] = locals[529] ^ ~locals[781];
        locals[802] = (~(locals[782] & locals[815]) ^ locals[781] ^ locals[529]) & locals[331] ^
                      ~(locals[813] & locals[815]) & locals[782] ^
                      locals[529] & ~locals[781];
        locals[636] = ~(~((locals[812] & locals[301]) >> 8) & locals[704] >> 8) ^ locals[636];
        locals[815] = (~locals[331] ^ locals[813]) & locals[782];
        locals[787] = (locals[781] ^ locals[683] ^ locals[331] ^ locals[815]) & locals[529] ^
                      (locals[683] ^ locals[331] ^ locals[815]) & locals[781] ^ locals[782];
        locals[779] = ((locals[720] ^ locals[761]) & locals[776] ^ locals[816] & locals[761] ^ locals[720]) &
                      locals[800] ^
                      ((locals[720] ^ locals[801]) & locals[776] ^ ~locals[801] & locals[720]) & locals[761] ^
                      locals[720] ^ locals[776];
        locals[776] = ~(~((locals[776] ^ locals[816]) & locals[761]) & locals[800]) ^ locals[720] ^ locals[761] ^
                      locals[776];
        locals[816] = ~locals[779];
        locals[815] = locals[811] & (locals[260] ^ locals[816]);
        locals[815] = (~(locals[796] & (locals[260] ^ locals[816])) ^ locals[815]) & locals[636] ^ locals[776] ^
                      locals[779] ^ locals[260] ^
                      locals[815];
        locals[720] = (locals[779] ^ locals[260] ^ locals[796] ^ locals[811]) & locals[776];
        locals[749] = ~(((~locals[796] ^ locals[811]) & locals[260] ^
                         (locals[260] ^ locals[796] ^ locals[811]) & locals[779] ^ ~locals[720] ^
                         locals[796]) & locals[636]) ^ (~(locals[776] & locals[816]) ^ locals[779]) & locals[260] ^
                      (locals[776] ^ locals[779] ^ locals[260]) & locals[811] ^ locals[776];
        locals[260] = ~((~locals[260] & locals[779] ^ locals[796] ^ locals[720]) & locals[636]) ^
                      (locals[260] & locals[816] ^ locals[811]) & locals[776] ^ locals[779] ^ locals[260];
        locals[782] = ((locals[781] ^ locals[782]) & locals[529] ^ locals[781] & ~locals[782]) & locals[683] ^
                      ((locals[781] ^ locals[331] ^ locals[813]) & locals[782] ^ locals[331]) & locals[529] ^
                      locals[331] & ~locals[782] ^
                      locals[781] ^ locals[782];
        locals[816] = ~locals[787] & locals[802];
        locals[331] = (locals[816] & 0x34d7142e ^ 0x49286ad1) & locals[782] ^ ~(locals[816] & 0xb6d7152e) & 0xcb28ebd1;
        locals[720] = ~(locals[802] & 0x580aa203);
        locals[636] = ~locals[816];
        locals[704] = ((locals[787] & locals[720] ^ locals[802] & 0xa7f55dfc) & 0xffaeab8b ^ 0x405470) & locals[782] ^
                      locals[636] & 0xa7a40988;
        locals[779] = ~locals[783];
        locals[813] = locals[779] & locals[622] ^ locals[783];
        locals[812] = (locals[813] ^ 0x2c2445) & locals[806];
        locals[797] = ((((~(locals[787] & 0xffd3dbba) ^ locals[622]) & locals[783] ^ locals[622] ^ 0x2c2445) &
                        locals[806] ^
                        ~(locals[787] & locals[779] & locals[622]) & 0xffd3dbba) & locals[802] ^ locals[812] ^
                       0xffd3dbba) &
                      locals[782] ^
                      ((locals[812] ^ 0xffd3dbba) & locals[787] ^ locals[812] ^ 0xffd3dbba) & locals[802] ^ locals[812]
                      ^ 0x2c2445;
        locals[812] = (locals[749] ^ locals[772] ^ ~locals[815]) & locals[260];
        locals[811] = (locals[772] ^ ~locals[815]) & locals[749];
        locals[800] = ~((locals[815] ^ locals[772] ^ locals[811] ^ locals[812]) & locals[462]) ^
                      (~locals[812] ^ locals[815] ^ locals[772] ^ locals[811]) & locals[785] ^ locals[749];
        locals[812] = (locals[749] ^ ~locals[260]) & locals[815];
        locals[811] = ~locals[749];
        locals[796] = ~(((locals[772] ^ ~locals[260]) & locals[749] ^ locals[812]) & locals[462]) ^
                      ((locals[462] ^ locals[811]) & locals[772] ^ locals[749] ^ locals[462]) & locals[785] ^
                      (~(locals[260] & locals[811]) ^ locals[749]) & locals[815] ^ locals[260];
        locals[801] = ~(~(~(locals[787] & 0xcb28ebd1) & locals[802]) & locals[782]) & 0x7dff7eff ^
                      (locals[787] ^ 0x7dff7eff) & locals[802];
        locals[761] = locals[801] & 0xffff7fff;
        locals[749] = locals[749] ^
                      ~(((locals[772] ^ locals[811]) & locals[260] ^ locals[749] ^ locals[772] ^ locals[812]) &
                        locals[785]) ^
                      ~((locals[260] ^ locals[785]) & locals[772]) & locals[462] ^
                      ~(locals[815] & locals[749]) & locals[260];
        locals[772] = ((locals[787] & 0x49286ad1 ^ 0x82000100) & locals[802] ^ 0xffff7fff) & locals[782] ^
                      locals[802] & 0x34d7142e ^ 0x82000100;
        locals[815] = ~locals[800];
        locals[812] = locals[796] & locals[815];
        locals[785] =
            ((locals[800] & 0xdcffbedf ^ ~locals[796]) & locals[749] ^ locals[800] & 0x23004120 ^ locals[812]) &
            0xfffdfffb ^ 0x20004;
        locals[811] = (locals[817] ^ locals[622] ^ 0xcd1461) & locals[800];
        locals[813] = (locals[813] ^ 0xcd1461) & locals[806];
        locals[462] = (locals[813] ^ 0xff32eb9e) & locals[800];
        locals[683] =
            ((locals[813] ^ locals[811] ^ 0xff32eb9e) & locals[796] ^ locals[462] ^ locals[813] ^ 0xff32eb9e) &
            locals[749]
            ^ (locals[462] ^ locals[813] ^ 0xff32eb9e) & locals[796] ^ locals[813] ^ locals[811] ^ 0xcd1461;
        locals[781] = (locals[796] & 0xd884a249 ^ locals[815] & 0x23004120) & locals[749] ^ locals[812] & 0xd884a249;
        locals[529] = locals[781] ^ 0x277b5db6;
        locals[260] =
            (((locals[802] ^ 0xffbfab8f) & locals[782] ^ locals[802] & 0xffbfab8f) & 0x584af673 ^ 0xa7a40988) &
            locals[787] ^ (locals[782] & locals[720] ^ locals[802] & 0x580aa203) & 0xffeefffb;
        locals[776] = locals[260] ^ 0xa7f55dfc;
        locals[773] = (locals[749] ^ locals[815]) & locals[796] ^ ~(~locals[749] & locals[800] & 0xdcffbedf);
        locals[758] = ((locals[761] ^ locals[331]) & 0xb3beb154 ^ 0x4be385db) & locals[772] ^
                      (locals[801] & 0xb41c7a24 ^ 0x4be385db) & locals[331] ^ (locals[761] ^ 0x3a28150) & 0x7a2cb70;
        locals[794] = ((~locals[796] & 0xdfb7d6ea ^ locals[800]) & locals[749] ^
                       (locals[800] ^ 0xdfb7d6ea) & locals[796]) &
                      0xbffffff5;
        locals[764] = locals[794] ^ 0x6048291f;
        locals[720] = (locals[802] & 0x405470 ^ 0xa7a40988) & locals[782];
        locals[720] = (locals[720] ^ locals[802] & 0x405470 ^ 0x580aa203) & locals[787] ^ ~locals[802] & 0x405470 ^
                      locals[720];
        locals[789] = (locals[796] & 0x20482915 ^ 0x9b3d6c0) & locals[749] ^ ~(locals[796] & 0x9b3d6c0) & 0xdfb7d6ea;
        locals[774] = ((locals[773] & 0xd2044220 ^ 0xba067ad1) & locals[529] ^ 0x6c4024f5) & locals[785] ^
                      locals[773] & 0x1808108 ^ locals[529] ^ 0x280020d1;
        locals[813] = (locals[796] ^ locals[815]) & locals[749];
        locals[301] =
            (((locals[813] ^ locals[812]) & locals[779] ^ locals[783]) & 0xff32eb9e ^ 0xcd1461) & locals[806] ^
            ~((~locals[812] ^ locals[813]) & locals[779] & locals[622] & 0xff32eb9e) ^
            (locals[796] & locals[749] & 0xff32eb9e ^ 0xcd1461) & locals[800];
        locals[762] = (locals[815] & 0x20482915 ^ locals[796] & 0x9b3d6c0) & locals[749] ^ locals[812] & 0x20482915 ^
                      0x9b3d6c0;
        locals[775] = ((locals[801] & 0xf85d348f ^ 0xb3beb154) & locals[331] ^ (locals[761] ^ 0x4004a20) & 0xb41c7a24) &
                      locals[772] ^ locals[331] & (locals[761] ^ 0x4004a20) & 0xb41c7a24 ^
                      (locals[761] ^ 0xb7befb74) & 0xf85d348f;
        locals[813] = (locals[787] & 0xffd3dbba ^ locals[806] ^ 0x2c2445) & locals[802];
        locals[812] = ((locals[806] ^ 0x2c2445) & locals[787] ^ locals[806] ^ 0x2c2445) & locals[802];
        locals[462] = locals[783] & 0xffd3dbba ^ 0x2c2445;
        locals[811] = locals[462] & locals[806];
        locals[791] = (((locals[813] ^ locals[806] ^ 0x2c2445) & locals[783] ^ locals[813] ^ locals[806] ^ 0x2c2445) &
                       locals[782] ^
                       (locals[812] ^ locals[806] ^ 0x2c2445) & locals[783] ^ locals[812] ^ locals[806] ^ 0x2c2445) &
                      locals[622] ^
                      (((~locals[782] & locals[783] & 0xffd3dbba ^ 0x2c2445) & locals[806] ^ 0x2c2445) & locals[787] ^
                       (locals[811] ^ 0x2c2445) & locals[782] ^ locals[811] ^ 0x2c2445) & locals[802] ^
                      (locals[782] & locals[462] ^ locals[779] & 0xffd3dbba) & locals[806] ^ locals[782] ^ 0xffd3dbba;
        locals[765] = (~((locals[720] ^ 0xf1e71e36) & locals[776]) ^ locals[720] & 0xf1e71e36) & locals[704] ^
                      locals[776] ^
                      0xf1e71e36;
        locals[809] = ((locals[785] & 0x93bfdb0a ^ 0xba067ad1) & locals[529] ^ 0x44400424) & locals[773] & 0xfb84e369 ^
                      (~(locals[785] & 0x6c4024f5) & locals[529] ^ 0xbbbffbdb) & 0xfe467ef5 ^ locals[785];
        locals[786] = ~((~((locals[704] ^ 0xf1e71e36) & locals[720]) ^ locals[704]) & locals[776]) ^
                      locals[704] & 0xe18e1c9;
        locals[813] = ((locals[800] ^ locals[806] ^ 0xcd1461) & locals[783] ^ locals[800] ^ locals[806] ^ 0xcd1461) &
                      locals[622];
        locals[812] = (locals[800] ^ 0xff32eb9e) & locals[783];
        locals[811] = (locals[806] ^ 0xcd1461) & locals[800];
        locals[811] = ((locals[811] ^ locals[806] ^ 0xcd1461) & locals[783] ^ locals[811] ^ locals[806] ^ 0xcd1461) &
                      locals[622];
        locals[462] = (locals[783] & 0xff32eb9e ^ 0xcd1461) & locals[806];
        locals[800] = (locals[462] ^ 0xcd1461) & locals[800];
        locals[813] = (((locals[812] ^ 0xcd1461) & locals[806] ^ locals[815] & 0xcd1461 ^ locals[813]) & locals[796] ^
                       locals[800] ^
                       locals[462] ^ locals[811] ^ 0xcd1461) & locals[749] ^
                      (locals[800] ^ locals[462] ^ locals[811] ^ 0xcd1461) & locals[796] ^
                      (locals[812] ^ 0xff32eb9e) & locals[806] ^
                      locals[815] & 0xff32eb9e ^ locals[813];
        locals[801] = ((locals[789] ^ 0xe45e3796) & locals[764] ^ locals[789] & 0x69ce9c2b ^ 0x963163d4) & locals[762] ^
                      (locals[789] ^ 0x9808829) & 0x7befdc6b;
        locals[766] = (~(~(locals[683] & 0x1264214a) & locals[813]) ^ locals[683]) & locals[301] ^ locals[813] ^
                      0xed9bdeb5;
        locals[787] = (((locals[787] ^ locals[779] & locals[806]) & locals[802] ^
                        ~locals[802] & locals[779] & locals[622] ^
                        ~(locals[779] & locals[806])) & locals[782] ^ locals[779] & locals[636] & locals[622]) &
                      0xffd3dbba ^
                      ((locals[636] & locals[783] ^ locals[816]) & 0xffd3dbba ^ 0x2c2445) & locals[806];
        locals[761] = ((locals[772] & 0xf85d348f ^ 0x7a2cb70) & locals[761] ^ locals[772] ^ 0xb7befb74) & locals[331] ^
                      locals[772] & (locals[761] ^ 0xb7befb74) ^ 0x7a2cb70;
        locals[772] = ((locals[789] & 0x8d90abbd ^ 0xe45e3796) & locals[764] ^ locals[789] & 0xe45e3796 ^ 0x1ba1c869) &
            locals[762] ^ (locals[794] ^ 0xe4580a8b) & locals[789] ^ 0x9fb1ebfd;
        locals[816] = (locals[787] ^ 0xce996f82) & locals[791];
        locals[782] = ((locals[704] & (locals[787] ^ 0x3166907d) ^ locals[787] ^ 0x3166907d) & locals[797] ^
                       (locals[816] ^ locals[787] ^ 0x3d2aa8c8) & locals[704] ^ locals[816] ^ locals[787] ^
                       0x3d2aa8c8) & locals[776]
                      ^ ((locals[787] ^ 0xf3f7d77f) & locals[791] ^
                         (locals[791] ^ locals[787] ^ 0xf3f7d77f) & locals[797] ^
                         locals[787] ^ 0xc082880) & 0xce996f82 ^
                      (locals[797] & (locals[787] ^ 0x3166907d) ^ locals[816] ^ locals[787] ^ 0x3d2aa8c8) &
                      locals[720] & locals[704];
        locals[816] = (locals[260] ^ 0x9693cd81) & locals[787];
        locals[260] = ((~locals[791] ^ locals[797]) & locals[787] ^ locals[797] ^ 0xc2d55737) &
                      (locals[720] ^ locals[776]) & locals[704]
                      ^ (locals[791] & 0xce996f82 ^ locals[776] ^ locals[816] ^ 0xf3f7d77f) & locals[797] ^
                      (locals[787] ^ 0xc2d55737) & locals[776] ^ (locals[816] ^ 0xc082880) & locals[791] ^
                      (locals[787] ^ 0x441035) & 0x3166907d;
        locals[301] = ~locals[301];
        locals[768] = ~((locals[813] & locals[301] & 0x1264214a ^ 0xed9bdeb5) & locals[683]) ^ locals[813];
        locals[785] = ((locals[529] & 0x93bfdb0a ^ 0xba067ad1) & locals[785] ^ locals[529] & 0x6c4024f5 ^ 0x1b9810a) &
                      locals[773] & 0xfb84e369 ^ (locals[529] & 0x45f9852e ^ 0x6c4024f5) & locals[785] ^
                      (locals[781] ^ 0x633b5992) & 0xfe467ef5;
        locals[816] = ~locals[761];
        locals[815] = ~locals[758] & locals[761];
        locals[636] = ~locals[775];
        locals[781] = (((~((locals[816] ^ locals[806]) & locals[758]) ^ locals[816] & locals[806] ^ locals[761]) &
                        locals[775] ^
                        ~locals[815] & locals[806] ^ locals[761]) & locals[783] ^
                       ~(locals[758] & locals[636]) & locals[761]) & locals[622] ^
                      ((~(locals[636] & locals[806] & locals[783]) ^ locals[775]) & locals[758] ^ locals[783]) &
                      locals[761] ^ locals[783];
        locals[812] = ~locals[774];
        locals[529] = (~((locals[774] ^ locals[785]) & locals[755]) ^ locals[812] & locals[785]) & locals[809] ^
                      (~((locals[812] ^ locals[755]) & locals[793]) ^ locals[774] ^ locals[755]) & locals[759] ^
                      (~((locals[785] ^ locals[793]) & locals[774]) ^ locals[793]) & locals[755] ^
                      locals[812] & locals[793];
        locals[773] = ~locals[683] & locals[813] & 0xed9bdeb5 ^ locals[683] & 0x1264214a;
        locals[798] = locals[720] & 0xe18e1c9 ^ locals[776];
        locals[812] = ~locals[622];
        locals[769] =
            ~(((~((~(locals[1] & locals[761]) ^ locals[806]) & locals[758]) ^ locals[816] & locals[806] ^ locals[761]) &
               locals[775]
               ^ (locals[758] & locals[812] ^ locals[806]) & locals[761] ^ locals[622] ^ locals[806]) & locals[783]) ^
            (~((~(locals[775] & locals[812]) ^ locals[622]) & locals[758]) ^ locals[622]) & locals[761] ^ locals[622];
        locals[794] = ((locals[794] ^ 0xedd882a2) & locals[789] ^ locals[764] ^ 0xe45e3796) & locals[762] ^
                      (locals[764] & 0x726f5442 ^ 0xeddebfbf) & locals[789] ^ 0x726f5442;
        locals[811] = locals[774] & (locals[809] ^ locals[785]);
        locals[749] = ~locals[785];
        locals[764] =
            ((locals[809] ^ locals[759]) & locals[793] ^ locals[809] & locals[785] ^ locals[811] ^ locals[759]) &
            locals[755] ^
            (~(~locals[759] & locals[793]) ^ locals[774] & locals[749] ^ locals[759] ^ locals[785]) & locals[809] ^
            locals[774];
        locals[462] = ~locals[1];
        locals[800] = locals[462] ^ locals[820];
        locals[331] =
            (~((~((~(locals[801] & locals[800]) ^ locals[1] ^ locals[820]) & locals[794]) ^ locals[1] ^ locals[820]) &
               locals[772])
             ^ locals[1] ^ locals[820]) & locals[675];
        locals[802] = (~(locals[801] & locals[712]) ^ locals[820]) & locals[794];
        locals[789] = (~locals[802] ^ locals[820]) & locals[772] ^ locals[331] ^ locals[820];
        locals[796] = ~locals[806];
        locals[762] = ~(((~((~(locals[774] & locals[779]) ^ locals[783]) & locals[785]) ^ locals[774] ^ locals[783]) &
                         locals[622] ^
                         ~((~((locals[749] ^ locals[622]) & locals[774]) ^ locals[785]) & locals[783]) & locals[806] ^
                         locals[774] & locals[749] ^ locals[785] ^ locals[783]) & locals[809]) ^
                      (~(((~(locals[774] & locals[796]) ^ locals[806]) & locals[785] ^ locals[806]) & locals[783]) ^
                       locals[806]) &
                      locals[622] ^ locals[806] ^ locals[783];
        locals[793] = (~locals[755] ^ locals[759]) & locals[793];
        locals[755] = (locals[809] ^ locals[755] ^ locals[759] ^ locals[785] ^ locals[793]) & locals[774] ^
                      (locals[755] ^ locals[759] ^ locals[785] ^ locals[793]) & locals[809] ^ locals[755];
        locals[759] = (locals[802] ^ locals[820]) & locals[772] ^ ~locals[331] ^ locals[794] ^ locals[820];
        locals[709] = ~(((locals[786] ^ locals[798]) & locals[820] ^ locals[786] ^ locals[798]) & locals[765] &
                        locals[1]) ^
                      (~locals[786] & locals[1] ^ locals[786]) & locals[820] ^ locals[786];
        locals[331] = ~(locals[755] & locals[796]) ^ locals[806];
        locals[802] = locals[529] & locals[331];
        locals[748] =
            ~(((~((~(locals[1] & locals[755]) ^ locals[806]) & locals[529]) ^ locals[806] ^ locals[755] & locals[796]) &
               locals[764]
               ^ locals[755] ^ locals[622] ^ locals[802]) & locals[783]) ^
            (locals[812] & locals[764] & locals[529] ^ locals[622]) & locals[755] ^ locals[622];
        locals[793] = locals[800] & locals[675];
        locals[794] =
            ~((~((~((~(locals[800] & locals[772]) ^ locals[1] ^ locals[820]) & locals[794]) ^ locals[1] ^ locals[820]) &
                 locals[675]
                ) ^ (~(~locals[772] & locals[820]) ^ locals[772]) & locals[794] ^ locals[820]) & locals[801]) ^
            locals[793] ^
            locals[820];
        locals[801] = ~locals[755];
        locals[827] =
            (~((((locals[801] ^ locals[806]) & locals[783] ^ locals[755]) & locals[529] ^ locals[783] & locals[331]) &
               locals[764])
             ^ ~locals[802] & locals[783] ^ locals[755]) & locals[622] ^
            (~(~(locals[806] & locals[783]) & locals[764] & locals[529]) ^ locals[783]) & locals[755] ^ locals[783];
        locals[331] = locals[636] ^ locals[761];
        locals[802] = locals[758] & locals[331];
        locals[772] = (~locals[802] ^ locals[761]) & locals[675];
        locals[772] =
            ~(((~locals[772] ^ locals[761] ^ locals[802]) & locals[820] ^ locals[775] ^ locals[772] ^ locals[802]) &
              locals[1]) ^
            locals[331] & locals[675] ^ locals[775] ^ locals[761];
        locals[720] = ~locals[704] & locals[776] ^ locals[720] & locals[704];
        locals[704] = ((locals[791] ^ locals[720]) & 0xce996f82 ^ locals[787] ^ 0x3d6eb8fd) & locals[797] ^
                      ((locals[720] ^ 0xc082880) & 0xce996f82 ^ locals[787]) & locals[791] ^ locals[787] ^ 0xc2d55737;
        locals[720] = (~(locals[1] & locals[331]) ^ locals[775] ^ locals[761]) & locals[758];
        locals[636] = (locals[636] ^ locals[1]) & locals[761];
        locals[776] = ((~(locals[816] & locals[675]) ^ locals[758]) & locals[1] ^
                       (locals[758] ^ locals[761]) & locals[675] ^ locals[758] ^
                       locals[761]) & locals[775] ^
                      ~((~((~locals[720] ^ locals[775] ^ locals[1] ^ locals[636]) & locals[675]) ^ locals[775] ^
                         locals[1] ^ locals[636] ^
                         locals[720]) & locals[820]) ^
                      (~(locals[761] & (locals[462] ^ locals[675])) ^ locals[1] ^ locals[675]) & locals[758] ^
                      locals[1] ^ locals[675];
        locals[720] = ~locals[782];
        locals[636] = ~locals[260];
        locals[788] =
            ((~((~(locals[1] & locals[782]) ^ locals[806]) & locals[260]) ^ locals[720] & locals[806] ^ locals[782]) &
             locals[704] ^
             (locals[636] & locals[622] ^ locals[260]) & locals[782] ^ locals[622]) & locals[783] ^
            ~((~(locals[812] & locals[704]) ^ locals[622]) & locals[260]) & locals[782] ^ locals[622];
        locals[802] = ~locals[675];
        locals[792] = (((~((~locals[704] ^ locals[782]) & locals[675]) ^ locals[704] ^ locals[782]) & locals[820] ^
                        locals[704] & locals[802]
                        ^ locals[782]) & locals[260] ^ (locals[802] & locals[820] ^ locals[675]) & locals[704]) &
                      locals[1] ^
                      (~((~(locals[636] & locals[675]) ^ locals[260]) & locals[820]) ^ locals[636] & locals[675]) &
                      locals[704] ^ locals[260];
        locals[331] = ~locals[773] ^ locals[766];
        dst[0] = (~(((~((~(locals[768] & locals[802]) ^ locals[675]) & locals[773]) ^ locals[675]) & locals[766] ^
                   (~(locals[768] & locals[331]) ^ locals[773]) & locals[1] & locals[675]) & locals[820]) ^
                (~((~((~(locals[462] & locals[768]) ^ locals[1]) & locals[675]) ^ locals[768]) & locals[773]) ^
                 locals[462] & locals[675])
                & locals[766] ^ locals[766] ^ locals[820]) &
               ((~((~(locals[331] & locals[1]) ^ locals[773] ^ locals[766]) & locals[675]) ^
                 (~(locals[331] & locals[675]) ^ locals[773] ^ locals[766]) & locals[820] ^ locals[773] ^ locals[766]) &
                locals[768] ^
                locals[773] & (~locals[793] ^ locals[820]) ^ locals[766] ^ locals[793]) ^
               (locals[683] ^ locals[301]) & locals[813] ^
               locals[683] & locals[301] ^ locals[766] ^ locals[820];
        locals[813] = ~locals[794];
        dst[1] = (locals[789] ^ locals[813]) & locals[759] ^ locals[789] & locals[813] ^ locals[791] & locals[787] ^
                 locals[797] & (locals[791] ^ locals[787]);
        dst[2] = ~(((~((~((locals[529] ^ locals[801]) & locals[806] & locals[783]) ^ locals[755] ^ locals[529]) &
                       locals[622]) ^
                     (locals[529] ^ locals[801]) & locals[783] ^ locals[755] ^ locals[529]) & locals[764] ^
                    (~((~(locals[801] & locals[806] & locals[783]) ^ locals[755]) & locals[622]) ^
                     locals[801] & locals[783] ^ locals[755]
                    ) & locals[529] ^ (locals[755] ^ locals[783]) & locals[622] ^ locals[801] & locals[783]) &
                   (locals[827] ^ locals[748])
            ) ^ (locals[794] ^ locals[759]) & locals[789] ^ ~locals[748] & locals[827] ^ locals[748] ^ locals[759];
        locals[813] = ~(locals[1] & locals[785]) ^ locals[622];
        locals[812] = (locals[812] ^ locals[783]) & locals[806];
        locals[811] = ~(~((~((((locals[809] ^ locals[785]) & locals[783] ^ locals[809] ^ locals[785]) & locals[622] ^
                              locals[809] ^
                              locals[785]) & locals[774]) ^ (locals[749] & locals[783] ^ locals[785]) & locals[622] ^
                           locals[809] ^ locals[785]
                            ) & locals[806]) ^ (~locals[811] ^ locals[809] ^ locals[785] ^ locals[622]) & locals[783] ^
                        locals[809] ^
                        locals[622]);
        dst[3] = (~((~(((locals[785] ^ locals[806]) & locals[622] ^ locals[813] & locals[783] ^ locals[785] ^
                        locals[806]) & locals[774])
                     ^ (locals[813] ^ locals[806]) & locals[783] ^ locals[749] & locals[622] ^ locals[785] ^
                     locals[806]) & locals[809]) ^
                  (~((~locals[812] ^ locals[622] ^ locals[783]) & locals[774]) ^ locals[812] ^ locals[622] ^
                   locals[783]) & locals[785] ^
                  locals[817] ^ locals[622]) & (locals[811] ^ locals[762]) ^
                 ((~((locals[800] & locals[761] ^ locals[1] ^ locals[820]) & locals[675]) ^ locals[816] & locals[820] ^
                   locals[761] ^
                   locals[1]) & locals[775] ^ (locals[1] ^ locals[675]) & locals[761] ^ locals[1] ^ locals[675]) &
                 (locals[776] ^ locals[772])
                 ^ locals[776] & locals[772] ^ locals[811] & locals[762];
        locals[802] = locals[1] & locals[802];
        locals[816] = (locals[462] ^ locals[675]) & locals[820];
        locals[817] = (~locals[816] ^ locals[802] ^ locals[675]) & locals[765];
        locals[813] = ~locals[758] ^ locals[761];
        locals[812] = locals[775] & locals[813];
        dst[4] = ~(((~(((~(locals[765] & locals[462]) ^ locals[1]) & locals[675] ^ locals[765]) & locals[786]) ^
                     ((locals[786] ^ locals[1]) & locals[675] ^ locals[786]) & locals[765] & locals[798] ^ locals[1]) &
                    locals[820] ^
                    ((~((~(locals[462] & locals[798]) ^ locals[1]) & locals[675]) ^ locals[798]) & locals[765] ^
                     locals[802] ^ locals[675]
                    ) & locals[786] ^ locals[709] ^ locals[1]) &
                   ((locals[817] ^ locals[816] ^ locals[802] ^ locals[675]) & locals[786] ^ locals[817] & locals[798] ^
                    locals[820])) ^
                 ((~((~locals[812] ^ locals[815]) & locals[806]) & locals[783] ^ locals[758] & locals[761] ^
                   locals[812]) & locals[622] ^
                  (~(locals[813] & locals[783]) ^ locals[758] ^ locals[761]) & locals[775] ^
                  ~(locals[758] & locals[779]) & locals[761] ^
                  locals[783]) & (locals[769] ^ locals[781]) ^ ~locals[769] & locals[781] ^ locals[709] ^ locals[769];
        locals[816] = (locals[260] ^ locals[720]) & locals[806];
        dst[5] = ((~((~(locals[816] & locals[783]) ^ locals[782] ^ locals[260]) & locals[622]) ^
                   (locals[260] ^ locals[720]) & locals[783]
                   ^ locals[782] ^ locals[260]) & locals[704] ^
                  ((locals[636] & locals[806] & locals[783] ^ locals[260]) & locals[782] ^ locals[783]) & locals[622] ^
                  ~(locals[779] & locals[260]) & locals[782] ^ locals[788] ^ locals[783]) &
                 (~((~((~((~locals[816] ^ locals[782] ^ locals[260]) & locals[622]) ^ locals[816] ^ locals[782] ^
                        locals[260]) &
                       locals[704]) ^
                     (~((~(locals[260] & locals[796]) ^ locals[806]) & locals[622]) ^ locals[260] & locals[796] ^
                      locals[806]) &
                     locals[782]) & locals[783]) ^ locals[782]) ^
                 (((~((~(locals[800] & locals[704]) ^ locals[1] ^ locals[820]) & locals[782]) ^ locals[1] ^
                    locals[820]) & locals[675] ^
                   (~(locals[712] & locals[704]) ^ locals[820]) & locals[782] ^ locals[820]) & locals[260] ^
                  locals[704] & (~locals[793] ^ locals[820]) ^ locals[1]) &
                 ((~(((~(locals[800] & locals[782]) ^ locals[1] ^ locals[820]) & locals[675] ^
                      locals[720] & locals[820] ^ locals[782]) &
                     locals[260]) ^ locals[1]) & locals[704] ^ locals[260] & locals[1] ^ locals[792]) ^ locals[792] ^
                 locals[788];
    }
}