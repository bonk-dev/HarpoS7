namespace HarpoS7.Monoliths.Impl.Nine;

/// <summary>
/// Starts at line 12243, ends at 14244
/// </summary>
internal static class Part7
{
    public static void Execute(Span<uint> locals)
    {
        locals[636] = (locals[242] ^ locals[787]) & locals[255];
        locals[812] = (locals[242] ^ locals[768]) & locals[787];
        locals[800] = ((locals[239] ^ locals[242] ^ locals[787] ^ locals[255]) & locals[768] ^
                       (locals[242] ^ ~locals[239] ^ locals[255]) & locals[787]) & locals[790] ^
                      (~((~locals[242] ^ locals[255]) & locals[768]) ^ locals[242] & locals[255]) & locals[787] ^
                      (~locals[636] ^ locals[812]) & locals[239];
        locals[749] = ~(((locals[769] ^ locals[528]) & locals[811] ^ locals[813] & locals[528]) & locals[776]) ^
                      (~((~locals[811] ^ locals[500]) & locals[769]) ^ locals[811] ^ locals[500]) & locals[528] ^
                      ((locals[769] ^ locals[528]) & locals[500] ^ locals[769] ^ locals[528]) & locals[421] ^
                      locals[811] ^ locals[500];
        locals[301] = (~((locals[242] ^ locals[255]) & locals[768]) ^ locals[242] ^ locals[255]) & locals[787] ^
                      (locals[787] ^ locals[768]) & (locals[242] ^ locals[255]) & locals[790] ^ locals[239] ^
                      locals[242] ^ locals[255];
        locals[242] = ((~locals[239] ^ locals[787]) & locals[768] ^ locals[239] & locals[787]) & locals[790] ^
                      ~(~locals[787] & locals[242]) & locals[255] ^ (locals[812] ^ locals[636]) & locals[239] ^
                      locals[242];
        locals[528] = ~(((locals[769] ^ locals[500]) & locals[811] ^ locals[813] & locals[500]) & locals[776]) ^
                      ((locals[779] ^ locals[528]) & locals[500] ^ locals[421] ^ locals[769] ^ locals[528]) &
                      locals[811] ^ locals[769] ^
                      locals[500] ^ locals[528];
        locals[636] = ~locals[795];
        locals[331] = (locals[636] & locals[528] ^ (locals[528] ^ locals[795]) & locals[704]) & locals[749] ^
                      ((locals[704] ^ locals[793]) & locals[528] ^ locals[704] ^ locals[793]) & locals[795] ^
                      ((locals[528] ^ locals[795]) & locals[793] ^ locals[528] ^ locals[795]) & locals[797] ^
                      locals[528];
        locals[787] = locals[331] ^ locals[793];
        locals[779] = (~locals[704] ^ locals[795] ^ locals[797]) & locals[528];
        locals[776] = ~(((~locals[528] ^ locals[793]) & locals[704] ^ locals[528] & locals[793]) & locals[749]) ^
                      (locals[779] ^ locals[704] ^ locals[795] ^ locals[797]) & locals[793] ^ locals[779] ^
                      locals[704] ^ locals[797];
        locals[528] = ((locals[795] ^ locals[793]) & locals[528] ^ locals[795] ^ locals[793]) & locals[704] ^
                      ~(~locals[793] & locals[797]) & locals[795] ^
                      (locals[528] ^ locals[704]) & (locals[795] ^ locals[793]) & locals[749] ^
                      locals[528];
        locals[779] = ~locals[528];
        locals[813] = (locals[779] ^ locals[787]) & locals[795];
        locals[812] = ~locals[813] ^ locals[528] ^ locals[787];
        locals[811] = ~(locals[793] & ~locals[787]) ^ locals[787];
        locals[704] = ~(((~(locals[812] & locals[793]) ^ locals[813] ^ locals[528] ^ locals[787]) & locals[776] ^
                         locals[528] & locals[795] & locals[811]) & locals[797]) ^
                      (~((locals[636] & locals[787] ^ locals[795]) & locals[528]) ^ locals[795]) & locals[793] ^
                      (locals[779] ^ locals[795]) & locals[787];
        locals[813] = ~locals[776];
        locals[811] = locals[776] & locals[811];
        locals[331] =
            ((~(((locals[636] ^ locals[797]) & locals[776] ^ locals[797]) & locals[787]) ^ locals[797] & locals[813]) &
             locals[793]
             ^ (~(locals[787] & locals[813]) ^ locals[776]) & locals[797] ^ locals[787]) & locals[528] ^
            locals[331] & locals[795] ^
            locals[797] & locals[811];
        locals[749] = (locals[776] ^ ~locals[787]) & locals[795];
        locals[769] = ~(((~((~locals[749] ^ locals[787]) & locals[793]) ^ locals[787] ^ locals[749]) & locals[528] ^
                         locals[795] & locals[811]
            ) & locals[797]) ^ locals[812] & locals[776] & locals[793] ^ locals[528] ^ locals[795];
        locals[812] = (locals[769] ^ locals[800]) & locals[242];
        locals[811] = ~locals[331];
        locals[765] =
            ((locals[704] ^ locals[800] ^ locals[811]) & locals[769] ^ locals[331] ^ locals[704] ^ locals[800]) &
            locals[242] ^
            (locals[769] & ~locals[800] ^ locals[812]) & locals[301] ^ locals[331];
        locals[768] = ~(((locals[242] ^ locals[800]) & (locals[331] ^ locals[769]) ^ locals[331] ^ locals[769]) &
                        locals[301]) ^
                      ~(locals[800] & (locals[331] ^ locals[769])) & locals[242] ^
                      ~locals[769] & locals[331] & locals[704] ^ locals[769];
        locals[769] = (~((locals[800] ^ locals[811]) & locals[242]) ^ locals[331] & ~locals[800] ^ locals[800]) &
                      locals[301] ^
                      (~((locals[242] ^ locals[811]) & locals[769]) ^ locals[331] ^ locals[242]) & locals[704] ^
                      ~locals[812] & locals[331] ^
                      locals[769];
        locals[462] = locals[462] ^ locals[816];
        locals[816] = (locals[768] ^ 0xaaaaaaaa) & locals[760];
        locals[331] = ((locals[765] ^ locals[760] ^ locals[462] ^ 0xaaaaaaaa) & locals[768] ^
                       (locals[760] ^ locals[462] ^ 0x55555555) & locals[765]) & locals[769] ^
                      ((locals[768] ^ locals[760] ^ 0xaaaaaaaa) & locals[772] ^ locals[768] ^ locals[816] ^
                       0xaaaaaaaa) & locals[761]
                      ^ ((locals[760] ^ locals[462] ^ 0xaaaaaaaa) & locals[768] ^ locals[760] ^ 0x55555555) &
                      locals[765] ^
                      (locals[768] ^ locals[816] ^ 0xaaaaaaaa) & locals[772] ^
                      locals[768] & (locals[760] ^ 0xaaaaaaaa) ^
                      0x55555555;
        locals[816] = ~locals[765];
        locals[812] = locals[776] & locals[816];
        locals[811] = (~(locals[769] & (locals[776] ^ locals[816])) ^ locals[765] ^ locals[812]) & locals[768];
        locals[301] = (~(locals[787] & (locals[776] ^ locals[816])) ^ locals[765] ^ locals[812]) & locals[528] ^
                      ~((locals[769] ^ locals[787]) & locals[765]) & locals[776] ^ locals[765] ^ locals[811];
        locals[749] = locals[765] ^ locals[768];
        locals[704] = (((locals[772] ^ locals[760]) & locals[749] ^ locals[765] ^ locals[768]) & locals[769] ^
                       (~(locals[765] & locals[720]) ^ locals[772] ^ locals[760]) & locals[768] ^
                       (locals[760] ^ 0x55555555) & locals[772]
                       ^ ~locals[760] & 0x55555555) & locals[761] ^
                      ((locals[768] & locals[816] ^ locals[769] & locals[749] ^ 0x55555555) & locals[772] ^
                       0xaaaaaaaa) & locals[760]
                      ^ (locals[765] & (locals[772] ^ 0x55555555) ^ locals[772] ^ 0x55555555) & locals[768] ^
                      locals[769] & (locals[772] ^ 0x55555555) & locals[749] ^ ~locals[772] & 0x55555555 ^ locals[765];
        locals[720] = locals[787] & ~locals[768];
        locals[800] = ~locals[769];
        locals[709] = ~((~((~((~((locals[765] ^ locals[800]) & locals[528]) ^ locals[769] & locals[816] ^ locals[765]) &
                              locals[787]) ^
                            ~(locals[779] & locals[765]) & locals[769] ^ locals[765]) & locals[768]) ^
                         (~(locals[787] & locals[800]) ^ locals[769]) & locals[765] & locals[528]) & locals[776]) ^
                      ~((~((~locals[720] ^ locals[768]) & locals[769]) ^ locals[787]) & locals[528]) & locals[765];
        locals[772] =
            (locals[772] & locals[761] ^ 0x55555555) & locals[760] ^ (locals[768] ^ locals[462] ^ 0xaaaaaaaa) &
                                                                   locals[765]
                                                                   ^ locals[768] ^ locals[769] & locals[749] ^
                                                                   0x55555555;
        locals[813] = ~(((~((~locals[812] ^ locals[765]) & locals[769]) ^ locals[765] ^ locals[812]) & locals[768] ^
                         (~(locals[765] & locals[800]) & locals[776] ^ locals[765] ^ locals[811]) & locals[787] ^
                         locals[765] & locals[813]) &
                        locals[528]) ^
                      (((locals[768] ^ locals[720]) & locals[765] ^ locals[768]) & locals[776] ^
                       locals[765] & ~locals[768]) & locals[769] ^
                      (locals[765] ^ locals[787] ^ locals[768] & locals[816]) & locals[776];
        locals[800] = ~locals[704] & locals[331] & locals[772] & 0xffff ^ 0xffff0000;
        locals[816] = locals[331] & ~locals[772];
        locals[787] = ~(locals[816] & locals[704] & 0xffff);
        locals[761] = (~locals[772] ^ locals[704]) & locals[331] ^ locals[772];
        locals[720] = (locals[787] ^ locals[761]) >> 1;
        locals[776] = ~locals[720] & locals[800] >> 1 ^ locals[720] ^ 0x80000000;
        locals[765] = ~(locals[761] >> 0x11) & 0x7fff & locals[787] >> 0x11 ^
                      ~(locals[787] >> 0x11) & locals[761] >> 0x11;
        locals[768] = (locals[761] ^ locals[800]) >> 0x11;
        locals[769] = (locals[761] ^ locals[787]) >> 0x11;
        locals[788] = ~((locals[787] & locals[761]) >> 1 & ~(locals[800] >> 1));
        locals[720] = ~locals[813] ^ locals[301];
        locals[779] = locals[813] ^ locals[301];
        locals[812] = ~((~(locals[795] & locals[720]) ^ locals[797] & locals[720] ^ locals[813] ^ locals[301]) &
                        locals[793]) ^
                      ~locals[301] & locals[813] ^ locals[797] & locals[779];
        locals[760] = (locals[787] ^ locals[800]) >> 1;
        locals[811] = ~(((locals[795] ^ locals[813]) & locals[797] ^ locals[636] & locals[813]) & locals[793]) ^
                      (~locals[301] & locals[813] ^ locals[797] & locals[779]) & locals[709] ^ locals[813] ^
                      locals[301];
        locals[779] = ((locals[795] ^ locals[797]) & locals[779] ^ locals[813] ^ locals[301]) & locals[793] ^
                      locals[779] & locals[709] ^
                      locals[797] ^ locals[301];
        locals[720] = ~locals[812];
        locals[636] = locals[802] & locals[720];
        locals[749] = ~((~((~((~locals[636] ^ locals[812]) & locals[811]) ^ locals[636] ^ locals[812]) & locals[779]) ^
                         locals[802]) &
                        locals[781]) ^ ((~(locals[720] & locals[779]) ^ locals[812]) & locals[811] ^ locals[779]) &
                      locals[802] & locals[774] ^
                      (locals[779] ^ locals[811]) & locals[812] ^ locals[811];
        locals[793] = ~((~((~(((locals[774] ^ locals[781]) & locals[812] ^ locals[774] ^ locals[781]) & locals[802]) ^
                            locals[781] & locals[720] ^ locals[812]) & locals[779]) ^
                         locals[781] & (~locals[636] ^ locals[812]) ^ locals[636]
                         ^ locals[812]) & locals[811]) ^ ~(~locals[774] & locals[802] & locals[812]) & locals[779] ^
                      locals[802];
        locals[779] = ((locals[802] ^ locals[779]) & locals[812] ^ locals[802] ^ locals[779]) & locals[811] ^
                      ((locals[774] ^ locals[781] ^ locals[812]) & locals[802] ^ locals[781] ^ locals[812]) &
                      locals[779] ^
                      locals[802] & locals[774];
        locals[802] = ((locals[793] ^ locals[813] ^ locals[709]) & locals[749] ^
                       (locals[749] ^ locals[813] ^ locals[709]) & locals[301] ^
                       locals[793] ^ locals[813] ^ locals[709]) & locals[779] ^
                      (~((~locals[813] ^ locals[709] ^ locals[301]) & locals[749]) ^ locals[813] ^ locals[709] ^
                       locals[301]) & locals[793] ^
                      locals[813] ^ locals[301];
        locals[720] = (locals[793] ^ locals[779]) & locals[813];
        locals[797] =
            ((locals[793] ^ locals[779]) & locals[749] ^ locals[813] & locals[709] ^ locals[793] ^ locals[779]) &
            locals[301] ^
            (locals[720] ^ locals[793] ^ locals[779]) & locals[749] ^ locals[720] ^ locals[793] ^ locals[709];
        locals[301] = (~((~locals[793] ^ locals[813] ^ locals[709]) & locals[749]) ^
                       (~locals[749] ^ locals[813] ^ locals[709]) & locals[301]
                       ^ locals[793] ^ locals[709]) & locals[779] ^
                      ((locals[813] ^ locals[709] ^ locals[301]) & locals[749] ^ locals[813] ^ locals[709] ^
                       locals[301]) & locals[793] ^
                      (locals[709] ^ locals[301]) & locals[813] ^ locals[301];
        locals[462] = ~(~(locals[802] & 0xffff0000) & locals[301]) & locals[797] ^ 0xffff0000;
        locals[636] = (locals[793] ^ locals[749]) & locals[779];
        locals[720] = ~locals[797];
        locals[781] =
            ~(((locals[797] ^ locals[793] ^ locals[749]) & locals[301] ^ locals[636] ^ locals[797] ^ locals[793]) &
              locals[802]) ^
            (~((locals[797] ^ locals[779]) & locals[301]) ^ locals[797] ^ locals[793] ^ locals[779]) & locals[749] ^
            ((locals[720] ^ locals[779]) & locals[301] ^ locals[797] ^ locals[779]) & locals[793];
        locals[774] = (locals[720] & locals[802] & 0xffff0000 ^ 0xffff) & locals[301] ^ 0xffff0000;
        locals[709] = (locals[301] & locals[802] ^ locals[797]) & 0xffff ^ locals[797];
        locals[636] = ~locals[636];
        locals[799] = ~((~locals[301] & locals[797] ^ locals[636] ^ locals[793]) & locals[802]) ^
                      (locals[636] ^ locals[793]) & locals[301] ^
                      locals[793] ^ locals[749];
        locals[636] = (~locals[802] ^ locals[797]) & locals[793];
        locals[793] = (~((~locals[802] ^ locals[797]) & locals[301]) ^ locals[802] ^ locals[797] ^ locals[793]) &
                      locals[749] ^
                      (locals[636] ^ locals[802] ^ locals[797]) & locals[301] ^ locals[636] ^ locals[797];
        locals[811] = locals[709] >> 1;
        locals[636] = ~(locals[774] >> 1);
        locals[749] = locals[462] >> 1;
        locals[814] = ~(locals[811] & locals[636]) & locals[749] ^ locals[811];
        locals[779] = ~locals[793];
        locals[813] = locals[779] ^ locals[781];
        locals[812] = (~(locals[813] & locals[797]) ^ locals[793] ^ locals[781]) & locals[799];
        locals[778] = ~((((~locals[301] ^ locals[797]) & locals[793] ^ locals[301]) & locals[781] ^
                         locals[720] & locals[793] ^ ~locals[812] ^
                         locals[797]) & locals[802]) ^
                      (~(locals[779] & locals[301]) & locals[781] ^ locals[793]) & locals[797] ^ locals[812] ^
                      locals[793];
        locals[790] = ~(((~((~(locals[813] & locals[802]) ^ locals[779] & locals[781] ^ locals[793]) & locals[799]) ^
                          (~(~locals[781] & locals[802]) ^ locals[781]) & locals[793] ^ locals[781] ^ locals[802]) &
                         locals[797] ^
                         ~(locals[793] & locals[799]) & locals[781] & locals[802]) & locals[301]) ^
                      (~(locals[720] & locals[799]) & locals[793] ^ locals[802] ^ locals[797]) & locals[781] ^
                      (locals[779] ^ locals[802]) & locals[797] ^ locals[793] ^ locals[802];
        locals[636] = locals[749] ^ locals[636];
        locals[753] = (locals[709] ^ locals[774]) << 0xf;
        locals[777] = ~(~locals[811] & locals[749]) ^ locals[774] >> 1;
        locals[301] = (~(locals[813] & locals[799]) ^ locals[793] ^ locals[781]) & locals[301];
        locals[812] =
            ((~(locals[720] & locals[781]) ^ locals[797]) & locals[793] ^ ~locals[301] ^ locals[812] ^ locals[781]) &
            locals[802] ^
            (locals[301] ^ locals[779] & locals[781] ^ locals[793]) & locals[797] ^ locals[781];
        locals[720] = ~locals[331];
        locals[797] = ((locals[720] ^ locals[772]) & locals[790] ^ locals[720] & locals[772] ^ locals[331]) &
                      locals[704] ^
                      (~((~locals[790] ^ locals[772]) & locals[778]) ^ locals[790] ^ locals[772]) & locals[812] ^
                      ((locals[331] ^ locals[778]) & locals[772] ^ locals[778]) & locals[790] ^
                      locals[778] & locals[772];
        locals[813] = ~(locals[709] << 0xf);
        locals[462] = locals[462] << 0xf;
        locals[811] = ~(locals[774] << 0xf & locals[813]) & locals[462] ^ locals[709] << 0xf;
        locals[813] = (~((locals[709] & locals[774]) << 0xf) & locals[462] ^ locals[813]) & 0xffff8000;
        locals[301] = ~((locals[793] ^ locals[799]) & locals[781]) ^ locals[779] & locals[799] ^ locals[793];
        locals[802] = ~locals[799] & locals[781] & 0xffff0000;
        locals[749] = ((locals[331] ^ locals[812] ^ locals[790] ^ locals[772]) & locals[778] ^ locals[812] ^
                       locals[816] ^ locals[790]) &
            locals[704] ^ ~(locals[720] & locals[778]) & locals[772] ^ locals[790];
        locals[799] = (locals[793] & 0xffff ^ locals[799]) & locals[781] ^ ~(~locals[799] & locals[793]) & 0xffff ^
                      locals[799];
        locals[462] = locals[799] << 0x10;
        locals[778] = (~((locals[720] ^ locals[778] ^ locals[772]) & locals[790]) ^
                       (locals[331] ^ locals[812] ^ locals[772]) & locals[778] ^
                       locals[331] ^ locals[812] ^ locals[772]) & locals[704] ^
                      (~((~locals[812] ^ locals[772]) & locals[778]) ^ locals[331] & locals[772] ^ locals[812]) &
                      locals[790] ^
                      (~((locals[720] ^ locals[812]) & locals[778]) ^ locals[331] ^ locals[812]) & locals[772] ^
                      locals[778];
        locals[816] = locals[799] ^ locals[802];
        locals[720] = locals[816] & locals[301];
        locals[812] = locals[720] << 0x10;
        locals[779] = (locals[749] ^ 0xffff0000) & locals[778];
        locals[331] = (~locals[779] ^ locals[749]) & locals[797] ^ locals[779] ^ locals[749];
        locals[793] = ~((~((locals[462] ^ 0xffffffff ^ locals[811]) & locals[812]) ^
                         (locals[811] ^ 0xffffffff) & locals[462] ^
                         (locals[753] ^ 0xffffffff) & locals[811] ^ 0xffffffff) & locals[813]) ^
                      (~locals[812] ^ locals[462] ^ 0xffffffff) & locals[811] & locals[753] ^ 0xffffffff;
        locals[779] = (locals[720] ^ locals[799]) << 0x10;
        locals[772] = ~((locals[813] ^ locals[753]) & locals[779] & locals[811]) ^ locals[812] ^ locals[462] ^
                      0xffffffff ^ locals[813];
        locals[704] = ~(((~locals[462] ^ 0xffffffff ^ locals[811]) & locals[812] ^ locals[811] & locals[462] ^
                         locals[753] & locals[811] ^
                         0xffffffff) & locals[813]) ^ ~((locals[720] & locals[799]) << 0x10) ^
                      (locals[779] ^ 0xffffffff) & locals[811] & locals[753];
        locals[790] = (~((locals[778] ^ 0xffff0000) & locals[749]) ^ locals[778]) & locals[797] ^
                      ~(~locals[778] & locals[749]) & 0xffff0000;
        locals[797] = (locals[778] & locals[749] & 0xffff0000 ^ 0xffff) & locals[797];
        locals[462] = locals[790] >> 0x10;
        locals[781] = (locals[331] & locals[797]) >> 0x10 & ~locals[462] ^ ~(locals[331] >> 0x10) & locals[462];
        locals[811] = (locals[797] ^ locals[331]) >> 0x10;
        locals[779] = ~locals[790];
        locals[813] = locals[779] ^ locals[331];
        locals[749] = (~((locals[813] ^ locals[788]) & locals[776]) ^ (locals[813] ^ locals[776]) & locals[797] ^
                       locals[779] & locals[331] ^
                       locals[788]) & locals[760] ^
                      ((locals[797] ^ locals[790] ^ locals[331]) & locals[776] ^ locals[797] ^ locals[790] ^
                       locals[331]) & locals[788] ^
                      (~locals[331] & locals[797] ^ locals[331]) & locals[790] ^ locals[797];
        locals[462] = ~(locals[331] >> 0x10 & ~locals[462]) & locals[797] >> 0x10 ^ locals[462];
        locals[812] = (locals[462] ^ locals[781]) & locals[811];
        locals[774] = ((~locals[781] ^ locals[768] ^ locals[765]) & locals[462] ^ locals[812]) & locals[769] ^
                      ~locals[462] & locals[811] & locals[781] ^ locals[462] ^ locals[768];
        locals[709] = ~(((~locals[802] ^ locals[301]) & (locals[636] ^ locals[814]) ^ locals[802] ^ locals[301]) &
                        locals[777]) ^
                      (locals[799] ^ locals[636]) & locals[802] ^ (locals[816] ^ locals[636]) & locals[301] ^
                      locals[636];
        locals[800] = ~(((locals[761] ^ locals[800] ^ locals[761] ^ locals[787]) >> 0x11 & (locals[462] ^ locals[781]) ^
                         locals[462] ^
                         locals[781]) & locals[811]) ^ ~((~locals[768] ^ locals[769]) & locals[781]) & locals[462] ^
                      ~(locals[768] & locals[765]) & locals[769];
        locals[811] = (~locals[797] ^ locals[790]) & locals[776];
        locals[787] = (~locals[811] ^ locals[797] ^ locals[790]) & locals[788] ^
                      (locals[811] ^ locals[797] ^ locals[790]) & locals[760] ^
                      locals[331];
        locals[790] = ~(((locals[779] ^ locals[776]) & locals[331] ^ locals[813] & locals[797] ^
                         ~locals[776] & locals[788] ^ locals[776]) &
                        locals[760]) ^ (~locals[797] & locals[790] ^ ~(~locals[776] & locals[788])) & locals[331] ^
                      locals[797] ^ locals[790];
        locals[779] = (locals[802] ^ locals[636] ^ locals[814]) & locals[799];
        locals[753] = (~locals[802] & locals[301] ^ locals[802] ^ locals[636]) & locals[799] ^
                      (locals[779] ^ locals[720] ^ locals[814]) & locals[777] ^ locals[802] ^ locals[301];
        locals[720] = ~locals[781] & locals[462];
        locals[462] = (~locals[768] & locals[765] ^ ~locals[812] ^ locals[720]) & locals[769] ^
                      (locals[720] ^ locals[812]) & locals[768] ^
                      locals[462];
        locals[720] = ~locals[787] ^ locals[749];
        locals[813] = locals[720] & locals[790];
        locals[812] = ~(((~locals[749] ^ locals[793]) & locals[787] ^ locals[813] ^ locals[749]) & locals[772]) ^
                      ~((locals[787] ^ locals[772]) & locals[793]) & locals[704] ^
                      (locals[790] & locals[749] ^ locals[793]) & locals[787];
        locals[799] = ~((~((locals[816] ^ locals[636] ^ locals[814]) & locals[301]) ^
                         (locals[636] ^ locals[814]) & locals[802] ^ locals[779]
                         ^ locals[814]) & locals[777]) ^ (locals[799] & locals[802] ^ locals[636]) & locals[301] ^
                      locals[816] & locals[636] ^
                      locals[799];
        locals[811] = (~(locals[720] & locals[704]) ^ locals[720] & locals[772] ^ locals[787] ^ locals[749]) &
                      locals[790] ^
                      (~((~locals[704] ^ locals[772]) & locals[787]) ^ locals[704] ^ locals[772]) & locals[749] ^
                      ~locals[772] & locals[704] ^
                      (~locals[704] ^ locals[772]) & locals[793] ^ locals[787];
        locals[749] = ~locals[787] & locals[749];
        locals[787] = (~locals[813] ^ locals[749] ^ locals[787]) & locals[772] ^
                      ~((locals[749] ^ locals[813] ^ locals[787]) & locals[704]) ^
                      locals[787];
        locals[749] = ~(locals[811] & 0x3000300) ^ locals[812] & 0x3000300;
        locals[816] = ~locals[787] & locals[811] & locals[812];
        locals[642] = locals[816] & 0x3000300 ^ 0xfcfffcff;
        locals[720] = locals[462] ^ ~locals[799];
        locals[301] =
            (~((locals[774] ^ locals[720]) & locals[800]) ^ (locals[799] ^ locals[800]) & locals[709] ^ locals[799]) &
            locals[753] ^
            (~(~locals[800] & locals[709]) ^ locals[800]) & locals[799] ^ locals[462];
        locals[636] = ~locals[812];
        locals[331] = (((locals[812] ^ 0xffcfffcf) & locals[787] ^ locals[636] & 0xffcfffcf) & locals[811] ^
                       ~(locals[787] & 0xffcfffcf) & locals[812]) & 0x30303030 ^ 0xcfffcfff;
        locals[802] = ((~(locals[812] & 0x3000300) & locals[787] ^ ~(locals[812] & 0xfcfffcff)) & locals[811] ^
                       locals[812]) &
            0xf000f00 ^ 0xf3fff3ff;
        locals[813] = locals[749] >> 6;
        locals[793] = ~(~(~locals[813] & locals[642] >> 6) & locals[802] >> 6) ^ locals[813];
        locals[779] = locals[811] & locals[636] & 0x300030;
        locals[772] = (locals[779] ^ 0x30003000) & locals[787] ^ locals[779] ^ 0xffcfffcf;
        locals[704] =
            ((~(locals[787] & 0xfff3fff3) ^ locals[812] & 0xfff3fff3) & locals[811] ^ locals[812]) & 0xcc00cc ^
            0xff3fff3f;
        locals[797] = ~((locals[787] & ~locals[811] & 0x30003000 ^ 0x300030) & locals[812]);
        locals[761] = (locals[797] ^ locals[331]) >> 2 & ~(locals[772] >> 2);
        locals[781] = (locals[749] ^ locals[642]) >> 6;
        locals[776] = ((locals[812] & 0x30003 ^ 0xc000c000) & locals[811] ^ locals[636] & 0x30003) & locals[787];
        locals[765] = ~(~(~(locals[642] >> 6) & locals[802] >> 6) & locals[813]) ^ (locals[802] & locals[642]) >> 6;
        locals[650] = ~(locals[797] >> 2) & locals[331] >> 2 & ~(locals[772] >> 2);
        locals[768] = ~(~(locals[772] >> 10) & locals[331] >> 10) & locals[797] >> 10 ^ locals[772] >> 10;
        locals[769] = (locals[787] & 0x30003 ^ 0xc000c000) & locals[812] & ~locals[811] ^ 0x3fff3fff;
        locals[788] = (locals[797] ^ locals[772]) >> 2;
        locals[760] = (locals[799] & locals[462] ^ locals[753] & locals[720]) & locals[709] ^
                      (~((locals[800] ^ ~locals[799]) & locals[753]) ^ locals[799] ^ locals[800]) & locals[462] ^
                      ~((locals[753] ^ locals[462]) & locals[774]) & locals[800] ^ locals[753];
        locals[753] = (~locals[462] & locals[774] ^ locals[462]) & locals[800] ^
                      (locals[753] & (locals[462] ^ locals[800]) ^ locals[462] ^ locals[800]) & locals[799] ^
                      (locals[799] ^ locals[753]) & locals[709] & (locals[462] ^ locals[800]) ^ locals[753];
        locals[720] = locals[301] & ~locals[753];
        locals[779] = ~locals[301];
        locals[462] = ((locals[301] & 0xc000c ^ 0xc000c0) & locals[753] ^ locals[779] & 0xcc00cc) & locals[760] ^
                      locals[720] & 0xcc00cc ^ 0xff33ff33;
        locals[800] = (locals[753] & ~locals[760] ^ ~(locals[760] & 0x30003)) & locals[301] & 0xc030c03 ^ 0xfffcfffc;
        locals[774] = ~locals[816] & 0xc000c;
        locals[709] = ((locals[301] ^ 0xc000c) & locals[760] ^ 0xfff3fff3) & locals[753] & 0xcc00cc;
        locals[814] = ((locals[787] & 0x30003 ^ locals[636]) & locals[811] ^ locals[812]) & 0xc003c003 ^ 0x3ffc3ffc;
        locals[790] = ((locals[760] ^ 0xc000c) & locals[753] ^ ~locals[760] & 0xc000c) & locals[301] & 0xcc00cc ^
                      0xfff3fff3;
        locals[777] = ((locals[779] & 0x300030 ^ locals[753]) & locals[760] ^ (locals[753] ^ 0x300030) & locals[301] ^
                       0x300030) &
                      0xc030c030;
        locals[778] = (locals[760] & locals[779] ^ locals[301]) & 0xc000c000 ^ 0x3fff3fff;
        locals[799] = (~(locals[709] << 0xc & ~(locals[462] << 0xc)) & locals[790] << 0xc ^
                       ~((locals[709] & locals[462]) << 0xc))
                      & 0xfffff000;
        locals[816] = locals[769] ^ locals[776];
        locals[795] = locals[816] << 2;
        locals[784] = (locals[814] & locals[816]) << 2;
        locals[813] = (locals[301] ^ ~locals[753]) & locals[760];
        locals[805] = locals[813] & 0x30003000 ^ 0xcfffcfff;
        locals[811] = (~(locals[787] & locals[636]) & locals[811] ^ locals[812]) & 0xc000c;
        locals[90] = ~(~((locals[774] & locals[704]) << 8) & locals[811] << 8) ^ locals[774] << 8;
        locals[787] = ((locals[301] ^ 0x30003) & locals[760] ^ locals[301] & 0xfffcfffc) & locals[753] & 0xc030c03;
        locals[807] = (locals[709] ^ locals[462]) << 0xc ^ 0xfff;
        locals[808] = ~((locals[790] & locals[709]) << 0xc) ^ locals[462] << 0xc;
        locals[732] = locals[769] & locals[776];
        locals[707] = locals[732] << 2;
        locals[648] = ~(locals[760] & locals[301]) & 0xc000c000;
        locals[733] = ~(~(locals[811] << 4) & (locals[774] & locals[704]) << 4) & 0xfffffff0;
        locals[708] = (locals[774] ^ locals[704]) << 4;
        locals[301] =
            ((locals[753] & locals[779] & 0xfffcfffc ^ ~(locals[301] & 0xfffcfffc)) & locals[760] ^ 0xfffcfffc) &
            0xc030c03;
        locals[760] = ~(locals[790] << 8) & locals[462] << 8 ^ locals[709] << 8;
        locals[812] = (locals[301] & (locals[787] ^ locals[800]) ^ locals[800]) << 4;
        locals[772] = (locals[772] & locals[331] ^ locals[797]) >> 10;
        locals[331] = ~(locals[797] >> 10) ^ locals[331] >> 10;
        locals[797] = ~((locals[648] & locals[777]) << 2) ^ locals[778] << 2;
        locals[403] = ~((locals[778] ^ locals[777]) << 2) & locals[648] << 2 ^ locals[777] << 2;
        locals[580] = (locals[787] << 6 & ~(locals[800] << 6) ^ ~(locals[301] << 6)) & 0xffffffc0;
        locals[810] = (locals[787] & locals[800]) << 4;
        locals[721] = (locals[787] ^ locals[800]) << 4;
        locals[375] = ~(locals[777] << 2) & locals[648] << 2 ^ locals[778] << 2 ^ 3;
        locals[666] = (locals[811] ^ locals[704]) << 8;
        locals[645] = (locals[462] ^ locals[790] & locals[709]) << 8;
        locals[636] = ~locals[802];
        locals[646] = (~(locals[810] & (locals[642] ^ locals[636])) ^ locals[642] & locals[636] ^ locals[802]) &
                      locals[749] ^
                      ((locals[721] ^ locals[802]) & locals[812] ^ locals[721] ^ locals[802]) & locals[810] ^
                      (~(locals[812] & locals[636]) ^ locals[802]) & locals[721] ^ locals[802] ^ locals[642];
        locals[696] = (~locals[813] & 0x3000300 ^ locals[720]) & 0x33003300;
        locals[749] = ~((~((~locals[721] ^ locals[642]) & locals[812]) ^ locals[749] & (locals[642] ^ locals[636]) ^
                         locals[721] ^ locals[802]
            ) & locals[810]) ^ (~locals[749] & locals[802] ^ ~locals[812] & locals[721]) & locals[642] ^ locals[802];
        locals[813] = ~(locals[709] << 8) & locals[790] << 8 ^ locals[462] << 8;
        locals[636] = ~(((locals[811] ^ locals[774]) & locals[704]) << 4) & 0xfffffff0;
        locals[462] =
            ~((~((locals[403] ^ locals[761] ^ ~locals[375]) & locals[650]) ^ locals[375] ^ locals[403] ^ locals[761]) &
              locals[797])
            ^ ((locals[797] ^ locals[650]) & locals[761] ^ locals[797] ^ locals[650]) & locals[788] ^ locals[403] ^
            locals[761];
        locals[812] = (locals[802] ^ locals[642]) & locals[812];
        locals[642] = (~locals[812] ^ locals[802] ^ locals[642]) & locals[810] ^
                      (locals[802] ^ locals[642] ^ locals[812]) & locals[721] ^
                      locals[642];
        locals[720] = locals[760] ^ ~locals[645];
        locals[802] = (~((locals[733] ^ ~locals[760]) & locals[708]) ^ locals[733] & ~locals[760] ^ locals[760]) &
                      locals[636] ^
                      ~((~(locals[733] & locals[720]) ^ locals[760] & ~locals[645] ^ locals[645]) & locals[813]) ^
                      locals[760] ^ locals[708];
        locals[709] =
            ((locals[760] ^ locals[708]) & locals[636] ^ locals[813] & locals[720] ^ locals[760] ^ locals[708]) &
            locals[733] ^
            (~locals[636] & locals[708] ^ locals[813] & locals[645] ^ locals[636]) & locals[760] ^ locals[708];
        locals[790] = ~(locals[776] >> 4) & locals[769] >> 4 & locals[814] >> 4 ^ 0xf0000000;
        locals[753] = locals[753] & locals[779] & 0x30003000;
        locals[636] = locals[805] >> 6;
        locals[812] = locals[753] >> 6;
        locals[779] = locals[696] >> 6;
        locals[810] = ~(~locals[636] & locals[812]) & locals[779] ^ (locals[753] & locals[805]) >> 6 ^ 0xfc000000;
        locals[645] =
            ((~locals[797] ^ locals[788] ^ locals[650]) & locals[761] ^ locals[797] ^ locals[788] ^ locals[650]) &
            locals[403] ^
            ~((locals[403] ^ locals[761]) & locals[375]) & locals[797] ^ locals[650] ^ locals[761];
        locals[721] = ~(locals[753] >> 2) & locals[805] >> 2 ^ (locals[696] & locals[753]) >> 2;
        locals[650] = ((locals[375] ^ locals[403] ^ locals[650]) & locals[797] ^ ~locals[650] & locals[403]) &
                      locals[761] ^
                      (~((locals[375] ^ locals[650]) & locals[403]) ^ locals[650] & ~locals[375]) & locals[797] ^
                      (~((~locals[403] ^ locals[797] ^ locals[650]) & locals[761]) ^ locals[403] ^ locals[797] ^
                       locals[650]) & locals[788] ^
                      locals[650];
        locals[797] = (locals[814] ^ locals[769]) >> 4;
        locals[788] = ~(~locals[812] & locals[636]) & locals[779] ^ locals[812];
        locals[733] = ~((locals[733] ^ locals[708]) & locals[813] & locals[720]) ^ locals[760] ^ locals[733];
        locals[813] = ~(~(~(locals[811] << 8) & locals[704] << 8) & locals[774] << 8) ^ locals[704] << 8;
        locals[811] = ((~locals[807] ^ locals[90]) & locals[813] ^ locals[807] & locals[90]) & locals[666] ^
                      (~((locals[90] ^ ~locals[808]) & locals[813]) ^ locals[808] ^ locals[90]) & locals[807] ^
                      ~((locals[813] ^ locals[807]) & locals[799]) & locals[808] ^ locals[90];
        locals[704] = (((locals[301] ^ locals[800]) & locals[787]) << 6 ^ ~(locals[800] << 6)) & 0xffffffc0;
        locals[800] = ~((locals[787] & locals[800]) << 6) ^ locals[301] << 6;
        locals[301] = ~(((locals[666] ^ locals[807] ^ locals[90] ^ locals[799]) & locals[813] ^
                         (~locals[666] ^ locals[799]) & locals[90] ^
                         (locals[90] ^ locals[799]) & locals[807]) & locals[808]) ^
                      (~((locals[813] ^ locals[90]) & locals[666]) ^ ~locals[90] & locals[813]) & locals[807] ^
                      locals[813];
        locals[720] = locals[795] ^ ~locals[800];
        locals[787] = (~(locals[795] & (~locals[580] ^ locals[784])) ^ locals[580] & locals[784]) & locals[707] ^
                      locals[580] & locals[784] & locals[720] ^
                      locals[800] & locals[704] & (~locals[580] ^ locals[784]) ^ locals[795];
        locals[761] = ~((locals[704] ^ locals[580]) & locals[800] & (locals[732] ^ locals[816]) << 2) ^ locals[580] ^
                      locals[707] ^
                      locals[795] ^ locals[784];
        locals[800] = ((~locals[704] ^ locals[784]) & locals[800] ^ (locals[784] ^ locals[720]) & locals[707] ^
                       (locals[784] ^ ~locals[800]) & locals[795] ^ locals[784]) & locals[580] ^
                      (locals[814] & locals[816] ^ locals[732] ^ locals[816]) << 2 & locals[800] & locals[704] ^
                      ~((locals[732] & locals[816]) << 2) & locals[784];
        locals[795] = (locals[753] & locals[805] ^ locals[696]) >> 2;
        locals[704] = ~(locals[769] >> 4) & locals[814] >> 4 & locals[776] >> 4;
        locals[812] = ~(~locals[779] & locals[812]) & locals[636] ^ locals[812];
        locals[816] = (locals[733] ^ locals[462]) & locals[645];
        locals[776] = ~((~((~locals[802] ^ locals[462]) & locals[733]) ^ locals[462] ^ locals[816]) & locals[650]) ^
                      (~((locals[650] ^ ~locals[733]) & locals[802]) ^ locals[733] ^ locals[650]) & locals[709] ^
                      (~(locals[645] & ~locals[733]) ^ locals[733]) & locals[462] ^ locals[645];
        locals[720] = (locals[772] ^ ~locals[788]) & locals[810];
        locals[720] = ~(((locals[788] ^ locals[768]) & locals[772] ^
                         (locals[772] ^ locals[788] ^ locals[810]) & locals[812] ^ locals[788] ^
                         locals[810] ^ locals[768]) & locals[331]) ^
                      (~((~locals[812] ^ locals[788]) & locals[772]) ^ locals[812] ^ locals[788]) & locals[768] ^
                      (locals[772] & ~locals[788] ^ ~locals[720]) & locals[812] ^ locals[788] ^ locals[720];
        locals[90] = ~(((locals[808] ^ locals[90]) & locals[813] ^ locals[90] & ~locals[808]) & locals[666]) ^
                     ((~locals[813] ^ locals[807] ^ locals[799]) & locals[90] ^ locals[813] ^ locals[807] ^
                      locals[799]) & locals[808] ^
                     locals[813] ^ locals[807] ^ locals[90];
        locals[636] = locals[704] ^ locals[790];
        locals[779] = ~locals[704];
        locals[814] = ~(((~locals[790] ^ locals[778]) & locals[777] ^ locals[797] & locals[636] ^
                         locals[790] & locals[779] ^ locals[778]) &
                        locals[648]) ^
                      (~(locals[797] & locals[779]) ^ ~locals[777] & locals[778] ^ locals[704]) & locals[790] ^
                      locals[797] ^
                      locals[777];
        locals[813] = (locals[331] ^ locals[768]) & locals[772];
        locals[774] = (~locals[810] & locals[788] ^ ~locals[813] ^ locals[331] ^ locals[768]) & locals[812] ^
                      (locals[810] ^ locals[331] ^ locals[813] ^ locals[768]) & locals[788] ^ locals[331] ^ locals[772];
        locals[813] = locals[812] & (locals[788] ^ locals[810]);
        locals[788] = (~locals[772] & locals[768] ^ ~locals[813] ^ locals[788] ^ locals[810] ^ locals[772]) &
                      locals[331] ^
                      (locals[788] ^ locals[810] ^ locals[813]) & locals[772] ^ locals[812] ^ locals[788];
        locals[812] = ~(~(locals[805] >> 2) & locals[753] >> 2) ^ locals[696] >> 2;
        locals[331] = ~((locals[812] ^ locals[795]) & (locals[765] ^ locals[781]) & locals[793]) ^
                      (locals[721] & ~locals[812] ^ locals[812]) & locals[795] ^ locals[765];
        locals[813] = ~locals[787];
        locals[772] = (~((locals[301] ^ ~locals[800]) & locals[90]) ^ ~locals[301] & locals[800] ^ locals[301]) &
                      locals[811] ^
                      (~((locals[301] ^ locals[813]) & locals[800]) ^ locals[301] & locals[813] ^ locals[787]) &
                      locals[761] ^
                      ~((locals[90] ^ locals[787]) & locals[800]) & locals[301] ^ locals[90];
        locals[768] = (locals[787] ^ ~locals[800]) & locals[761] & (locals[90] ^ locals[301]) ^
                      ~(locals[787] & (locals[90] ^ locals[301])) & locals[800] ^ locals[90];
        locals[769] = ~(((locals[790] ^ locals[648] ^ locals[778]) & locals[777] ^
                         (locals[790] ^ locals[777]) & locals[704] ^ locals[648] ^
                         locals[778]) & locals[797]) ^ ~(locals[704] & ~locals[777]) & locals[790] ^
                      (locals[648] ^ locals[778]) & locals[777]
                      ^ locals[778];
        locals[760] = ((locals[795] ^ locals[721] ^ locals[793]) & locals[812] ^ locals[795] ^ locals[721]) &
                      locals[765] ^
                      (~locals[795] ^ locals[721]) & locals[812] ^
                      (~locals[812] ^ locals[765]) & locals[781] & locals[793] ^ locals[721];
        locals[795] = ((locals[812] ^ locals[793]) & locals[795] ^ locals[812] ^ locals[793]) & locals[765] ^
                      (locals[812] & (locals[795] ^ locals[765]) ^ locals[795] ^ locals[765]) & locals[721] ^
                      (locals[795] ^ locals[765]) & locals[781] & locals[793] ^ locals[812] ^ locals[795];
        locals[779] = ((locals[636] ^ locals[777]) & locals[648] ^ (locals[636] ^ locals[778]) & locals[777] ^
                       locals[704] ^ locals[790] ^
                       locals[778]) & locals[797] ^
                      (~((locals[790] ^ locals[778]) & locals[777]) ^ locals[790] & locals[779] ^ locals[778]) &
                      locals[648] ^
                      ((locals[779] ^ locals[778]) & locals[777] ^ locals[704] ^ locals[778]) & locals[790];
        locals[636] = (locals[650] ^ locals[645]) & locals[802];
        locals[812] = (~locals[636] ^ locals[650] ^ locals[645]) & locals[733] ^
                      (locals[650] ^ locals[645] ^ locals[636]) & locals[709] ^
                      locals[645];
        locals[645] = (~((locals[802] ^ locals[462]) & locals[733]) ^ locals[816]) & locals[650] ^
                      ((locals[733] ^ locals[650]) & locals[802] ^ locals[733] ^ locals[650]) & locals[709] ^
                      (~locals[462] & locals[645] ^ locals[802] ^ locals[462]) & locals[733] ^ locals[645];
        locals[90] = (~((locals[787] ^ ~locals[90]) & locals[301]) ^ (locals[787] ^ locals[301]) & locals[761] ^
                      (locals[301] ^ ~locals[90]) & locals[811] ^ locals[90] ^ locals[787]) & locals[800] ^
                     (~(locals[761] & locals[813]) ^ locals[90] & locals[811]) & locals[301] ^ locals[90];
        locals[811] = (((locals[90] ^ 0x44444444) & locals[772] ^ locals[90]) & locals[768] ^ 0xbbbbbbbb) & 0xcccccccc;
        locals[462] =
            (~locals[776] & locals[812] & 0x44444444 ^ ~(locals[776] & 0x44444444)) & locals[645] & 0xcccccccc ^
            0xbbbbbbbb;
        locals[816] = (locals[814] ^ locals[769]) & locals[779];
        locals[813] = ~((~((locals[814] ^ ~locals[788]) & locals[774]) ^ (locals[788] ^ locals[769]) & locals[814] ^
                         locals[788] ^ locals[816]
                          ) & locals[720]) ^ (~locals[769] & locals[779] ^ locals[774] & locals[788] ^ locals[769]) &
                      locals[814] ^
                      locals[788];
        locals[636] = locals[720] ^ ~locals[788];
        locals[800] = (locals[636] & locals[769] ^ locals[788] ^ locals[720]) & locals[814] ^
                      locals[636] & (locals[814] ^ locals[769]) & locals[779] ^ locals[720];
        locals[301] = ((locals[812] & 0x44444444 ^ 0x88888888) & locals[645] ^ 0xcccccccc) & locals[776] ^ 0x88888888;
        locals[636] = (locals[642] ^ locals[646]) & (locals[795] ^ locals[760]);
        locals[802] = ~(((locals[646] ^ locals[760]) & locals[642] ^ (locals[642] ^ locals[760]) & locals[331] ^
                         (locals[642] ^ locals[646]) & locals[749]) & locals[795]) ^
                      (~(~locals[646] & locals[749]) ^ ~locals[760] & locals[331] ^ locals[646] ^ locals[760]) &
                      locals[642] ^ locals[760];
        locals[793] =
            (~locals[768] & locals[90] & 0x44444444 ^ ~(locals[768] & 0x44444444)) & locals[772] & 0xcccccccc ^
            0xbbbbbbbb;
        locals[814] = (locals[814] & locals[769] ^ locals[774] ^ locals[816]) & (locals[788] ^ locals[720]) ^
                      locals[788] ^ locals[814];
        locals[774] = ~(~locals[768] & locals[90]) & locals[772] & 0x88888888 ^ locals[768] & 0x44444444;
        locals[772] = (locals[774] ^ locals[793]) >> 1;
        locals[645] = (locals[776] & 0x44444444 ^ 0x88888888) & locals[812] & locals[645];
        locals[781] = ~((locals[645] ^ locals[462]) >> 1) & 0x7fffffff;
        locals[787] = (~(locals[645] >> 1 & ~(locals[301] >> 1)) & locals[462] >> 1 ^ ~(locals[301] >> 1)) & 0x7fffffff;
        locals[704] = ~((locals[301] & locals[645]) >> 1) ^ locals[462] >> 1;
        locals[797] = (~((locals[781] ^ locals[462]) & locals[645]) ^ (locals[704] ^ locals[462]) & locals[781]) &
                      locals[301] ^
                      ((locals[301] ^ ~locals[781]) & locals[704] ^ locals[781] ^ locals[301]) & locals[787] ^
                      locals[645] & locals[462] & ~locals[781];
        locals[331] = (locals[636] ^ locals[642] ^ locals[646]) & locals[749] ^
                      ~(locals[646] & (~locals[795] ^ locals[760])) & locals[642] ^
                      locals[331] & (~locals[795] ^ locals[760]) ^ locals[795];
        locals[816] = locals[813] & 0x44444444;
        locals[812] = ~(locals[814] & 0x44444444) ^ locals[816];
        locals[720] = ~(locals[793] >> 1);
        locals[761] = locals[811] >> 1 & locals[720] ^ locals[793] >> 1 & ~(locals[774] >> 1) ^ 0x80000000;
        locals[636] = ~locals[331] &
                      ((~((locals[795] ^ locals[760]) & locals[646]) ^ locals[795] ^ locals[760]) & locals[642] ^
                       locals[636] & locals[749] ^
                       locals[795]);
        locals[749] = ((locals[331] ^ locals[636]) & locals[802] ^ ~locals[636]) & 0x88888888;
        locals[779] = ~locals[787];
        locals[704] = ((locals[787] ^ locals[462]) & locals[301] ^ locals[462] & locals[779]) & locals[645] ^
                      ~((~locals[704] ^ locals[462]) & locals[301]) & locals[787] ^
                      ~((locals[301] ^ locals[779]) & locals[704]) & locals[781]
            ;
        locals[781] = ~(((~locals[645] ^ locals[462]) & (locals[787] ^ locals[781]) ^ locals[645] ^ locals[462]) &
                        locals[301]) ^
                      (locals[781] ^ locals[779]) & locals[645] & locals[462] ^ locals[781];
        locals[779] = (locals[676] ^ locals[781] ^ locals[705]) & locals[377];
        locals[462] = ((~locals[676] ^ locals[781] ^ locals[705]) & locals[797] ^
                       locals[781] & (locals[676] ^ locals[705]) ^ locals[676]) &
                      locals[377] ^
                      ((locals[377] ^ locals[781]) & locals[797] ^ locals[676] ^ locals[781] ^ locals[779]) &
                      locals[704] ^
                      (~locals[781] ^ locals[797]) & locals[676] ^ locals[781] ^ locals[797];
        locals[301] = locals[811] >> 1 & locals[720] & ~(locals[774] >> 1) ^ 0x80000000;
        locals[787] = ~(((~locals[377] ^ locals[781]) & locals[797] ^ locals[676] ^ locals[779]) & locals[704]) ^
                      (~locals[797] & locals[781] ^ locals[705]) & locals[377] ^ locals[781] ^ locals[797];
        locals[720] = locals[377] & (locals[676] ^ locals[705]);
        locals[704] = (~locals[720] ^ locals[676] ^ locals[781] ^ locals[704]) & locals[797] ^
                      (locals[676] ^ locals[704] ^ locals[720]) & locals[781] ^ locals[377] ^ locals[704];
        locals[816] = (locals[816] ^ 0x88888888) & locals[800];
        locals[813] = ~locals[813];
        locals[788] = (locals[813] & 0xcccccccc ^ locals[816]) & locals[814] ^ locals[816] ^ 0x88888888;
        locals[797] = locals[802] & locals[636] & 0x88888888;
        locals[813] = ~(~locals[814] & locals[800] & locals[813]) & 0x44444444;
        locals[816] = locals[772] ^ locals[793];
        locals[800] = ((locals[811] ^ locals[816]) & locals[774] ^ locals[772] & ~locals[301]) & locals[761] ^
                      (locals[301] & locals[772] ^ locals[793] ^ locals[811]) & locals[774] ^ locals[301] ^ locals[811];
        locals[720] = (locals[301] ^ locals[761]) & locals[772];
        locals[781] = (~(locals[301] & locals[816]) ^ locals[761] & locals[816]) & locals[774] ^
                      ((locals[761] ^ locals[793] ^ ~locals[301]) & locals[774] ^ locals[720]) & locals[811] ^
                      locals[761];
        locals[776] = (locals[813] ^ locals[812]) >> 1;
        locals[774] = (~locals[772] & locals[761] ^ ~locals[793] & locals[774] ^ locals[772]) & locals[301] ^
                      ((locals[301] ^ locals[793]) & locals[774] ^ locals[761] ^ locals[720]) & locals[811] ^
                      locals[761] ^ locals[774];
        locals[816] = locals[781] & ~locals[774];
        locals[720] = (locals[774] ^ locals[781]) & locals[800] ^ locals[816];
        locals[793] = (locals[699] ^ locals[796] ^ locals[720]) & locals[794] ^
                      (locals[796] ^ locals[720]) & locals[699] ^ locals[800];
        locals[720] = locals[208] & (locals[550] ^ locals[754]);
        locals[772] = ((locals[754] ^ ~locals[781]) & locals[550] ^ locals[800] & (locals[781] ^ locals[550]) ^
                       locals[781] ^ locals[720]) &
                      locals[774] ^ (~(locals[800] & ~locals[550]) ^ locals[550]) & locals[781] ^
                      locals[754] & locals[208] & ~locals[550] ^
                      locals[800] ^ locals[550];
        locals[761] =
            ~(((locals[781] ^ locals[754]) & locals[550] ^ locals[774] & (locals[781] ^ locals[550]) ^ ~locals[720]) &
              locals[800])
            ^ (~locals[754] & locals[208] ^ locals[774] & ~locals[781] ^ locals[781] ^ locals[754]) & locals[550] ^
            locals[774];
        locals[811] = ~((locals[788] & locals[813]) >> 1) & locals[812] >> 1 ^ locals[788] >> 1 ^ 0x80000000;
        locals[779] = (locals[331] & 0x44444444 ^ 0x88888888) & locals[802] ^ locals[331] & 0x88888888 ^
                      ~locals[636] & 0x44444444;
        locals[720] = ~locals[699];
        locals[331] = (~((locals[699] ^ locals[796]) & locals[794]) ^ (locals[781] ^ locals[720]) & locals[774] ^
                       (locals[781] ^ ~locals[796]) & locals[699]) & locals[800] ^
                      (locals[794] & ~locals[796] ^ ~locals[816] ^ locals[796]) & locals[699] ^ locals[794];
        locals[301] = ~(locals[788] >> 1) & locals[812] >> 1 ^ locals[813] >> 1 ^ 0x80000000;
        locals[802] = ((locals[781] ^ ~locals[774]) & (locals[699] ^ locals[794]) ^ locals[774] ^ locals[781]) &
                      locals[800] ^
                      (~((locals[794] ^ locals[720]) & locals[774]) ^ locals[699] ^ locals[794]) & locals[781] ^
                      locals[794] & locals[720];
        locals[796] = (locals[797] & locals[749] ^ locals[779]) >> 1;
        locals[774] = (~(locals[754] & (locals[774] ^ locals[800])) ^ locals[774] ^ locals[800]) & locals[550] ^
                      (locals[774] ^ locals[800]) & locals[208] & (locals[550] ^ locals[754]) ^ locals[774];
        locals[816] = locals[776] ^ ~locals[811];
        locals[800] = (~(locals[816] & locals[812]) ^ locals[811] ^ locals[776]) & locals[813] ^
                      (~(locals[788] & locals[816]) ^ locals[811] ^ locals[776]) & locals[812] ^
                      locals[776] & ~locals[811] ^ locals[788];
        locals[781] = ~(((locals[301] ^ locals[812]) & locals[788] ^ locals[301] ^ locals[812]) & locals[776]) ^
                      (~(locals[301] & (locals[776] ^ locals[788])) ^ locals[776] ^ locals[788]) & locals[811] ^
                      ((locals[776] ^ locals[788]) & locals[812] ^ locals[776] ^ locals[788]) & locals[813] ^
                      locals[788];
        locals[816] = ~locals[774];
        locals[794] = ~(~(locals[772] & 0xaaaaaaaa) & locals[774]) ^ locals[761] & locals[816] & 0xaaaaaaaa;
        locals[765] = (~(locals[772] & 0x55555555) ^ locals[774]) & locals[761] ^ locals[774] & locals[772] ^
                      0xaaaaaaaa;
        locals[768] = (locals[779] ^ locals[749]) >> 1;
        locals[769] = ~(~(locals[749] >> 1 & ~(locals[797] >> 1)) & locals[779] >> 1) ^ locals[797] >> 1;
        locals[720] = locals[797] & (~locals[779] ^ locals[749]);
        locals[636] = ~locals[720];
        locals[709] = (~(locals[768] & (~locals[779] ^ locals[749])) ^ locals[779] ^ locals[749]) & locals[797] ^
                      (locals[796] ^ locals[779] ^ locals[636] ^ locals[749]) & locals[769] ^
                      (locals[796] ^ locals[779] ^ locals[749]) & locals[768] ^ locals[796] ^ locals[749];
        locals[812] = (~locals[813] ^ locals[788]) & locals[812];
        locals[788] = (~locals[812] ^ locals[301] ^ locals[813] ^ locals[788]) & locals[776] ^
                      ~((locals[301] ^ locals[813] ^ locals[788] ^ locals[812]) & locals[811]) ^ locals[788];
        locals[813] = (~(~locals[797] & locals[749]) ^ ~locals[769] & locals[796]) & locals[779] ^
                      ((locals[769] ^ locals[779]) & locals[796] ^ locals[779] ^ locals[636] ^ locals[749]) &
                      locals[768] ^ locals[769];
        locals[796] = ~((~locals[761] & locals[774] & 0x55555555 ^ 0xaaaaaaaa) & locals[772]) ^
                      (locals[761] & 0xaaaaaaaa ^ 0x55555555) & locals[774];
        locals[779] = locals[779] ^ (locals[768] ^ locals[720] ^ locals[749]) & locals[769];
        locals[720] = (~locals[566] ^ locals[12]) & locals[567];
        locals[301] = (~locals[781] & locals[800] ^ ~locals[567] & locals[566]) & locals[12] ^
                      ((locals[781] ^ locals[12]) & locals[800] ^ locals[720] ^ locals[566] ^ locals[12]) &
                      locals[788] ^ locals[781];
        locals[636] = (locals[800] ^ locals[567]) & locals[12];
        locals[567] = ~((~((~locals[788] ^ locals[12]) & locals[567]) ^ locals[788] ^ locals[12]) & locals[566]) ^
                      (locals[800] & (~locals[788] ^ locals[12]) ^ locals[788] ^ locals[12]) & locals[781] ^
                      (~locals[636] ^ locals[800] ^ locals[567]) & locals[788] ^ locals[800] ^ locals[636] ^
                      locals[567];
        locals[12] = (~locals[720] ^ locals[566] ^ locals[12]) & locals[788] ^
                     (locals[720] ^ locals[566] ^ locals[12]) & locals[781] ^ locals[12]
            ;
        locals[797] = ((locals[592] ^ locals[150]) & locals[735] ^ ~((locals[813] ^ locals[150]) & locals[779]) ^
                       ~locals[150] & locals[592] ^
                       locals[813] ^ locals[150]) & locals[709] ^
                      (~locals[813] & locals[779] ^ locals[735] & ~locals[592] ^ locals[813]) & locals[150] ^
                      locals[735] ^ locals[813];
        locals[720] = ~locals[592] ^ locals[779];
        locals[788] =
            ~((~(locals[735] & (locals[720] ^ locals[150])) ^ locals[720] & locals[150] ^ locals[592] ^ locals[779]) &
              locals[709])
            ^ ((locals[720] ^ locals[150]) & locals[813] ^ locals[592] ^ locals[779] ^ locals[150]) & locals[735] ^
            (~(locals[720] & locals[813]) ^ locals[592] ^ locals[779]) & locals[150] ^
            (locals[592] ^ locals[779]) & locals[813] ^
            locals[592] ^ locals[779];
        locals[150] =
            ~(((~locals[779] ^ locals[150]) & locals[813] ^ locals[592] & (locals[813] ^ locals[150]) ^ locals[779]) &
              locals[735])
            ^ ~((locals[735] ^ locals[813]) & locals[779]) & locals[709] ^
            (~(~locals[150] & locals[592]) ^ locals[150]) & locals[813] ^ locals[150];
        locals[720] = ~locals[150];
        locals[636] = locals[797] ^ locals[720];
        locals[781] = ~((~((locals[636] ^ locals[704] ^ locals[787]) & locals[462]) ^
                         (locals[636] ^ locals[787]) & locals[704] ^ locals[150])
                        & locals[788]) ^ (~((locals[797] ^ locals[704] ^ locals[787]) & locals[150]) ^ locals[797] ^
                                          locals[787]) & locals[462]
                                       ^ (~((locals[797] ^ locals[787]) & locals[150]) ^ locals[797] ^ locals[787]) &
                                       locals[704];
        locals[776] = ((~locals[704] ^ locals[787]) & (locals[150] ^ locals[788]) ^ locals[704] ^ locals[787]) &
                      locals[462] ^
                      ((locals[788] ^ locals[720]) & locals[787] ^ locals[150] ^ locals[788]) & locals[704] ^
                      locals[797] & (locals[788] ^ locals[720]);
        locals[779] = locals[704] ^ locals[462];
        locals[787] = (locals[797] & locals[779] ^ ~(locals[150] & locals[779]) ^ locals[704] ^ locals[462]) &
                      locals[788] ^
                      (locals[150] & locals[779] ^ locals[704] ^ locals[462]) & locals[797] ^
                      locals[779] & locals[787] ^ locals[150];
        locals[779] = ~locals[797];
        locals[813] = locals[150] & locals[779];
        locals[812] = (locals[787] ^ locals[797]) & locals[150];
        locals[749] = ((locals[797] ^ locals[813]) & locals[787] ^ locals[797]) & locals[776] ^
                      ~(locals[781] & locals[788] & (locals[150] ^ locals[797]) & (locals[776] ^ locals[787])) ^
                      locals[787] ^ locals[797] ^
                      locals[812];
        locals[811] = locals[797] & (locals[776] ^ locals[787]);
        locals[811] =
            ((locals[776] ^ locals[787] ^ locals[811]) & locals[150] ^ locals[776] ^ locals[787] ^ locals[811]) &
            locals[781] ^
            ~(locals[787] & locals[788] & (locals[150] ^ locals[797])) & locals[776] ^ locals[150];
        locals[812] = ((~((~((locals[797] ^ ~locals[787]) & locals[788]) ^ locals[787] & locals[779] ^ locals[797]) &
                          locals[150]) ^
                        ~(~locals[788] & locals[797]) & locals[787] ^ locals[797]) & locals[776] ^
                       locals[787] & locals[797] & locals[788] & locals[720]) & locals[781] ^
                      (~(locals[797] & locals[788] & locals[720]) & locals[787] ^ locals[797]) & locals[776] ^
                      locals[812];
        locals[704] =
            ~(((locals[811] ^ locals[567] ^ locals[12]) & locals[749] ^ locals[811] ^ locals[567] ^ locals[12]) &
              locals[301]) ^
            (~((~locals[749] ^ locals[301]) & locals[811]) ^ locals[749] ^ locals[301]) & locals[812] ^
            (~locals[811] ^ locals[567] ^ locals[12]) & locals[749] ^ locals[811] ^ locals[567];
        locals[768] = ((~locals[811] ^ locals[301]) & locals[749] ^ locals[811] ^ locals[301]) & locals[12] ^
                      ((locals[749] ^ locals[12]) & locals[301] ^ locals[749] ^ locals[12]) & locals[567] ^
                      (locals[811] & (locals[749] ^ locals[12]) ^ locals[749] ^ locals[12]) & locals[812] ^ locals[301];
        locals[811] = (~locals[812] ^ locals[749]) & locals[811];
        locals[749] = locals[749] ^
                      ~((locals[567] & locals[12] ^ locals[811] ^ locals[812] ^ locals[749]) & locals[301]) ^
                      (~locals[811] ^ locals[812] ^ locals[749] ^ locals[567]) & locals[12];
        locals[720] = (locals[768] ^ locals[787]) & locals[704];
        locals[812] = ~locals[768];
        locals[301] = ~(locals[812] & locals[704]) ^ locals[768];
        locals[811] = ~locals[704];
        locals[462] = locals[811] & locals[768];
        locals[769] = (((locals[812] & locals[787] ^ locals[720]) & locals[776] ^ locals[301] & locals[787]) &
                       locals[749] ^
                       ~((~(locals[811] & locals[776]) ^ locals[704]) & locals[768]) & locals[787] ^ locals[776]) &
                      locals[781] ^
                      ((~(~(locals[768] & locals[787]) & locals[704]) ^ locals[768]) & locals[749] ^ locals[462] ^
                       locals[787]) & locals[776]
                      ^ locals[768] & locals[749] & locals[704];
        locals[800] = (locals[812] ^ locals[704]) & locals[749];
        locals[301] = locals[301] & locals[749];
        locals[709] = ((locals[704] ^ locals[787]) & locals[776] ^ locals[811] & locals[787]) & locals[781] ^
                      (locals[800] ^ locals[720] ^ locals[768]) & locals[776] ^ locals[301] ^ locals[462];
        locals[301] = ~(((~((~((locals[812] ^ locals[787]) & locals[704]) ^ locals[812] & locals[787] ^ locals[768]) &
                            locals[749]) ^
                          (~(locals[704] & ~locals[787]) ^ locals[787]) & locals[768] ^ locals[704] ^ locals[787]) &
                         locals[776] ^
                         ~(locals[768] & locals[749]) & locals[704] & locals[787]) & locals[781]) ^
                      ~((~locals[301] ^ locals[812] & locals[704] ^ locals[768]) & locals[787]) & locals[776] ^
                      locals[704];
        locals[787] = ~(((locals[812] ^ locals[774]) & locals[772] ^ locals[768] & locals[816]) & locals[761]) &
                      0x55555555 ^
                      (~locals[772] & locals[774] & 0x55555555 ^ locals[704] ^ 0xaaaaaaaa) & locals[768] ^ locals[800];
        locals[720] = locals[774] ^ locals[772] ^ 0xaaaaaaaa;
        locals[811] = locals[774] ^ 0x55555555;
        locals[462] = (((locals[768] ^ locals[704]) & locals[720] ^ locals[774] ^ locals[772] ^ 0xaaaaaaaa) &
                       locals[749] ^
                       (locals[720] & locals[704] ^ locals[774] ^ locals[772] ^ 0xaaaaaaaa) & locals[768] ^
                       (locals[772] ^ locals[816]) & 0x55555555) & locals[761] ^
                      ((locals[812] & 0x55555555 ^ locals[774]) & locals[704] ^ locals[811] & locals[768] ^
                       locals[774] ^ 0x55555555)
                      & locals[749] ^
                      ((locals[800] ^ locals[462] ^ 0x55555555) & locals[772] ^ locals[462] ^ 0x55555555) &
                      locals[774] ^
                      0xaaaaaaaa;
        locals[720] = (locals[769] ^ locals[709]) & locals[301];
        locals[812] = (~locals[720] ^ locals[769] ^ locals[797]) & locals[788] ^
                      (locals[720] ^ locals[769]) & locals[797] ^ locals[769] ^
                      locals[709];
        locals[781] = ~((~((~locals[301] ^ locals[150] ^ locals[797]) & locals[788]) ^
                         (locals[301] ^ locals[150]) & locals[797] ^ locals[709]
                         ^ locals[150]) & locals[769]) ^
                      (~((locals[301] ^ locals[150] ^ locals[797]) & locals[788]) ^
                       (~locals[301] ^ locals[150]) & locals[797] ^ locals[150])
                      & locals[709] ^ (locals[788] ^ locals[779]) & locals[150];
        locals[800] = (~(((locals[749] ^ locals[704] ^ 0xaaaaaaaa) & (locals[774] ^ locals[772]) ^ locals[749] ^
                          locals[704] ^
                          0xaaaaaaaa) & locals[768]) ^
                       (~((locals[772] ^ locals[816]) & locals[704]) ^ locals[774] ^ locals[772]) & locals[749] ^
                       (locals[772] & 0x55555555 ^ 0xaaaaaaaa) & locals[774] ^ locals[772]) & locals[761] ^
                      (locals[811] & locals[704] ^ locals[774] & 0xaaaaaaaa ^ 0x55555555) & locals[768] ^
                      (((locals[704] ^ 0xaaaaaaaa) & locals[768] ^ locals[800] ^ 0xaaaaaaaa) & locals[772] ^
                       0xaaaaaaaa) &
                      locals[774] ^
                      (locals[811] & (locals[768] ^ locals[704]) ^ locals[774] ^ 0x55555555) & locals[749];
        locals[788] = (locals[788] & locals[636] ^ locals[301] ^ locals[709] ^ locals[813]) & locals[769] ^
                      (~(locals[788] & locals[636]) ^ locals[301] ^ locals[813]) & locals[709] ^ locals[797] ^
                      locals[788];
        locals[816] = locals[800] ^ locals[787];
        locals[811] = ~(locals[800] & locals[787]) & 0xffff0000 ^ locals[816] & locals[462];
        locals[720] = ~locals[788];
        locals[636] = locals[720] & locals[794];
        locals[779] = (~locals[636] ^ locals[788]) & locals[781];
        locals[779] = (~((~((~((locals[720] ^ locals[794]) & locals[781]) ^ locals[636] ^ locals[788]) & locals[812]) ^
                          locals[779] ^
                          locals[788] ^ locals[794]) & locals[765]) ^ ~(locals[781] & locals[812]) & locals[788]) &
                      locals[796] ^
                      (~((~locals[779] ^ locals[636] ^ locals[788]) & locals[812]) ^ locals[779] ^ locals[636] ^
                       locals[788]) & locals[765] ^
                      locals[788];
        locals[636] = locals[720] & locals[781];
        locals[813] = (~(((locals[720] ^ locals[781]) & locals[796] ^ locals[788] & locals[781]) & locals[794] &
                         locals[765]) ^
                       ~((~(~locals[765] & locals[796]) ^ locals[765]) & locals[788]) & locals[781] ^ locals[788]) &
                      locals[812] ^
                      (~(~(locals[636] & locals[794]) & locals[796]) ^ locals[794]) & locals[765] ^ locals[636] ^
                      locals[796];
        locals[749] = ~(locals[800] & locals[787]) & 0xffff;
        locals[796] = ~((~((locals[788] ^ locals[794]) & locals[765]) ^ (locals[720] ^ locals[781]) & locals[812] ^
                         locals[636] ^ locals[788])
                        & locals[796]) ^ (~locals[794] & locals[765] ^ locals[781] & locals[812]) & locals[788];
        locals[772] = locals[816] & ~locals[462] & 0xffff;
        locals[720] = locals[813] & (locals[796] ^ locals[779]);
        locals[636] = locals[796] ^ ~locals[720];
        locals[704] = ~((locals[301] & ~locals[709] ^ locals[796] ^ locals[720]) & locals[769]) ^
                      locals[709] & locals[636] ^ locals[301];
        locals[797] = (locals[709] & (locals[796] ^ locals[779]) ^ locals[796] ^ locals[779]) & locals[813] ^
                      (locals[769] & locals[709] ^ locals[796] ^ ~locals[720]) & locals[301] ^
                      locals[796] & ~locals[709] ^ locals[769];
        locals[709] = ~((locals[796] ^ locals[720]) & locals[301]) ^ locals[769] & locals[636] ^ locals[709];
        locals[301] = (locals[749] ^ locals[811]) >> 1;
        locals[812] = locals[811] >> 0x11;
        locals[761] = locals[812] ^ 0xffffffff;
        locals[811] = locals[811] >> 1;
        locals[636] = locals[772] >> 1;
        locals[772] = ~((locals[749] & locals[772]) >> 1 & ~locals[811]) ^ ~locals[636] & locals[811];
        locals[720] = locals[797] & (~locals[779] ^ locals[813]);
        locals[720] = ~((locals[709] & (~locals[779] ^ locals[813]) ^ ~locals[720] ^ locals[779] ^ locals[813]) &
                        locals[704]) ^
                      (locals[779] ^ locals[813] ^ locals[720]) & locals[709] ^ locals[813] ^ locals[720];
        locals[811] = ~(locals[749] >> 1 & ~locals[811]) & locals[636] ^ locals[811];
        locals[781] = (~locals[709] ^ locals[704]) & locals[797] & 0xffff0000;
        locals[636] = ~locals[797];
        locals[776] = (locals[636] & 0xffff ^ locals[709]) & locals[704] ^
                      (locals[797] & 0xffff ^ 0xffff0000) & locals[709] ^
                      locals[797] & 0xffff;
        locals[814] = ((locals[797] ^ locals[779]) & locals[709] ^ locals[779] & locals[636]) & locals[704] ^
                      (~((locals[709] ^ locals[779]) & locals[796]) ^ locals[709] ^ locals[779]) & locals[813] ^
                      ((locals[797] ^ locals[796]) & locals[709] ^ locals[797] ^ locals[796]) & locals[779] ^
                      locals[709];
        locals[796] = ((locals[797] ^ locals[813]) & locals[709] ^ locals[813] & locals[636]) & locals[704] ^
                      ((locals[796] ^ locals[636]) & locals[709] ^ locals[797] ^ locals[796]) & locals[813] ^
                      ~((locals[709] ^ locals[813]) & locals[796]) & locals[779];
        locals[699] = ((locals[796] ^ 0xffff) & locals[814] ^ locals[796] ^ 0xffff) & locals[720] ^
                      (~locals[814] & locals[796] ^ locals[814]) & 0xffff;
        locals[794] = (locals[796] & locals[814] & 0xffff ^ 0xffff0000) & locals[720] ^ locals[796] & 0xffff;
        locals[779] = ~locals[796];
        locals[774] = ((~((~((locals[797] ^ locals[796]) & locals[720]) ^ locals[796] & locals[636] ^ locals[797]) &
                          locals[709]) ^
                        (~(locals[720] & locals[636]) ^ locals[797]) & locals[796] ^ locals[797]) & locals[704] ^
                       ((~(~locals[720] & locals[709]) ^ locals[720]) & locals[796] ^ locals[709]) & locals[797] ^
                       locals[709]) & locals[814]
                      ^ ~(~(locals[704] & locals[779] & locals[720]) & locals[709]) & locals[797];
        locals[765] = (locals[709] ^ locals[704]) & 0xffff0000;
        locals[768] = (locals[765] ^ locals[781]) << 0xf;
        locals[769] = ~(((locals[814] ^ 0xffff) & locals[796] ^ locals[814] ^ 0xffff) & locals[720]) ^
                      locals[779] & locals[814];
        locals[749] = locals[781] >> 1;
        locals[788] = ~(~(locals[776] >> 1) & locals[749]) ^ locals[765] >> 1;
        locals[813] = locals[709] & (locals[779] ^ locals[814]);
        locals[704] = ~(((~((locals[709] ^ locals[636]) & locals[796]) ^ locals[797] ^ locals[709]) & locals[814] ^
                         (~(locals[797] & (locals[779] ^ locals[814])) ^ locals[813] ^ locals[796] ^ locals[814]) &
                         locals[720]) & locals[704])
                      ^ (locals[814] ^ locals[636]) & locals[709] ^ locals[797] & locals[814];
        locals[636] = locals[699] << 0x10;
        locals[760] = ~(~(locals[769] << 0x10 & ~locals[636]) & locals[794] << 0x10) ^ locals[636];
        locals[814] = ((~(locals[709] & locals[779]) ^ locals[796]) & locals[814] ^
                       (~locals[813] ^ locals[796] ^ locals[814]) & locals[720])
            & locals[797] ^ locals[709] ^ locals[814];
        locals[779] = ~(~(~(locals[765] << 0xf) & locals[781] << 0xf) & locals[776] << 0xf) ^ locals[781] << 0xf;
        locals[790] = ~((locals[769] & locals[794]) << 0x10 & ~locals[636]) ^ ~(locals[769] << 0x10) & locals[636];
        locals[813] = (locals[769] ^ locals[794]) << 0x10;
        locals[796] = ((locals[816] ^ locals[704] ^ locals[774]) & locals[814] ^ locals[800] ^ locals[787]) &
                      locals[462] ^
                      locals[816] & locals[814] ^ locals[800] ^ locals[704];
        locals[797] = ~(locals[765] >> 1) & locals[776] >> 1 ^ locals[749];
        locals[749] = ~((locals[765] & locals[776]) >> 1) ^ locals[749];
        locals[720] = (~locals[787] ^ locals[774]) & locals[814];
        locals[709] = (locals[814] & locals[774] ^ locals[462] & ~locals[800] ^ locals[800]) & locals[787] ^
                      ~((~(locals[816] & locals[462]) ^ locals[800] ^ locals[787] ^ locals[720]) & locals[704]) ^
                      locals[462] ^ locals[814];
        locals[781] = ~((locals[776] & locals[781]) << 0xf) & locals[765] << 0xf ^ locals[776] << 0xf;
        locals[776] = ((locals[790] ^ locals[813]) & (locals[781] ^ locals[779]) ^ locals[790] ^ locals[813]) &
                      locals[768] ^
                      ((locals[790] ^ locals[813]) & locals[781] ^ locals[790] ^ locals[813]) & locals[779] ^
                      (~locals[790] ^ locals[813]) & locals[760] ^ locals[790];
        locals[462] = ((locals[816] ^ locals[774]) & locals[462] ^ ~locals[787] & locals[774] ^ locals[800]) &
                      locals[814] ^
                      ~(((locals[787] ^ ~locals[800] ^ locals[814]) & locals[462] ^ locals[800] ^ locals[787] ^
                         locals[720]) & locals[704]) ^
                      ~(locals[800] & ~locals[462]) & locals[787];
        locals[800] =
            ((locals[797] ^ locals[788]) & (locals[794] ^ locals[699]) ^ locals[794] ^ locals[699]) & locals[749] ^
            locals[797] ^
            locals[794];
        locals[816] = locals[790] ^ locals[760];
        locals[720] = ~locals[790] ^ locals[760];
        locals[787] = (locals[816] & (locals[781] ^ locals[779]) ^ locals[790] ^ locals[760]) & locals[768] ^
                      (locals[816] & locals[781] ^ locals[790] ^ locals[760]) & locals[779] ^
                      locals[720] & locals[813] ^ locals[760];
        locals[704] = (~((locals[788] ^ locals[794]) & locals[749]) ^ (locals[769] ^ locals[699]) & locals[794] ^
                       ~locals[699] & locals[769])
            & locals[797] ^ (~locals[788] & locals[749] ^ ~locals[769] & locals[699]) & locals[794] ^ locals[699];
        locals[636] = ~locals[794] ^ locals[699];
        locals[699] = (~(locals[636] & locals[797]) ^ locals[636] & locals[788] ^ locals[794] ^ locals[699]) &
                      locals[749] ^
                      locals[636] & locals[769] ^ (locals[794] ^ locals[699]) & locals[797] ^ locals[699];
        locals[790] = (locals[720] & locals[779] ^ ~(locals[720] & locals[781]) ^ locals[790] ^ locals[760]) &
                      locals[768] ^
                      (~(locals[720] & locals[781]) ^ locals[790] ^ locals[760]) & locals[779] ^
                      locals[816] & locals[813] ^ locals[790];
        locals[779] = ~(((locals[796] ^ 0xffff0000) & locals[709] ^ locals[796] ^ 0xffff0000) & locals[462]) ^
                      ~locals[709] & locals[796];
        locals[797] = ((locals[709] ^ 0xffff) & locals[462] ^ ~locals[709] & 0xffff) & locals[796] ^
                      (locals[462] ^ locals[709]) & 0xffff ^ locals[709];
        locals[709] = (~locals[796] & locals[462] & 0xffff ^ 0xffff0000) & locals[709];
        locals[816] = (~locals[301] ^ locals[772]) & locals[811];
        locals[720] = ~locals[797];
        locals[813] = (locals[720] & locals[779] ^ locals[301] ^ locals[816] ^ locals[797]) & locals[709] ^
                      (locals[301] ^ locals[816]) & locals[797] ^ locals[811];
        locals[749] = ((locals[301] ^ locals[779] ^ locals[797] ^ locals[772]) & locals[709] ^ locals[772]) &
                      locals[811] ^
                      (~locals[301] ^ locals[779] ^ locals[797]) & locals[709] ^ locals[797];
        locals[811] = (~((locals[301] ^ locals[709] ^ locals[772]) & locals[797]) ^ locals[301]) & locals[811] ^
                      ~((locals[720] ^ locals[811]) & locals[779]) & locals[709] ^ locals[301] & locals[720];
        locals[816] = ~locals[749] ^ locals[811];
        locals[720] = ~locals[811];
        locals[462] = ~((~(locals[816] & locals[813]) ^ (locals[720] ^ locals[790]) & locals[787] ^
                         locals[720] & locals[749] ^ locals[811]) &
                        locals[776]) ^ (locals[749] & locals[813] ^ locals[790] & locals[787]) & locals[811] ^
                      locals[813] ^ locals[790];
        locals[816] = (locals[816] ^ locals[787]) & locals[813];
        locals[636] = (~locals[749] ^ locals[787]) & locals[811];
        locals[301] = (~locals[816] ^ locals[636] ^ locals[749] ^ locals[787]) & locals[790] ^
                      (locals[636] ^ locals[816] ^ locals[749] ^ locals[787]) & locals[776] ^ locals[811];
        locals[790] = ((locals[720] ^ locals[787]) & locals[790] ^ ~((locals[720] ^ locals[790]) & locals[749])) &
                      locals[813] ^
                      ((~locals[813] ^ locals[790]) & locals[787] ^ locals[813] ^ locals[790]) & locals[776] ^
                      (~(locals[720] & locals[790]) ^ locals[811]) & locals[749] ^ locals[811] ^ locals[790];
        locals[811] = (~(locals[797] >> 0x10) & locals[709] >> 0x10 ^ ~(locals[779] >> 0x10)) & 0xffff;
        locals[816] = locals[790] & locals[462];
        locals[749] =
            ((~(locals[790] & 0xc000c0) & locals[462] ^ locals[790]) & locals[301] ^ locals[816] & 0xff3fff3f) &
            0x3c003c0;
        locals[796] = ~(locals[790] & locals[301] & 0xc000c00);
        locals[720] = ~locals[790] & locals[301];
        locals[772] = (locals[720] & 0x300030 ^ 0xc000c000) & locals[462] ^ locals[790] & 0x300030;
        locals[813] = ~((locals[790] & 0x30003 ^ locals[462]) & locals[301] & 0xc030c03) ^ locals[816] & 0xc030c03;
        locals[787] = ((locals[462] ^ 0xc000c0) & ~locals[790] & locals[301] ^ locals[790] & 0xff3fff3f) & 0x3c003c0;
        locals[781] = ((locals[790] & 0xc000c000 ^ 0x300030) & locals[462] ^ locals[790] & 0xc030c030) & locals[301] ^
                      locals[816] & 0x300030;
        locals[776] = (~(locals[779] >> 0x10) & locals[797] >> 0x10 ^ ~(locals[709] >> 0x10)) & 0xffff;
        locals[814] = (locals[779] & locals[797] ^ locals[709]) >> 0x10;
        locals[797] = (locals[720] ^ locals[790]) & 0xc000c00;
        locals[779] = locals[776] & locals[811] ^ ~((locals[761] ^ locals[776] ^ locals[812]) & locals[814]) ^
                      locals[761];
        locals[636] = (~locals[761] ^ locals[814]) & locals[776];
        locals[794] = (locals[812] ^ locals[814]) & locals[812] ^ ~(locals[776] & locals[814]) & locals[761] ^
                      (locals[761] ^ locals[636] ^ locals[814]) & locals[811];
        locals[696] = locals[796] << 2;
        locals[774] = locals[790] & locals[301] & 0x30003000;
        locals[765] = ~(locals[720] & 0x30003000) ^ locals[790] & 0x30003000;
        locals[814] = (locals[812] ^ locals[776] & locals[814]) & locals[761] ^
                      ~((locals[761] ^ locals[636] ^ locals[812]) & locals[811]) ^
                      locals[814];
        locals[761] = (locals[796] ^ locals[813]) << 2;
        locals[720] = ~locals[814];
        locals[776] = ~((~((locals[720] ^ locals[704]) & locals[779]) ^ locals[720] & locals[704] ^ locals[814]) &
                        locals[794]) ^
                      ((~locals[779] ^ locals[699]) & locals[814] ^ locals[699]) & locals[704] ^
                      ((locals[720] ^ locals[704]) & locals[699] ^ locals[814] ^ locals[704]) & locals[800] ^
                      locals[720] & locals[699] ^
                      locals[779];
        locals[768] = ((locals[790] ^ 0xff3fff3f) & locals[301] ^ locals[790] & 0xc000c0) & locals[462] & 0x3c003c0;
        locals[769] = ~(((locals[720] ^ locals[779]) & locals[794] ^ (locals[779] ^ locals[704]) & locals[699] ^
                         locals[720] & locals[779] ^
                         locals[814]) & locals[800]) ^
                      (~(~locals[704] & locals[699]) ^ locals[814] & locals[794]) & locals[779] ^ locals[814]
                      ^ locals[704];
        locals[709] = locals[813] << 2 ^ 0xffffffff;
        locals[788] = ((locals[790] ^ locals[462]) & locals[301] ^ locals[816]) & 0x300c300c;
        locals[760] = (locals[787] ^ locals[749]) << 4;
        locals[720] = (locals[720] ^ locals[794] ^ locals[699]) & locals[779];
        locals[636] = (~locals[794] ^ locals[699]) & locals[814];
        locals[814] = (~locals[720] ^ locals[636] ^ locals[794]) & locals[800] ^
                      (locals[636] ^ locals[720] ^ locals[794]) & locals[704] ^
                      (locals[814] ^ locals[779]) & locals[699] ^ locals[814];
        locals[800] =
            (((locals[790] ^ 0xffcfffcf) & locals[462] ^ locals[790] & 0x300030) & locals[301] ^ locals[816]) &
            0xc030c030;
        locals[810] = ~(locals[768] >> 6 & ~(locals[749] >> 6)) ^ locals[749] >> 6;
        locals[676] = (locals[788] & locals[765] ^ locals[774]) >> 10;
        locals[816] = (locals[776] ^ 0x3000300) & locals[769];
        locals[301] = ((locals[816] ^ 0xfcfffcff) & locals[814] ^ locals[816]) & 0x33003300;
        locals[704] = ((locals[769] ^ 0x3000300) & locals[814] ^ locals[769] & 0xfcfffcff) & locals[776] & 0x33003300;
        locals[816] = ~locals[776];
        locals[794] = ~locals[769] & locals[816] & locals[814] & 0x30003000 ^ locals[769] & 0x3000300;
        locals[699] = ~(locals[774] >> 10) & locals[788] >> 10 ^ (locals[774] ^ locals[765]) >> 10;
        locals[720] = (locals[769] ^ locals[776]) & locals[814];
        locals[636] = locals[769] & locals[776];
        locals[462] = (locals[636] ^ locals[720]) & 0x3c003c;
        locals[790] = ((locals[800] ^ locals[772]) & locals[781]) >> 4;
        locals[753] = locals[636] & 0x30003;
        locals[403] = (locals[636] & 0xfffcfffc ^ locals[720]) & 0xc300c3;
        locals[779] = (locals[768] ^ locals[749]) >> 6;
        locals[777] = ~((locals[787] & (locals[768] ^ locals[749])) >> 6);
        locals[812] = (locals[774] ^ locals[765]) << 8;
        locals[812] = ~(~locals[812] & locals[788] << 8) ^ locals[812];
        locals[811] = locals[794] >> 6;
        locals[778] = ~(~locals[811] & locals[301] >> 6) & locals[704] >> 6 ^ locals[811];
        locals[799] = ~(locals[814] & 0xc000c00) ^ locals[776] & 0xc000c00;
        locals[795] = ~((locals[776] & 0xf3fff3ff ^ locals[769] ^ 0xc000c00) & locals[814] & 0xcc00cc00) ^
                      (locals[769] ^ 0xc000c00) & locals[776] & 0xcc00cc00;
        locals[749] = locals[749] << 4;
        locals[375] = ~((locals[768] & locals[787]) << 4) ^ locals[749];
        locals[787] = (~locals[749] & locals[768] << 4 ^ locals[749]) & locals[787] << 4 ^ locals[768] << 4;
        locals[768] = ~(~(~(locals[772] >> 2) & locals[781] >> 2) & locals[800] >> 2) ^ locals[781] >> 2;
        locals[720] = ~(locals[301] >> 2);
        locals[749] = locals[794] >> 2;
        locals[735] = locals[749] & locals[720] ^ (locals[704] & locals[301]) >> 2;
        locals[636] = ~(locals[816] & locals[769] & 0x30003) ^ locals[776] & 0x30003;
        locals[816] = (locals[816] & locals[814] ^ locals[776]) & 0x300030;
        locals[784] = (locals[788] ^ locals[765]) << 8;
        locals[805] = ~(locals[636] << 6) & (locals[403] & locals[753]) << 6;
        locals[807] = ~(~locals[749] & locals[301] >> 2) ^ locals[704] >> 2;
        locals[769] = (locals[814] ^ locals[776]) & locals[769] & 0x300030;
        locals[808] = ~(locals[800] >> 4) ^ locals[781] >> 4;
        locals[732] = locals[403] << 8 ^ 0xffffffff;
        locals[707] = ~(locals[636] << 8);
        locals[648] = (locals[769] ^ locals[816]) << 2;
        locals[776] = locals[814] & locals[776] & 0xc000c00;
        locals[814] = ~locals[776];
        locals[774] = ~(locals[765] >> 10) & locals[788] >> 10 ^ locals[774] >> 10;
        locals[749] = locals[704] >> 2 & locals[720] ^ locals[749];
        locals[788] = locals[769] << 2;
        locals[720] = locals[462] << 2;
        locals[721] = ~(~(locals[816] << 2) & locals[788]) & locals[720] ^ locals[788];
        locals[765] = ~((locals[636] & locals[403]) << 6 & ~(locals[753] << 6));
        locals[788] = ~((locals[769] & locals[816]) << 2) & locals[720] ^ locals[788];
        locals[816] = ~locals[749];
        locals[645] = (~((locals[749] ^ locals[807] ^ locals[779] ^ locals[777]) & locals[735]) ^
                       (~locals[807] ^ locals[779] ^ locals[777]) & locals[749]) & locals[810] ^
                      ((locals[816] ^ locals[807] ^ locals[779]) & locals[735] ^
                       (locals[807] ^ locals[779]) & locals[749]) & locals[777] ^
                      locals[749];
        locals[769] = ((locals[749] ^ locals[735]) & locals[807] ^ (~locals[735] ^ locals[777]) & locals[749] ^
                       (locals[816] ^ locals[777]) & locals[779]) & locals[810] ^
                      (~locals[779] & locals[777] ^ ~(~locals[735] & locals[807]) ^ locals[735]) & locals[749] ^
                      locals[735] ^ locals[777];
        locals[708] = (locals[721] ^ locals[648]) & locals[768] ^ 0xffffffff ^
                      (~locals[788] & locals[648] ^ locals[788]) & locals[721] ^
                      locals[788];
        locals[753] = (locals[403] ^ locals[753]) << 6;
        locals[403] = locals[403] << 8;
        locals[580] = ~(~((locals[799] ^ locals[795]) << 4) & locals[814] << 4) ^ locals[799] << 4;
        locals[794] = (locals[794] ^ locals[301]) >> 6;
        locals[720] = ~locals[788] ^ locals[648];
        locals[636] = locals[720] & (~((locals[772] & locals[781]) >> 2) & locals[800] >> 2 ^ locals[772] >> 2);
        locals[666] = (~(locals[720] & locals[768]) ^ locals[636] ^ locals[788] ^ locals[648]) &
                      (locals[781] ^ locals[772]) >> 2 ^
                      (~locals[636] ^ locals[788] ^ locals[648]) & locals[768] ^
                      (locals[788] ^ locals[648]) & locals[721] ^ locals[648];
        locals[646] = ~((~((locals[805] ^ locals[696]) & locals[709]) ^ (locals[753] ^ locals[696]) & locals[805] ^
                         (locals[753] ^ locals[805]) & locals[765]) & locals[761]) ^
                      (~locals[696] & locals[709] ^ ~locals[753] & locals[765] ^ locals[753] ^ locals[696]) &
                      locals[805] ^ locals[696];
        locals[810] = ((locals[777] ^ locals[810]) & locals[779] ^ (locals[816] ^ locals[810]) & locals[777] ^
                       (locals[816] ^ locals[777]) & locals[807] ^ locals[749] ^ locals[810]) & locals[735] ^
                      (~(~locals[810] & locals[779]) ^ locals[749] & locals[807]) & locals[777] ^ locals[749] ^
                      locals[810];
        locals[721] = (locals[788] ^ locals[721]) & locals[768] ^ ~(~locals[721] & locals[788]) & locals[648] ^
                      locals[721];
        locals[749] = (locals[814] & locals[799] ^ locals[795]) << 4;
        locals[779] = ~(locals[772] >> 4) & locals[800] >> 4 & locals[781] >> 4;
        locals[811] = ~(~(locals[704] >> 6) & locals[301] >> 6) ^ locals[811];
        locals[800] =
            (~((locals[403] ^ locals[787] ^ locals[760]) & locals[375]) ^ (~locals[787] ^ locals[760]) & locals[403]) &
            locals[732]
            ^ ((locals[787] ^ locals[375] ^ locals[760]) & locals[732] ^ locals[787] ^ locals[375] ^ locals[760]) &
            locals[707] ^
            locals[760];
        locals[816] = (locals[794] ^ locals[778]) & locals[811];
        locals[720] = ~locals[794];
        locals[301] = (~(~locals[774] & locals[676]) ^ locals[811] & locals[720] ^ locals[774]) & locals[778] ^
                      ~(((locals[774] ^ locals[778]) & locals[676] ^ locals[774] ^ locals[778] ^ locals[816]) &
                        locals[699]) ^ locals[811] ^
                      locals[676];
        locals[636] = (locals[753] ^ locals[805]) & locals[813] << 2;
        locals[772] = ~(locals[753] & (~locals[761] ^ locals[696])) & locals[805] ^
                      (locals[753] ^ locals[805] ^ locals[636]) & locals[765] ^
                      locals[709] & (~locals[761] ^ locals[696]) ^ locals[696];
        locals[704] = ~((~((locals[760] ^ ~locals[403] ^ locals[707]) & locals[375]) ^
                         locals[760] & (locals[403] ^ locals[707]) ^ locals[707]
                          ) & locals[732]) ^
                      ((locals[375] ^ ~locals[403] ^ locals[707]) & locals[732] ^ locals[707] ^ locals[375] ^
                       locals[760]) & locals[787] ^
                      (~locals[375] ^ locals[760]) & locals[707] ^ locals[760];
        locals[781] = ((locals[778] ^ locals[720]) & locals[676] ^ locals[794] & locals[778]) & locals[811] ^
                      (~((locals[811] ^ locals[774] ^ locals[778]) & locals[676]) ^ locals[774] ^ locals[778] ^
                       locals[816]) & locals[699] ^
                      (~((~locals[811] ^ locals[778]) & locals[676]) ^ locals[811] ^ locals[778]) & locals[774] ^
                      locals[778];
        locals[696] = (~(locals[753] & locals[813] << 2) ^ locals[761] ^ locals[696]) & locals[805] ^
                      locals[765] & locals[636] ^ locals[696];
        locals[816] = (locals[814] ^ locals[799] ^ locals[795]) & locals[790];
        locals[816] = ~(((locals[776] ^ locals[795] ^ locals[790]) & locals[799] ^
                         (locals[814] ^ locals[808] ^ locals[795]) & locals[790] ^
                         locals[814] ^ locals[808] ^ locals[795]) & locals[779]) ^
                      (locals[814] ^ locals[799] ^ locals[795] ^ locals[816]) & locals[808] ^ locals[814] ^ locals[816];
        locals[636] = ~((locals[808] ^ ~locals[779]) & locals[790]);
        locals[761] = ~((~locals[795] & locals[814] ^ locals[779] ^ locals[808] ^ locals[636]) & locals[799]) ^
                      (locals[779] ^ locals[808] ^ locals[636]) & locals[795] ^ locals[779] ^ locals[814];
        locals[676] = ((locals[774] ^ locals[778] ^ locals[699] ^ locals[720]) & locals[676] ^ locals[794] ^
                       locals[774] ^ locals[778] ^
                       locals[699]) & locals[811] ^ locals[778] ^ locals[699] ^ locals[676];
        locals[811] = locals[795] << 4 & ~(locals[814] << 4) ^ locals[799] << 4 ^ 0xf;
        locals[720] = (~locals[799] ^ locals[790]) & locals[814];
        locals[636] = locals[814] ^ ~locals[779];
        locals[720] = (~(locals[790] & locals[636]) ^ locals[779] ^ locals[814]) & locals[808] ^
                      (locals[799] & locals[636] ^ locals[779] ^ locals[814]) & locals[795] ^
                      (~locals[720] ^ locals[799] ^ locals[790]) & locals[779] ^ locals[790] ^ locals[720];
        locals[636] = ~locals[749];
        locals[776] = ~(((locals[813] ^ locals[580] ^ locals[636]) & locals[811] ^ ~locals[813] & locals[797] ^
                         locals[580] & locals[636]) &
                        locals[796]) ^
                      (locals[813] & ~locals[797] ^ locals[797] ^ ~locals[580] & locals[749]) & locals[811] ^
                      locals[749];
        locals[779] = (locals[796] ^ ~locals[797]) & locals[813];
        locals[794] = (~locals[779] ^ locals[797] ^ locals[796]) & locals[811] ^
                      (locals[797] ^ locals[796] ^ locals[779]) & locals[749] ^
                      locals[796];
        locals[375] = (~((locals[732] ^ locals[760]) & locals[375]) ^ locals[732] ^ locals[760]) & locals[787] ^
                      ((locals[375] ^ locals[403] ^ locals[707]) & locals[760] ^ locals[403] ^ locals[375]) &
                      locals[732] ^
                      locals[707] & locals[760] ^ locals[375];
        locals[779] = locals[816] ^ ~locals[720];
        locals[787] = ~(((locals[301] ^ ~locals[676]) & (locals[720] ^ locals[816]) ^ locals[676] ^ locals[301]) &
                        locals[781]) ^
                      (~(locals[301] & locals[779]) ^ locals[720] ^ locals[816]) & locals[676] ^
                      locals[761] & locals[779] ^ locals[301];
        locals[779] = locals[800] & ~locals[704];
        locals[774] = ~(((locals[375] ^ locals[721]) & locals[708] ^ locals[375] & (locals[704] ^ locals[721]) ^
                         locals[704] ^ locals[779]) &
                        locals[666]) ^ (~locals[721] & locals[708] ^ ~locals[779] ^ locals[721]) & locals[375] ^
                      locals[800];
        locals[704] = ((locals[721] ^ locals[708]) & (~locals[375] ^ locals[800]) ^ locals[375] ^ locals[800]) &
                      locals[666] ^
                      (~(locals[721] & (~locals[375] ^ locals[800])) ^ locals[375] ^ locals[800]) & locals[708] ^
                      (locals[721] ^ ~locals[704]) & locals[375] ^ locals[800] & (locals[704] ^ locals[721]) ^
                      locals[704] ^ locals[721];
        locals[666] = ((locals[721] ^ locals[666]) & (locals[375] ^ locals[800]) ^ locals[375] ^ locals[800]) &
                      locals[708] ^
                      (locals[666] & (locals[375] ^ locals[800]) ^ locals[375] ^ locals[800]) & locals[721] ^
                      locals[375] & locals[800] ^
                      locals[666];
        locals[800] = (~((locals[676] ^ locals[761] ^ locals[301] ^ ~locals[720]) & locals[781]) ^
                       (locals[720] ^ locals[676] ^ locals[761]) & locals[301] ^ locals[720] ^ locals[676]) &
                      locals[816] ^
                      (~((locals[676] ^ locals[761] ^ locals[301]) & locals[720]) ^ locals[761] ^ locals[301]) &
                      locals[781] ^
                      ((locals[761] ^ ~locals[676]) & locals[720] ^ locals[761]) & locals[301] ^
                      locals[720] & locals[676];
        locals[779] = (locals[580] ^ locals[813]) & locals[749];
        locals[813] = (~((locals[796] ^ locals[636]) & locals[813]) ^ locals[749] ^ locals[796]) & locals[797] ^
                      (locals[796] & (locals[580] ^ locals[636]) ^ locals[580] ^ ~locals[580] & locals[749]) &
                      locals[811] ^
                      (~locals[779] ^ locals[580] ^ locals[813]) & locals[796] ^ locals[580] ^ locals[779] ^
                      locals[813];
        locals[462] = locals[462] << 0xc;
        locals[636] = ~locals[666];
        locals[749] = (locals[704] & locals[636] ^ locals[666] & ~locals[774]) & 0xcccccccc;
        locals[720] = (~(locals[720] & (locals[781] ^ locals[301])) ^ locals[781] ^ locals[301]) & locals[816] ^
                      ((locals[781] ^ locals[301]) & (locals[720] ^ locals[816]) ^ locals[781] ^ locals[301]) &
                      locals[761] ^
                      ~locals[781] & locals[301] ^ locals[720];
        locals[816] = ((locals[720] ^ 0xbbbbbbbb) & locals[800] ^ ~locals[720]) & locals[787] & 0xcccccccc ^ 0x77777777;
        locals[779] = ~locals[784] ^ locals[812] ^ locals[462];
        locals[811] = ~(~locals[462] & locals[812]) & locals[784] ^ locals[812];
        locals[301] = ~(~(locals[720] & ~locals[787]) & locals[800] & 0x88888888) ^ locals[787] & 0x44444444;
        locals[765] = locals[704] & ~locals[774] & 0x44444444;
        locals[720] =
            ((locals[720] ^ 0x44444444) & locals[800] & ~locals[787] ^ locals[787] & 0x44444444) & 0xcccccccc ^
            0xbbbbbbbb;
        locals[462] = (locals[812] ^ locals[784] & (locals[812] ^ 0xffffffff)) & locals[462];
        locals[812] = (~((locals[301] & locals[816]) >> 1) ^ ~(locals[816] >> 1) & locals[720] >> 1) & 0x7fffffff;
        locals[797] = (locals[720] & locals[816] ^ locals[301]) >> 1;
        locals[800] = ~(locals[720] >> 1) & locals[816] >> 1 ^ locals[301] >> 1 ^ 0x80000000;
        locals[796] =
            ((~locals[812] ^ locals[816]) & locals[797] ^ (locals[720] ^ locals[816]) & locals[301] ^ locals[720]) &
            locals[800] ^
            (~locals[301] & locals[720] ^ locals[797] & locals[812] ^ locals[301]) & locals[816] ^ locals[797] ^
            locals[812];
        locals[787] = (locals[774] & locals[636] ^ locals[666]) & 0x44444444 ^
                      ~((locals[774] ^ locals[636]) & locals[704] & 0x44444444);
        locals[704] = ~((~((locals[301] ^ locals[800] ^ locals[812]) & locals[797]) ^
                         locals[301] & (~locals[800] ^ locals[812])) &
                        locals[816]) ^
                      ((locals[797] ^ locals[800] ^ locals[812] ^ locals[816]) & locals[301] ^ locals[797] ^
                       locals[800] ^ locals[812] ^
                       locals[816]) & locals[720] ^ locals[800];
        locals[797] = ((locals[301] ^ ~locals[800] ^ locals[812]) & locals[797] ^
                       locals[301] & (locals[800] ^ locals[812]) ^ locals[812]) &
                      locals[816] ^ (~((locals[812] ^ locals[816] ^ ~locals[797] ^ locals[800]) & locals[301]) ^
                                     locals[797] ^
                                     locals[800] ^
                                     locals[812] ^ locals[816]) & locals[720] ^
                      locals[812] & (~locals[797] ^ locals[800]) ^
                      locals[797];
        locals[816] = ~locals[813];
        locals[800] = ((locals[813] ^ locals[769] ^ locals[645]) & locals[810] ^
                       (locals[810] ^ locals[816]) & locals[794] ^
                       locals[769] & ~locals[645]) & locals[776] ^
                      (~(locals[810] & ~locals[645]) ^ locals[645]) & locals[769] ^
                      (~(locals[810] & locals[816]) ^ locals[813]) & locals[794] ^ locals[810] ^ locals[645];
        locals[812] = locals[749] >> 1;
        locals[301] = ~(locals[765] >> 1) & locals[812] ^ locals[787] >> 1;
        locals[720] = ~locals[111] ^ locals[751];
        locals[636] = ~locals[111] & locals[751];
        locals[761] =
            ~(((~locals[796] ^ locals[751]) & locals[797] ^ locals[720] & locals[264] ^ locals[796] ^ locals[636]) &
              locals[704]) ^
            (~locals[797] & locals[796] ^ ~locals[264] & locals[111]) & locals[751] ^ locals[111];
        locals[781] = ((~locals[769] ^ locals[645]) & locals[810] ^ (locals[769] ^ locals[816]) & locals[645] ^
                       (locals[813] ^ locals[645]) & locals[794] ^ locals[813] ^ locals[769]) & locals[776] ^
                      (locals[810] & locals[769] ^ locals[794] & locals[816]) & locals[645] ^ locals[810];
        locals[813] = locals[813] & (locals[810] ^ locals[645]);
        locals[645] = (locals[794] & (locals[810] ^ locals[645]) ^ ~locals[813]) & locals[776] ^
                      (locals[810] ^ locals[645] ^ locals[813]) & locals[794] ^ locals[645];
        locals[813] = (~locals[696] & locals[462] ^ locals[779] & (locals[462] ^ locals[696])) & locals[811] ^
                      (~((~locals[779] ^ locals[772]) & locals[462]) ^ locals[779] ^ locals[772]) & locals[696] ^
                      (locals[772] & (locals[462] ^ locals[696]) ^ locals[462] ^ locals[696]) & locals[646];
        locals[774] = ~(locals[787] >> 1) ^ locals[812];
        locals[776] = ((~locals[645] & locals[800] ^ locals[645]) & 0x44444444 ^
                       (locals[645] & 0x44444444 ^ locals[800] ^ 0xbbbbbbbb) & locals[781]) & 0xcccccccc;
        locals[812] = ~(~((locals[787] & locals[749]) >> 1) & locals[765] >> 1) ^ locals[812];
        locals[794] = ~(locals[781] & 0x88888888) ^ locals[800] & 0x88888888;
        locals[646] = ~((locals[811] ^ ~locals[462]) & locals[779]) ^ (locals[696] ^ locals[646]) & locals[772] ^
                      locals[462] & locals[811] ^
                      locals[696] ^ locals[646];
        locals[816] = (locals[111] ^ locals[751]) & locals[797];
        locals[772] = (~locals[816] ^ locals[111] ^ locals[751]) & locals[704] ^
                      (locals[111] ^ locals[816] ^ locals[751]) & locals[796] ^
                      locals[751];
        locals[800] = (~locals[781] ^ locals[800]) & locals[645] & 0x88888888;
        locals[816] = ~locals[749] ^ locals[812];
        locals[779] = locals[765] & ~locals[749];
        locals[781] =
            ((locals[816] ^ locals[774]) & locals[301] ^ (locals[765] ^ locals[774]) & locals[749] ^ locals[765]) &
            locals[787] ^
            ((~locals[765] ^ locals[812]) & locals[749] ^ locals[765] ^ locals[812]) & locals[301] ^
            (~(locals[816] & locals[301]) ^ locals[779]) & locals[774];
        locals[636] = (~locals[751] & locals[111] ^ ~(locals[704] & locals[720]) ^ locals[751]) & locals[264] ^
                      (~((~locals[704] ^ locals[751]) & locals[797]) ^ locals[704] ^ locals[751]) & locals[796] ^
                      ((locals[111] ^ locals[797]) & locals[751] ^ locals[111]) & locals[704] ^ locals[636];
        locals[811] = locals[800] >> 1;
        locals[720] = locals[776] >> 1;
        locals[796] = ~locals[811] & locals[720] ^ locals[794] >> 1;
        locals[816] = ~((~locals[787] ^ locals[765]) & locals[749]);
        locals[765] = ~((locals[812] & locals[301] ^ locals[787] ^ locals[765] ^ locals[816]) & locals[774]) ^
                      (locals[787] ^ locals[765] ^ locals[816]) & locals[301] ^
                      (locals[787] ^ locals[765]) & locals[749] ^ locals[765];
        locals[816] = ~(locals[794] >> 1);
        locals[811] = ~(~(locals[816] & locals[811]) & locals[720]) ^ locals[811];
        locals[816] = locals[816] ^ locals[720];
        locals[696] = locals[696] ^ ~locals[462];
        locals[462] = locals[696] & locals[646] & locals[813] & 0x44444444;
        locals[704] = ((locals[696] ^ locals[813]) & locals[646] ^ locals[813]) & 0xcccccccc;
        locals[797] = ~(~(locals[696] & locals[813]) & locals[646] & 0x44444444) ^ locals[813] & 0x44444444;
        locals[774] = (~((~locals[812] ^ locals[774]) & locals[301]) ^ locals[779]) & locals[787] ^
                      ~(locals[749] & (~locals[812] ^ locals[774])) & locals[301] ^ locals[749] ^ locals[774];
        locals[720] = ~locals[800] ^ locals[794];
        locals[787] = (locals[800] & locals[794] ^ locals[720] & locals[811]) & locals[776] ^
                      (~((~locals[796] ^ locals[794]) & locals[800]) ^ locals[796] ^ locals[794]) & locals[811] ^
                      (~((locals[811] ^ locals[800]) & locals[796]) ^ locals[811] ^ locals[800]) & locals[816] ^
                      locals[796];
        locals[779] = (~locals[816] ^ locals[796]) & locals[794];
        locals[779] = (~(locals[720] & locals[816]) ^ locals[720] & locals[796] ^ locals[800] ^ locals[794]) &
                      locals[776] ^
                      ~(locals[816] & locals[796]) & locals[811] ^
                      (locals[779] ^ locals[816] ^ locals[796]) & locals[800] ^ locals[779];
        locals[720] = locals[816] ^ locals[811];
        locals[813] = (locals[720] ^ locals[794]) & locals[796];
        locals[816] = ((locals[720] ^ locals[796] ^ locals[794]) & locals[800] ^
                       (locals[720] ^ locals[796]) & locals[794] ^ locals[816] ^
                       locals[811] ^ locals[796]) & locals[776] ^
                      (~locals[813] ^ locals[720] & locals[794] ^ locals[816] ^ locals[811]) & locals[800] ^
                      locals[720] & locals[794] ^
                      locals[813] ^ locals[816];
        locals[720] = ~locals[229] ^ locals[57] ^ locals[774];
        locals[813] = ~(locals[273] & locals[720]);
        locals[812] = (locals[229] ^ locals[774]) & locals[57];
        locals[749] = ~(((locals[229] ^ locals[774] ^ locals[765]) & locals[57] ^
                         (locals[720] ^ locals[765]) & locals[273] ^ locals[774] ^
                         locals[765]) & locals[781]) ^ (locals[812] ^ locals[813] ^ locals[774]) & locals[765] ^
                      (~locals[273] ^ locals[57]) & locals[774] ^ locals[57];
        locals[794] = ((~locals[273] ^ locals[774]) & locals[765] ^ locals[229] & locals[57] ^ locals[813]) &
                      locals[781] ^
                      (~locals[765] & locals[774] ^ ~locals[57] & locals[229] ^ locals[57]) & locals[273] ^ locals[57] ^
                      locals[765];
        locals[720] = (~locals[792] ^ locals[773]) & locals[782];
        locals[813] = ~locals[816];
        locals[811] = locals[813] & locals[779];
        locals[796] = (locals[813] ^ locals[779]) & locals[787] ^ ~locals[792] & locals[773] ^ locals[811] ^
                      locals[720];
        locals[788] =
            ((~locals[779] ^ locals[773]) & locals[816] ^ (locals[792] ^ locals[779]) & locals[773] ^ locals[720]) &
            locals[787] ^
            (~locals[782] & locals[792] ^ locals[811]) & locals[773];
        locals[779] = locals[704] >> 1;
        locals[813] = locals[797] >> 1;
        locals[800] = ~(locals[462] >> 1) & locals[779] ^ locals[813];
        locals[781] =
            ~((~((locals[229] ^ locals[57]) & locals[273]) ^ (locals[57] ^ locals[774]) & locals[781] ^ locals[812]) &
              locals[765])
            ^ (~(locals[273] & ~locals[229]) ^ ~locals[774] & locals[781] ^ locals[229] ^ locals[774]) & locals[57] ^
            locals[273] ^
            locals[781];
        locals[787] = locals[787] ^ locals[773];
        locals[816] = ~locals[788];
        locals[776] = ((locals[788] ^ locals[794]) & locals[781] ^ locals[816] & locals[794]) & locals[749] ^
                      (~((locals[781] ^ locals[787]) & locals[794]) ^ locals[781] ^ locals[787]) & locals[788] ^
                      ((locals[788] ^ locals[794]) & locals[787] ^ locals[788] ^ locals[794]) & locals[796] ^
                      locals[781] ^ locals[787] ^
                      locals[794];
        locals[301] = ~((locals[704] & locals[462]) >> 1) ^ locals[813];
        locals[720] = ~locals[787];
        locals[782] = ~(((locals[720] ^ locals[794] ^ locals[749]) & locals[781] ^
                         (locals[787] ^ locals[749]) & locals[794] ^ locals[787]) &
                        locals[788]) ^ (~((locals[781] ^ locals[794]) & locals[749]) ^ ~locals[794] & locals[781]) &
                      locals[787] ^
                      (~((~locals[781] ^ locals[788] ^ locals[794]) & locals[787]) ^ locals[781] ^ locals[788] ^
                       locals[794]) & locals[796] ^
                      locals[781];
        locals[709] = ~locals[813] & locals[779] ^ ~locals[779] & locals[462] >> 1;
        locals[794] = ((locals[816] ^ locals[794] ^ locals[796]) & locals[787] ^
                       (locals[720] ^ locals[794]) & locals[749] ^ locals[788] ^
                       locals[796]) & locals[781] ^ ~(~locals[749] & locals[794]) & locals[787] ^ locals[788] ^
                      locals[794];
        locals[779] = ~locals[794];
        locals[813] = locals[776] & (locals[782] ^ locals[779]);
        locals[812] = (locals[782] & locals[779] ^ locals[813]) & locals[787] & locals[788];
        locals[781] = ~((~(locals[720] & locals[782] & locals[776]) & locals[794] ^ locals[782] ^ locals[812]) &
                        locals[796]) ^
                      (~(~(locals[816] & locals[787]) & locals[794] & locals[776]) ^ locals[794]) & locals[782];
        locals[811] = ~locals[709];
        locals[773] = (~((locals[709] ^ locals[301]) & locals[800]) ^ (locals[462] ^ locals[811]) & locals[704] ^
                       locals[301] ^ locals[462]) &
                      locals[797] ^ (~locals[301] & locals[800] ^ locals[301] ^ ~locals[704] & locals[462]) &
                      locals[709] ^
                      locals[301];
        locals[749] = (~(locals[788] & locals[779]) ^ locals[794]) & locals[787];
        locals[769] = (~((~((~(locals[720] & locals[794]) ^ locals[787]) & locals[782]) ^ locals[787] ^
                          locals[720] & locals[794]) &
                         locals[776]) ^ locals[794] ^ locals[782] ^ locals[812]) & locals[796] ^
                      (~((~locals[749] ^ locals[794]) & locals[782]) ^ locals[794] ^ locals[749]) & locals[776] ^
                      locals[794] & locals[782];
        locals[816] = (locals[816] ^ locals[796]) & locals[787];
        locals[812] = ((locals[796] ^ locals[816]) & locals[794] ^ locals[816]) & locals[782] ^
                      locals[796] & locals[779] ^ locals[794];
        locals[774] = (locals[812] & (locals[769] ^ locals[772]) ^ locals[772] & ~locals[769]) & locals[781] ^
                      ((~locals[812] ^ locals[636]) & locals[769] ^ locals[812] ^ locals[636]) & locals[772] ^
                      ~(locals[636] & (locals[769] ^ locals[772])) & locals[761];
        locals[720] = locals[769] & (~locals[772] ^ locals[761]);
        locals[765] = ~((~(locals[812] & (~locals[772] ^ locals[761])) ^ locals[772] ^ locals[761] ^ locals[720]) &
                        locals[781]) ^
                      (~locals[720] ^ locals[772] ^ locals[761]) & locals[812] ^
                      (locals[772] ^ locals[761]) & locals[769] ^ locals[772];
        locals[720] = (locals[301] ^ locals[811]) & locals[704];
        locals[768] = (~locals[720] ^ locals[709] ^ locals[301]) & locals[462] ^
                      (locals[709] ^ locals[301] ^ locals[720]) & locals[797] ^
                      locals[301];
        locals[769] = (locals[812] & (locals[769] ^ locals[761]) ^ locals[761] & ~locals[769]) & locals[781] ^
                      ((locals[812] ^ locals[636]) & locals[769] ^ locals[812] ^ locals[636]) & locals[761] ^
                      (~(locals[636] & (locals[769] ^ locals[761])) ^ locals[769] ^ locals[761]) & locals[772] ^
                      locals[769];
        locals[709] = ~(((locals[797] ^ locals[462]) & locals[704] ^ (locals[797] ^ locals[811]) & locals[800] ^
                         locals[797] ^ locals[462]) &
                        locals[301]) ^
                      (locals[709] & locals[800] ^ locals[704] ^ ~locals[704] & locals[462]) & locals[797] ^
                      locals[709];
        locals[720] = ~locals[769];
        locals[636] = locals[782] & (locals[774] ^ locals[720]);
        locals[812] = ~locals[636] ^ locals[769] ^ locals[774];
        locals[811] = (~(locals[782] & ~locals[774]) ^ locals[774]) & locals[769];
        locals[772] = (~(locals[765] & locals[812]) ^ locals[811]) & locals[794] ^ locals[782];
        locals[749] = ~locals[768];
        locals[462] = (locals[773] ^ locals[749]) & locals[709];
        locals[800] = locals[773] & locals[749];
        locals[301] = ~locals[331];
        locals[704] = (locals[802] & locals[301] ^ locals[768] ^ locals[800] ^ locals[462]) & locals[793] ^
                      (~locals[462] ^ locals[331] ^ locals[768] ^ locals[800]) & locals[802] ^ locals[331] ^
                      locals[768];
        locals[797] = ~(((locals[463] ^ locals[768]) & locals[14] ^ (locals[768] ^ locals[14]) & locals[773] ^
                         (locals[463] ^ locals[14]) & locals[727] ^ locals[463] ^ locals[768]) & locals[709]) ^
                      (~(~locals[463] & locals[727]) ^ locals[800]) & locals[14] ^ locals[727];
        locals[462] = locals[768] & (locals[727] ^ locals[14]);
        locals[761] = (locals[773] & (locals[727] ^ locals[14]) ^ ~locals[462]) & locals[709] ^
                      (locals[727] ^ locals[462] ^ locals[14]) & locals[773] ^ locals[727];
        locals[462] = locals[802] ^ locals[331] ^ locals[793];
        locals[666] = ((locals[768] ^ locals[462]) & locals[773] ^ locals[768] & locals[462] ^ locals[802] ^
                       locals[331] ^ locals[793]) &
                      locals[709] ^ ((locals[773] ^ locals[331] ^ locals[793]) & locals[768] ^ locals[331] ^
                                     locals[793] ^ locals[773]) &
                      locals[802] ^ (locals[768] & (locals[331] ^ locals[793]) ^ locals[331] ^ locals[793]) &
                      locals[773] ^
                      (locals[793] ^ locals[301]) & locals[768] ^ locals[793];
        locals[800] = ~((~(locals[773] & (locals[768] ^ locals[301])) ^ locals[331] & locals[749] ^ locals[768]) &
                        locals[709]) ^
                      ((~locals[802] ^ locals[773]) & locals[768] ^ locals[773]) & locals[331] ^
                      (locals[802] & (locals[768] ^ locals[301]) ^ locals[331] ^ locals[768]) & locals[793] ^
                      locals[802] ^ locals[800];
        locals[749] = ~locals[727] ^ locals[14];
        locals[14] = ((locals[768] ^ locals[773]) & locals[749] ^ locals[727] ^ locals[14]) & locals[709] ^
                     (~(locals[768] & locals[749]) ^ locals[727] ^ locals[14]) & locals[773] ^
                     locals[463] & locals[749] ^ locals[14];
        locals[792] = (~((~(locals[794] & (locals[774] ^ locals[720])) ^ locals[769] ^ locals[774] ^ locals[636]) &
                         locals[765]) ^
                       (~(locals[774] & (locals[782] ^ locals[779])) ^ locals[794] ^ locals[782]) & locals[769] ^
                       locals[794] ^ locals[782]) &
            locals[776] ^ locals[794] ^ locals[782];
        locals[813] = (~(locals[794] & locals[812]) ^ locals[769] ^ locals[774]) & locals[765] ^
                      (locals[782] ^ locals[811]) & locals[794] ^
                      locals[769] & ~locals[774] ^ locals[782] ^ locals[813];
        locals[636] = ~locals[813];
        locals[779] = locals[813] ^ locals[792];
        locals[301] = ((locals[772] ^ locals[779] ^ locals[788]) & locals[787] ^ locals[813] ^ locals[792] ^
                       locals[772] ^ locals[788]) &
                      locals[796] ^ (~((locals[772] ^ locals[787] ^ locals[636]) & locals[788]) ^ locals[813] ^
                                     locals[772] ^ locals[787]) &
                      locals[792] ^ ((locals[813] ^ locals[772]) & locals[788] ^ locals[813] ^ locals[772]) &
                      locals[787] ^
                      locals[813] ^ locals[788];
        locals[812] = ~locals[14] & locals[761];
        locals[331] = (locals[797] & 0xaaaaaaaa ^ 0x55555555) & locals[14] ^ (locals[797] ^ locals[812]) & 0x55555555 ^
                      locals[812];
        locals[811] = (locals[792] ^ locals[787]) & locals[813];
        locals[811] = (~(locals[787] & (locals[636] ^ locals[788])) ^ locals[813] ^ locals[788]) & locals[796] ^
                      ~(locals[792] & (locals[636] ^ locals[788])) & locals[772] ^
                      (locals[792] ^ locals[787] ^ locals[811]) & locals[788] ^
                      locals[787] ^ locals[811];
        locals[749] = locals[797] ^ locals[761];
        locals[802] = (locals[761] ^ locals[769] ^ locals[765] ^ locals[14] & locals[749] ^ 0x55555555) & locals[774] ^
                      (locals[14] ^ locals[812] ^ 0x55555555) & locals[797] ^ locals[769] ^ locals[765] & locals[720];
        locals[793] = locals[802] ^ 0xaaaaaaaa;
        locals[812] = locals[813] & ~locals[792];
        locals[788] = (~locals[816] ^ locals[792] ^ locals[812] ^ locals[788] ^ locals[796]) & locals[772] ^
                      (locals[788] ^ locals[796] ^ locals[816]) & locals[792] ^ locals[813] ^ locals[788];
        locals[816] = locals[797] ^ locals[761] ^ locals[14] & locals[749];
        locals[462] = (locals[769] ^ 0x55555555) & locals[14] ^ locals[769];
        locals[462] = ((locals[769] & locals[749] ^ locals[797] ^ locals[761]) & locals[14] ^
                       (locals[749] ^ 0x55555555) & locals[769] ^
                       locals[797] ^ locals[761] ^ 0x55555555) & locals[765] ^
                      ((locals[816] ^ locals[769] ^ 0x55555555) & locals[765] ^
                       (locals[816] ^ 0x55555555) & locals[769] ^
                       0xaaaaaaaa) & locals[774] ^ (locals[462] ^ 0xaaaaaaaa) & locals[797] ^
                      (locals[462] ^ 0x55555555) & locals[761] ^ locals[769] & 0x55555555 ^ 0xaaaaaaaa;
        locals[796] = ~(((locals[797] ^ 0xaaaaaaaa) & locals[14] ^ locals[797] ^ 0x55555555) & locals[761]) ^
                      locals[797];
        locals[816] = (locals[765] ^ locals[720]) & locals[774] ^ locals[765] & locals[720];
        locals[787] = ((locals[816] ^ locals[797] ^ locals[769] ^ 0xaaaaaaaa) & locals[761] ^
                       (locals[816] ^ locals[769] ^ 0x55555555) & locals[797]) & locals[14] ^
                      ((locals[769] ^ locals[765]) & (locals[761] ^ 0x55555555) ^ locals[761] ^ 0xaaaaaaaa) &
                      locals[774] ^
                      ((locals[761] ^ 0x55555555) & locals[769] ^ locals[761] ^ 0x55555555) & locals[765] ^
                      (locals[797] ^ locals[769] ^ 0xaaaaaaaa) & locals[761] ^ locals[769] & 0x55555555 ^
                      locals[797] & 0xaaaaaaaa
            ;
        locals[781] = (locals[787] ^ locals[462]) & 0xffff;
        locals[797] = (locals[14] ^ locals[797]) & 0x55555555 ^ (locals[797] ^ 0xaaaaaaaa) & locals[761] ^ 0xaaaaaaaa;
        locals[816] = locals[796] ^ locals[331];
        locals[720] = ~(locals[797] & locals[816]) ^ locals[796];
        locals[749] = locals[720] ^ locals[301];
        locals[761] = ~(locals[749] & locals[788]) ^ locals[749] & locals[811];
        locals[773] = ((locals[788] ^ locals[811]) & locals[816] & locals[301] ^ locals[796] ^ locals[331]) &
                      locals[797] ^
                      ((locals[788] ^ locals[811]) & locals[796] ^ locals[788] ^ locals[811]) & locals[301] ^
                      ~locals[811] & locals[788] ^
                      locals[796] ^ locals[811];
        locals[301] = (~locals[462] & 0xffff0000 ^ locals[793]) & locals[787] ^
                      (locals[802] ^ 0x5555aaaa) & locals[462];
        locals[331] = ~(locals[787] & locals[462] & 0xffff);
        locals[749] = locals[301] >> 0x11;
        locals[802] = ~(locals[331] >> 0x11) ^ locals[749];
        locals[796] = ~locals[749] & locals[331] >> 0x11;
        locals[811] = ~(~(locals[720] & locals[811]) & locals[788]) ^ locals[811];
        locals[797] = ((locals[811] ^ locals[761]) & locals[792] ^ locals[811] ^ locals[761]) & locals[813] ^
                      ~((locals[811] ^ locals[761]) & locals[772] & locals[779]) ^ locals[811] ^ locals[792];
        locals[816] = locals[781] >> 1;
        locals[776] = (~(locals[301] >> 1) & locals[816] ^ ~(locals[331] >> 1)) & 0x7fffffff;
        locals[782] = ~(locals[331] >> 1) & locals[301] >> 1 ^ locals[816] ^ 0x80000000;
        locals[301] = (locals[331] & locals[301] ^ locals[781]) >> 1;
        locals[816] = ~locals[761];
        locals[331] = ((locals[761] ^ locals[792]) & locals[773] ^ locals[772] & locals[779] ^ locals[761] ^
                       locals[792] ^ locals[812]) &
                      locals[811] ^
                      (locals[773] & locals[816] ^ locals[772] & locals[636] ^ locals[761]) & locals[792] ^
                      locals[761];
        locals[792] = (~((locals[816] ^ locals[792]) & locals[811]) ^ locals[816] & locals[792] ^ locals[761]) &
                      locals[773] ^
                      (~(locals[811] & ~locals[792]) ^ locals[792]) & locals[813] ^
                      (locals[811] & locals[779] ^ locals[812]) & locals[772] ^
                      locals[761] ^ locals[792];
        locals[779] = locals[792] & locals[331] & locals[797] & 0xffff0000;
        locals[720] = locals[331] & (locals[792] ^ locals[797]);
        locals[772] = (~locals[811] ^ locals[773]) & locals[761] ^ locals[811] ^ locals[773] ^ locals[720];
        locals[781] = locals[792] ^ ~locals[720];
        locals[811] = (~locals[797] & locals[331] ^ locals[811] & locals[816] ^ locals[761]) & locals[792] ^
                      ((locals[792] ^ locals[811]) & locals[761] ^ locals[792] ^ locals[811] ^ ~locals[720]) &
                      locals[773];
        locals[773] = locals[792] ^ locals[773];
        locals[816] = locals[773] & ~locals[811];
        locals[761] = (~locals[816] & locals[772] ^ locals[773]) & 0xffff0000;
        locals[813] = ~(~(locals[331] & locals[797]) & locals[792] & 0xffff0000) ^ locals[331] & 0xffff0000;
        locals[812] = locals[813] << 0xf;
        locals[636] = ~(~(locals[781] << 0xf) & locals[812]) & locals[779] << 0xf;
        locals[794] = locals[636] ^ locals[812];
        locals[774] = (~((locals[813] ^ locals[779]) >> 1) & locals[781] >> 1 ^
                       ~(locals[813] >> 1 & ~(locals[779] >> 1))) &
                      0x7fffffff;
        locals[765] = (locals[781] ^ locals[779]) >> 1;
        locals[768] = ((locals[773] & (locals[792] ^ locals[720]) ^ locals[792] ^ locals[720]) & locals[811] ^
                       locals[773] ^ locals[720]) &
            locals[772] ^ locals[773] & locals[331] & (locals[792] ^ locals[797]) ^ locals[792];
        locals[769] = locals[772] & locals[816] & 0xffff0000;
        locals[816] = (locals[773] ^ ~locals[811]) & locals[772] ^ locals[773];
        locals[331] = ~(((~locals[331] & locals[811] & locals[772] ^ locals[331]) & locals[773] ^
                         locals[331] & locals[797] & locals[816] ^
                         locals[772]) & locals[792]) ^
                      ((~(~locals[773] & locals[811]) ^ locals[773]) & locals[331] & locals[797] ^ locals[773]) &
                      locals[772] ^ locals[773];
        locals[812] = ~((locals[813] & locals[781]) << 0xf) & locals[779] << 0xf ^ locals[812];
        locals[797] = ~(locals[781] >> 1) & locals[779] >> 1;
        locals[709] = ((locals[761] ^ ~locals[816]) & locals[765] ^ locals[761] ^ ~locals[761] & locals[816]) &
                      locals[769] ^
                      (locals[797] ^ locals[774] ^ locals[761]) & locals[816] & locals[765] ^ locals[774];
        locals[779] = (locals[765] ^ locals[761] ^ ~locals[816]) & locals[769] ^
                      locals[765] & (~locals[797] ^ locals[816]);
        locals[813] = (locals[797] ^ locals[761]) & locals[816];
        locals[760] = ((locals[797] ^ locals[816] ^ locals[761]) & locals[769] ^ locals[797] ^ locals[813]) &
                      locals[765] ^
                      (locals[779] ^ ~locals[761] & locals[816]) & locals[774] ^
                      locals[761] & (locals[769] ^ locals[816]) ^ locals[769];
        locals[788] = locals[816] << 0x10;
        locals[636] = locals[636] ^ locals[781] << 0xf;
        locals[781] = (~locals[636] ^ locals[812]) & locals[794] ^ locals[816] << 0x10 ^ locals[812];
        locals[779] = (~((locals[761] ^ ~locals[797] ^ locals[816]) & locals[769]) ^ locals[813]) & locals[765] ^
                      (locals[816] & locals[761] ^ locals[779]) & locals[774] ^ locals[816];
        locals[813] = ~(((locals[788] ^ locals[812]) & locals[794] ^ locals[816] << 0x10 ^ locals[812]) & locals[636]) ^
                      (~locals[812] & locals[794] ^ locals[816] << 0x10 ^ locals[812]) & locals[788];
        locals[792] =
            ~((locals[811] & (locals[792] ^ locals[720]) ^ locals[792] ^ locals[720]) & locals[773]) & locals[772] ^
            locals[792];
        locals[788] = locals[788] ^ locals[636];
        locals[816] = (locals[787] ^ locals[793]) & locals[462];
        locals[720] = (locals[792] & locals[768] ^ locals[816] ^ locals[787]) & locals[331] ^
                      (~locals[816] ^ locals[768] ^ locals[787]) & locals[792] ^ locals[768];
        locals[462] = (~locals[331] ^ locals[768]) & locals[462];
        locals[812] = ~((~locals[462] ^ locals[331] ^ locals[768]) & locals[787]) ^ locals[462] & locals[793] ^
                      locals[792] ^ locals[331];
        locals[816] = (~locals[720] ^ locals[812]) &
                      (~((~locals[792] & locals[331] ^ locals[792] ^ locals[816] ^ locals[787]) & locals[768]) ^
                       (locals[816] ^ locals[787]) & locals[792] ^ locals[331]);
        locals[811] = (locals[720] & 0xffff ^ 0xffff0000) & locals[812] ^ locals[720] ^ locals[816];
        locals[462] = (locals[720] ^ locals[812]) & 0xffff0000;
        locals[816] = ~locals[812] & locals[720] ^ locals[816] & 0xffff ^ 0xffff0000;
        locals[331] = ~(((locals[301] ^ locals[776]) & (~locals[816] ^ locals[811]) ^ locals[816] ^ locals[811]) &
                        locals[462]) ^
                      (~locals[301] ^ locals[776]) & locals[816] ^ locals[301];
        locals[636] = (locals[816] ^ locals[811]) >> 0x10;
        locals[793] = ~(((~locals[816] ^ locals[811] ^ locals[782]) & locals[301] ^ locals[811]) & locals[462]) ^
                      ~((locals[462] ^ locals[301]) & locals[782]) & locals[776] ^
                      (locals[816] ^ locals[782]) & locals[301];
        locals[772] = ~(~(locals[816] >> 0x10) & locals[811] >> 0x10);
        locals[462] = ((~locals[462] ^ locals[301]) & locals[782] ^ locals[462] ^ locals[301]) & locals[776] ^
                      (~((locals[816] ^ locals[811] ^ locals[782]) & locals[301]) ^ locals[816]) & locals[462] ^
                      locals[816] & ~locals[301];
        locals[812] = (locals[720] ^ locals[812]) >> 0x10 & ~locals[636] ^ ~(locals[811] >> 0x10) & locals[816] >> 0x10;
        locals[811] = (~(locals[636] & (~locals[812] ^ locals[772])) ^ locals[749] & locals[796] ^ locals[812]) &
                      locals[802] ^
                      ((~locals[812] ^ locals[772]) & locals[796] ^ locals[812] ^ locals[772]) & locals[636] ^
                      ~locals[796] & locals[812];
        locals[816] = ~locals[331];
        locals[787] = ((locals[788] ^ locals[813] ^ locals[781] ^ locals[816]) & locals[793] ^
                       (locals[788] ^ locals[813] ^ locals[781]) & locals[331]) & locals[462] ^
                      ((locals[813] ^ locals[781]) & locals[331] ^ locals[793] ^ locals[813] ^ locals[781]) &
                      locals[788] ^
                      (locals[813] ^ locals[781] ^ locals[816]) & locals[793] ^ locals[331] ^ locals[813];
        locals[301] = (~((locals[812] ^ locals[772] ^ locals[749] ^ locals[796]) & locals[636]) ^ locals[812] ^
                       locals[749] ^ locals[796]) &
            locals[802] ^ locals[772] & locals[636] ^ locals[796];
        locals[720] = (locals[793] ^ locals[331]) & locals[462];
        locals[797] = ~((locals[813] & locals[781] ^ locals[720] ^ locals[793] ^ locals[331]) & locals[788]) ^
                      (locals[720] ^ locals[793] ^ locals[331] ^ locals[813]) & locals[781] ^ locals[331] ^ locals[813];
        locals[812] = (~((locals[812] ^ locals[772] ^ locals[802]) & locals[796]) ^ locals[772]) & locals[636] ^
                      ~((locals[636] ^ locals[796]) & locals[749]) & locals[802] ^
                      (locals[812] ^ locals[802]) & locals[796];
        locals[781] = (~locals[793] & locals[462] ^ locals[788] & locals[781] ^ locals[793]) & locals[331] ^
                      ((locals[781] ^ locals[816]) & locals[788] ^ locals[720] ^ locals[793]) & locals[813] ^
                      locals[788] ^ locals[781];
        locals[816] = ~locals[812] ^ locals[779] ^ locals[709];
        locals[720] = (~locals[812] ^ locals[301]) & locals[811];
        locals[796] = (~(locals[816] & locals[301]) ^ locals[720] ^ locals[709]) & locals[760] ^
                      (~locals[811] & locals[812] ^ locals[779]) & locals[301] ^ locals[779] ^ locals[709];
        locals[802] = (~locals[787] & locals[781] & 0x300030 ^ 0x30003) & locals[797] ^ locals[787] & 0x300030;
        locals[793] = ~(locals[781] & 0x3000300) ^ locals[797] & 0x3000300;
        locals[772] = locals[781] & locals[797] & 0x3000300;
        locals[636] = (locals[797] ^ 0xc000c0) & locals[781];
        locals[331] = ~((locals[636] ^ 0xff3fff3f) & locals[787] & 0xc0c0c0c0) ^ locals[636] & 0xc0c0c0c0;
        locals[761] = ~((~((~locals[301] ^ locals[779] ^ locals[760] ^ locals[709]) & locals[812]) ^
                         (locals[709] ^ ~locals[779] ^ locals[760]) & locals[301] ^ locals[779] ^ locals[760] ^
                         locals[709]) & locals[811]) ^
                      ((locals[779] ^ locals[709]) & locals[812] ^ locals[816] & locals[760] ^ locals[709]) &
                      locals[301] ^
                      locals[709] & (~locals[779] ^ locals[760]) ^ locals[779];
        locals[749] = ((locals[781] & 0xc000c ^ locals[787] ^ 0xfff3fff3) & locals[797] ^
                       (locals[787] ^ 0xfff3fff3) & locals[781]
            ) & 0x30c030c;
        locals[816] = locals[797] & ~locals[781];
        locals[776] = (locals[816] & 0xc000c0 ^ 0xc000c000) & locals[787] ^ locals[781] & 0xc000c0;
        locals[813] = (locals[781] & 0xff3fff3f ^ locals[816]) & locals[787] & 0xc0c0c0c0;
        locals[782] = ~(~(locals[749] >> 6) & locals[772] >> 6);
        locals[462] = (locals[749] ^ locals[772]) >> 6;
        locals[811] = locals[813] << 4;
        locals[816] = ~((locals[776] & locals[331]) << 4) & locals[811];
        locals[773] = locals[776] << 4 ^ locals[816];
        locals[794] = locals[793] >> 6 & ~locals[462];
        locals[774] = locals[794] ^ 0xfc000000;
        locals[760] = (~locals[720] ^ locals[779] ^ locals[812] & locals[301]) & locals[709] ^
                      (locals[720] ^ locals[812] & locals[301]) & locals[779] ^ locals[301] ^ locals[760];
        locals[720] = ~locals[796];
        locals[636] = (locals[760] ^ locals[761]) & locals[720] ^ locals[796];
        locals[765] = locals[636] & 0xc000c000;
        locals[301] = (locals[776] ^ locals[331]) >> 4;
        locals[779] = ~((locals[776] & locals[331]) >> 4);
        locals[768] = ((locals[813] & (locals[776] ^ locals[331])) >> 4 ^ locals[779]) & 0xfffffff;
        locals[813] = ~locals[760];
        locals[812] = locals[796] & locals[813];
        locals[769] = ((locals[813] & 0x30003 ^ locals[796]) & locals[761] ^ locals[812]) & 0x330033;
        locals[709] = ~((locals[796] & 0x30003000 ^ locals[813]) & locals[761] & 0xf000f000) ^ locals[812] & 0x30003000;
        locals[788] = ((locals[781] ^ 0xf3fff3ff) & locals[787] ^ locals[781] & 0xc000c00) & locals[797] & 0x3c003c00;
        locals[792] = ((locals[781] ^ 0xfffcfffc) & locals[787] & ~locals[797] ^ locals[797] & 0x30003) & 0x330033;
        locals[375] = ~((locals[749] & locals[772]) << 8) & locals[793] << 8 ^ locals[772] << 8;
        locals[814] = ((locals[797] ^ 0xc000c00) & locals[787] & ~locals[781] ^ locals[781] & 0xf3fff3ff) & 0x3c003c00;
        locals[699] = ((locals[781] ^ 0x30003) & locals[787] ^ locals[781]) & locals[797] & 0x330033;
        locals[331] = locals[331] << 4;
        locals[776] = ~(~(locals[776] << 4) & locals[331]) & locals[811] ^ locals[331];
        locals[790] = ~((locals[699] ^ locals[792]) << 2) & locals[802] << 2 ^ locals[699] << 2 & ~(locals[792] << 2);
        locals[331] = locals[331] ^ locals[816];
        locals[753] = ~(locals[760] & locals[720] & 0x300030) ^ (locals[796] ^ locals[761] & locals[720]) & 0x300030;
        locals[777] = ~((locals[796] & ~locals[761] & 0xc000c0 ^ 0xc000c00) & locals[760]);
        locals[816] = locals[781] & ~locals[797] & 0x30003000;
        locals[816] = (locals[816] ^ 0xc000c00) & locals[787] ^ locals[816];
        locals[787] = ((locals[796] & 0xfff3fff3 ^ locals[813]) & locals[761] ^ locals[812] & 0xfff3fff3) & 0x30c030c;
        locals[779] = locals[779] & 0xfffffff;
        locals[797] = ~(~(locals[802] << 2) & locals[792] << 2);
        locals[781] = (locals[793] & (locals[749] ^ locals[772]) ^ locals[772]) << 8;
        locals[811] = ~locals[761] & locals[760];
        locals[778] = ~(locals[811] & 0x300030);
        locals[799] = locals[811] & 0xc000c000;
        locals[795] = ~((locals[788] & locals[814] & locals[816]) >> 10);
        locals[751] = ~((locals[778] ^ locals[769]) << 6) & locals[753] << 6 ^ locals[778] << 6;
        locals[749] = (locals[802] ^ locals[792]) << 2;
        locals[735] = ~(locals[802] >> 2) & locals[792] >> 2 ^ ~(locals[699] >> 2) & locals[802] >> 2;
        locals[760] = ((locals[796] & 0xc000c00 ^ 0xc000c0) & locals[760] ^ locals[720] & 0xc000c0) & locals[761] ^
                      locals[812] & 0xc000c0;
        locals[802] = locals[709] >> 6;
        locals[784] = (~(locals[799] >> 6) & locals[802] ^ ~(locals[765] >> 6)) & 0x3ffffff;
        locals[812] = (locals[793] ^ locals[772]) << 8;
        locals[761] = (locals[796] & 0xff3fff3f ^ locals[761] & locals[720]) & locals[813] & 0xcc00cc0;
        locals[805] = (locals[816] ^ locals[814]) >> 10;
        locals[676] = ~(locals[765] >> 6) & locals[799] >> 6 ^ locals[802] ^ 0xfc000000;
        locals[772] = ~(locals[778] << 6) & locals[753] << 6 ^ locals[769] << 6;
        locals[807] = ~(((locals[814] ^ locals[788]) & locals[816]) >> 10) ^ locals[814] >> 10;
        locals[813] = ~(locals[699] >> 2) & locals[792] >> 2;
        locals[808] = ~locals[813];
        locals[721] = (locals[699] ^ locals[792]) >> 2;
        locals[792] = (locals[761] ^ locals[760]) << 4;
        locals[699] = ((locals[753] ^ locals[769]) & locals[778]) << 2;
        locals[802] = ~((locals[765] & locals[799]) >> 6) ^ locals[802];
        locals[732] = (locals[778] & locals[753] ^ locals[769]) << 6;
        locals[707] =
            ((~locals[802] ^ locals[807] ^ locals[795]) & locals[805] ^ locals[802] ^ locals[807] ^ locals[795]) &
            locals[676] ^
            ~((locals[805] ^ locals[676]) & locals[784]) & locals[802] ^ locals[807] ^ locals[805];
        locals[796] = locals[760] << 4;
        locals[793] = locals[761] << 4;
        locals[648] = (~locals[796] & locals[793] ^ locals[796]) & locals[777] << 4 ^ locals[796];
        locals[720] = (locals[732] ^ locals[749] ^ locals[797]) & locals[790];
        locals[708] = ~((~locals[772] ^ locals[790]) & locals[751]) & locals[732] ^
                      (~locals[720] ^ locals[732] ^ locals[749] ^ locals[797]) & locals[772] ^ locals[720] ^
                      locals[797];
        locals[403] = (locals[778] ^ locals[769]) << 2;
        locals[769] = ~(locals[769] << 2) & (locals[778] & locals[753]) << 2;
        locals[813] = locals[813] ^ locals[735];
        locals[720] = ~locals[721] & locals[808];
        locals[753] = ~((~(locals[813] & locals[403]) ^ locals[813] & locals[769]) & locals[699]) ^
                      (~locals[720] ^ locals[721]) & locals[735]
                      ^ locals[720] ^ locals[403] ^ locals[721];
        locals[813] = ~((locals[751] ^ ~locals[772]) & locals[732]);
        locals[778] = (~locals[790] & locals[797] ^ locals[813] ^ locals[790]) & locals[749] ^
                      locals[813] & locals[790] ^ locals[772];
        locals[793] = ~(~locals[793] & locals[796]) & locals[777] << 4 ^ locals[793];
        locals[813] = ~locals[805];
        locals[580] = ~((~((locals[807] ^ locals[805] ^ locals[784]) & locals[676]) ^
                         (locals[813] ^ locals[784]) & locals[807] ^
                         (locals[784] ^ locals[795]) & locals[805] ^ locals[795]) & locals[802]) ^
                      ((~locals[807] ^ locals[795]) & locals[805] ^ locals[795]) & locals[676] ^
                      (~(locals[813] & locals[807]) ^ locals[805]) & locals[795] ^ locals[807];
        locals[811] = (locals[811] & 0xc000c) << 0xc;
        locals[796] = (locals[636] & 0xc000c) << 0xc;
        locals[810] = locals[796] ^ ~locals[811];
        locals[749] = locals[749] ^
                      ((~locals[732] ^ locals[749] ^ locals[797]) & locals[790] ^ locals[797]) & locals[772] ^
                      (locals[772] ^ locals[790]) & locals[732] & locals[751] ^
                      (locals[732] ^ locals[749]) & locals[790];
        locals[797] = (~((~locals[709] ^ locals[765] ^ locals[768]) & locals[301]) ^ locals[765] ^ locals[768]) &
                      locals[799] ^
                      ((~locals[301] ^ locals[799]) & locals[768] ^ locals[301] ^ locals[799]) & locals[779] ^
                      (locals[765] ^ locals[768]) & locals[301] ^ locals[765] ^ locals[768];
        locals[772] = locals[787] << 0xc;
        locals[790] = ~(~locals[772] & locals[796]) ^ locals[811];
        locals[751] = (~((locals[769] ^ locals[721] ^ locals[808]) & locals[735]) ^
                       (~locals[769] ^ locals[808] ^ locals[735]) & locals[403] ^
                       locals[769] & locals[808] ^ locals[721]) & locals[699] ^
                      ((locals[721] ^ locals[808]) & locals[403] ^ locals[720] ^ locals[721]) & locals[735] ^
                      (~locals[403] ^ locals[808]) & locals[721] ^ locals[403];
        locals[720] = (~locals[721] ^ locals[808]) & locals[735];
        locals[721] = (~locals[769] & locals[699] ^ locals[720] ^ locals[721] ^ locals[808]) & locals[403] ^
                      (locals[720] ^ locals[721] ^ locals[808]) & locals[699] ^
                      (locals[721] ^ locals[808]) & locals[735] ^ locals[721];
        locals[769] = ~(((locals[761] ^ locals[760]) & locals[777]) << 8) ^ locals[761] << 8;
        locals[676] =
            (~((locals[813] ^ locals[676] ^ locals[784]) & locals[807]) ^ locals[805] ^ locals[676] ^ locals[784]) &
            locals[802] ^
            ((locals[802] ^ locals[807]) & locals[805] ^ locals[802] ^ locals[807]) & locals[795] ^ locals[805] ^
            locals[676];
        locals[720] = (locals[709] ^ locals[765]) & locals[301];
        locals[802] = (~((locals[709] ^ locals[765]) & locals[779]) ^ locals[720]) & locals[799] ^
                      (locals[301] ^ locals[779]) & locals[765] ^
                      locals[779];
        locals[636] = ~locals[648];
        locals[813] = (~locals[816] ^ locals[814]) & locals[788];
        locals[699] = ~((~((locals[636] ^ locals[814]) & locals[816]) ^ (locals[636] ^ locals[816]) & locals[792] ^
                         locals[813] ^ locals[814])
                        & locals[793]) ^ (locals[814] & locals[788] ^ ~locals[792] & locals[648]) & locals[816] ^
                      locals[648] ^ locals[814];
        locals[779] = ((~locals[301] ^ locals[779]) & locals[768] ^ locals[720] ^ locals[709]) & locals[799] ^
                      (~(locals[779] & locals[768]) ^ locals[765]) & locals[301] ^ locals[779];
        locals[301] = ~(((locals[792] ^ locals[814] ^ locals[788]) & locals[648] ^
                         (locals[636] ^ locals[792] ^ locals[814] ^ locals[788]) & locals[793] ^ locals[814] ^
                         locals[788]) & locals[816]) ^
                      (~((locals[636] ^ locals[792] ^ locals[788]) & locals[793]) ^
                       (locals[792] ^ locals[788]) & locals[648] ^ locals[788]) &
                      locals[814] ^ (~locals[793] ^ locals[648]) & locals[788] ^ locals[648];
        locals[720] = ~locals[779] ^ locals[676];
        locals[636] = ~locals[676];
        locals[765] = (~(locals[720] & locals[707]) ^ locals[636] & locals[779] ^ locals[676]) & locals[580] ^
                      (~((~locals[797] ^ locals[707]) & locals[676]) ^ locals[797] ^ locals[707]) & locals[779] ^
                      ~(locals[720] & locals[797]) & locals[802] ^ (locals[797] ^ locals[707]) & locals[676] ^
                      locals[797] ^ locals[707];
        locals[816] =
            ((locals[793] ^ locals[816]) & locals[814] ^ (~locals[793] ^ locals[814]) & locals[792] ^ locals[813]) &
            locals[648] ^
            (~locals[788] & locals[816] ^ ~locals[792] & locals[793]) & locals[814] ^ locals[793] ^ locals[816];
        locals[813] = (locals[761] ^ locals[777]) << 8;
        locals[811] = ~(locals[796] & ~locals[811]) & locals[772] ^ locals[811];
        locals[796] = ((~locals[810] ^ locals[781]) & locals[790] ^ (locals[781] ^ locals[375]) & locals[812]) &
                      locals[811] ^
                      (~(~locals[375] & locals[812]) ^ locals[790] & locals[810]) & locals[781] ^ locals[375];
        locals[720] = (locals[636] ^ locals[707]) & locals[580];
        locals[636] = locals[636] & locals[707];
        locals[793] = (~(~locals[779] & locals[797]) ^ locals[580] & locals[707] ^ locals[779]) & locals[676] ^
                      ((locals[779] ^ locals[676]) & locals[797] ^ locals[636] ^ locals[720] ^ locals[779]) &
                      locals[802] ^ locals[779];
        locals[676] = (~locals[720] ^ locals[636] ^ locals[676]) & locals[802] ^
                      (locals[636] ^ locals[720] ^ locals[676]) & locals[779] ^
                      locals[676];
        locals[812] = (locals[811] ^ locals[810]) & locals[790] ^ locals[811] ^ locals[812];
        locals[779] = (locals[812] ^ locals[375]) & locals[781] ^ locals[812] & locals[375] ^ locals[811];
        locals[802] =
            ((locals[765] ^ 0xbbbbbbbb) & locals[793] ^ ~locals[765] & 0xbbbbbbbb) & locals[676] & 0xcccccccc ^
            0x77777777;
        locals[375] = ~((~locals[781] ^ locals[375]) & (locals[811] ^ locals[810]) & locals[790]) ^ locals[811] ^
                      locals[375];
        locals[812] = (locals[761] & locals[760] & locals[777]) << 8;
        locals[772] = ~((~locals[676] & locals[765] & 0x88888888 ^ 0x44444444) & locals[793]) ^
                      locals[765] & 0x88888888;
        locals[793] = (~(~locals[793] & ~locals[765] & locals[676]) & 0x44444444 ^
                       ~(locals[793] & 0x44444444) & locals[765]) &
                      0xcccccccc;
        locals[797] = ~(((locals[812] ^ locals[769] ^ locals[776] ^ locals[773]) & locals[331] ^ locals[812] ^
                         locals[769] ^ locals[776]) &
                        locals[813]) ^ (~locals[812] ^ locals[769] ^ locals[776]) & locals[331] ^ locals[812] ^
                      locals[776];
        locals[761] = ((~locals[813] ^ locals[776] ^ locals[773]) & locals[769] ^ locals[773]) & locals[331] ^
                      ((locals[769] ^ locals[331]) & locals[813] ^ locals[769] ^ locals[331]) & locals[812] ^
                      (locals[813] ^ locals[776]) & locals[769] ^ locals[813];
        locals[781] = ((locals[375] ^ locals[796] ^ locals[778] ^ locals[708]) & locals[779] ^ locals[375] ^
                       locals[778] ^ locals[708]) &
            locals[749] ^ (~locals[375] ^ locals[778] ^ locals[708]) & locals[779] ^ locals[375] ^ locals[708];
        locals[787] = locals[787] >> 2 ^ 0xffffffff;
        locals[765] = ~((locals[793] ^ locals[772]) >> 1) & 0x7fffffff;
        locals[720] = (~locals[375] ^ locals[796]) & locals[779];
        locals[768] = ~((~locals[720] ^ ~locals[749] & locals[708] ^ locals[375]) & locals[778]) ^
                      (locals[720] ^ locals[375]) & locals[749] ^
                      locals[779];
        locals[636] = (~locals[776] ^ locals[773]) & locals[331];
        locals[331] = (locals[812] & locals[769] ^ locals[636] ^ locals[776]) & locals[813] ^
                      (~locals[636] ^ locals[812] ^ locals[776]) & locals[769] ^ locals[331];
        locals[776] = ((locals[331] ^ locals[753]) & locals[797] ^ (locals[331] ^ locals[721]) & locals[753] ^
                       (locals[721] ^ locals[753]) & locals[751] ^ locals[331] ^ locals[721]) & locals[761] ^
                      (~locals[721] & locals[751] ^ ~locals[331] & locals[797]) & locals[753] ^ locals[331] ^
                      locals[751];
        locals[749] = ((~locals[779] ^ locals[708]) & locals[749] ^ locals[720] ^ locals[375] ^ locals[708]) &
                      locals[778] ^
                      (~locals[749] & locals[708] ^ locals[796]) & locals[779] ^ locals[749];
        locals[812] = locals[802] >> 1;
        locals[811] = locals[772] >> 1;
        locals[720] = locals[793] >> 1 & ~locals[812];
        locals[796] = ~locals[720] & locals[811] ^ locals[812];
        locals[788] = (((locals[768] ^ 0xbbbbbbbb) & locals[749] ^ locals[768]) & locals[781] ^ 0x44444444) &
                      0xcccccccc;
        locals[773] = (~locals[768] & locals[781] ^ locals[768]) & locals[749] & 0x44444444 ^ locals[781] & 0x88888888;
        locals[794] =
            ((locals[794] ^ 0x3ffffff ^ locals[782]) & locals[462] ^ locals[774] & locals[782]) & locals[787] ^
            (~locals[774] & locals[782] ^ locals[774]) & locals[462];
        locals[749] = ~(((locals[781] ^ 0xbbbbbbbb) & locals[768] ^ 0x44444444) & locals[749]) & 0xcccccccc ^
                      (locals[768] & 0x44444444 ^ 0x88888888) & locals[781];
        locals[792] = (locals[787] & (~locals[774] ^ locals[782]) ^ locals[774] ^ locals[782]) & locals[462] ^
                      ~locals[787] & locals[774] & locals[782] ^ locals[787];
        locals[636] = locals[331] ^ locals[797] ^ locals[721];
        locals[779] = locals[636] & locals[753];
        locals[813] = locals[797] ^ locals[721] ^ locals[753];
        locals[781] = (locals[813] & locals[751] ^ (locals[797] ^ locals[721]) & locals[753] ^ locals[721]) &
                      locals[331] ^
                      (~((locals[636] ^ locals[753]) & locals[751]) ^ locals[779] ^ locals[721]) & locals[761] ^
                      (locals[751] ^ locals[753]) & locals[797] ^ locals[753];
        locals[636] = (~(locals[811] & locals[720]) ^ ~locals[811] & locals[812]) & 0x7fffffff;
        locals[720] = (locals[793] ^ locals[802]) & locals[772];
        locals[709] = ~((locals[720] ^ locals[636] ^ locals[765] ^ locals[802]) & locals[796]) ^
                      (~locals[720] ^ locals[636] ^ locals[802]) & locals[765] ^ locals[793] ^ locals[802];
        locals[768] = (locals[749] ^ locals[773]) >> 1;
        locals[720] = (locals[796] ^ locals[765]) & locals[636];
        locals[769] = ~((~locals[720] ^ locals[765] ^ locals[772] ^ locals[802]) & locals[793]) ^
                      (locals[720] ^ locals[765] ^ locals[772]) & locals[802] ^ locals[796] ^ locals[765];
        locals[462] = ~(((locals[774] ^ locals[782]) & locals[462] ^ locals[774] & locals[782]) & locals[787]) ^
                      locals[774] & locals[782] & ~locals[462] ^ locals[462];
        locals[802] =
            (~((locals[636] ^ locals[772]) & locals[765]) ^ (~locals[636] ^ locals[772]) & locals[796] ^ locals[802]) &
            locals[793]
            ^ ((locals[636] ^ locals[772]) & locals[802] ^ locals[765]) & locals[796] ^
            ~((~locals[636] ^ locals[772]) & locals[765]) & locals[802];
        locals[796] = ~(~(locals[773] >> 1) & locals[749] >> 1) & locals[788] >> 1 ^ locals[749] >> 1;
        locals[720] = ~locals[122];
        locals[636] = locals[720] ^ locals[601];
        locals[793] = (~(locals[636] & locals[802]) ^ locals[636] & locals[709] ^ locals[122] ^ locals[601]) &
                      locals[668] ^
                      ~((~locals[802] ^ locals[709]) & locals[122]) & locals[601] ^ locals[709];
        locals[772] = ~((locals[749] & locals[773]) >> 1) & locals[788] >> 1 ^ locals[773] >> 1;
        locals[812] = (locals[772] ^ locals[796] ^ locals[749] ^ locals[773]) & locals[768];
        locals[787] = (~((locals[772] ^ locals[796] ^ locals[773]) & locals[768]) ^
                       (locals[796] ^ locals[773]) & locals[772] ^ locals[796]) &
                      locals[749] ^
                      ~(((locals[796] ^ locals[749] ^ locals[773]) & locals[772] ^ locals[812] ^ locals[796]) &
                        locals[788]) ^
                      (locals[772] ^ locals[768]) & locals[773] ^ locals[772];
        locals[811] = (~locals[797] ^ locals[721]) & locals[331];
        locals[811] = ~(((~locals[331] ^ locals[797] ^ locals[721] ^ locals[753]) & locals[751] ^ locals[779] ^
                         locals[797] ^ locals[721]) &
                        locals[761]) ^ (~(locals[813] & locals[331]) ^ locals[797] ^ locals[721]) & locals[751] ^
                      (locals[797] ^ locals[721] ^ locals[811]) & locals[753] ^ locals[797] ^ locals[721] ^ locals[811];
        locals[779] = ~locals[749];
        locals[812] = ~((locals[796] & ~locals[772] ^ locals[773] & locals[779] ^ ~locals[812]) & locals[788]) ^
                      (~(locals[768] & ~locals[772]) ^ locals[772]) & locals[796] ^
                      (~(locals[768] & locals[779]) ^ locals[749]) & locals[773]
                      ^ locals[772] ^ locals[768] ^ locals[749];
        locals[331] = ((locals[792] ^ locals[816]) & locals[699] ^ locals[794] & (locals[462] ^ locals[792]) ^
                       locals[792] & locals[816]) &
                      locals[301] ^ (~locals[462] & locals[794] ^ ~(~locals[816] & locals[699]) ^ locals[816]) &
                      locals[792] ^
                      locals[794];
        locals[797] = ~((~((locals[720] ^ locals[802]) & locals[709]) ^ (locals[802] ^ locals[709]) & locals[769] ^
                         (locals[122] ^ locals[709]) & locals[668] ^ locals[122]) & locals[601]) ^
                      (~(locals[720] & locals[668]) ^ ~locals[802] & locals[769] ^ locals[802]) & locals[709] ^
                      locals[802];
        locals[761] = ~((~(locals[781] & 0xbbbbbbbb) & locals[776] ^ ~locals[781] & 0xbbbbbbbb) & locals[811] &
                        0xcccccccc) ^
                      locals[781] & 0x88888888;
        locals[782] = ~(locals[811] & ~locals[781] & 0x44444444) ^ locals[781] & 0xcccccccc;
        locals[813] = locals[794] ^ ~locals[792];
        locals[774] = ((locals[816] ^ locals[699]) & locals[813] ^ locals[792] ^ locals[794]) & locals[301] ^
                      (~(locals[816] & locals[813]) ^ locals[792] ^ locals[794]) & locals[699] ^
                      (locals[462] & locals[792] ^ locals[816]) & locals[794] ^ locals[816] & ~locals[792] ^
                      locals[792];
        locals[811] = (locals[781] & locals[776] & 0x88888888 ^ 0x44444444) & locals[811];
        locals[709] = ((~locals[709] ^ locals[601]) & locals[769] ^ (locals[720] ^ locals[709]) & locals[601] ^
                       locals[636] & locals[668] ^
                       locals[709]) & locals[802] ^
                      (~locals[668] & locals[122] ^ locals[769] & locals[709]) & locals[601] ^ locals[709];
        locals[813] = locals[811] >> 1;
        locals[636] = locals[782] >> 1;
        locals[802] = locals[636] ^ ~locals[813];
        locals[781] = ~(locals[761] >> 1 & ~locals[636]) ^ locals[636] & ~locals[813] ^ locals[813];
        locals[788] = ((locals[773] ^ locals[779]) & locals[788] ^ (locals[796] ^ locals[773]) & locals[749] ^
                       (locals[796] ^ locals[749]) & locals[768] ^ locals[773]) & locals[772] ^
                      (~locals[796] & locals[768] ^ locals[788] & locals[773] ^ locals[796]) & locals[749] ^
                      locals[768] ^ locals[788];
        locals[720] = locals[653] ^ locals[812];
        locals[813] = locals[761] >> 1 & ~locals[636] & locals[813];
        locals[792] =
            ~((~((locals[816] ^ locals[462] ^ locals[792]) & locals[794]) ^ (locals[794] ^ locals[816]) & locals[699]) &
              locals[301]
                ) ^ (locals[462] ^ locals[792] ^ locals[816] ^ ~locals[816] & locals[699]) & locals[794] ^ locals[792];
        locals[749] = ~(locals[774] & 0x88888888) ^ locals[331] & 0x88888888;
        locals[816] = ~locals[812];
        locals[636] = locals[800] ^ locals[787] ^ locals[816];
        locals[779] = locals[812] ^ locals[800];
        locals[772] = (~((locals[704] ^ locals[636]) & locals[788]) ^ (locals[704] ^ locals[779]) & locals[787] ^
                       locals[800] ^ locals[704]) &
                      locals[666] ^
                      (locals[787] & locals[779] ^ locals[788] & locals[636] ^ locals[800]) & locals[704] ^
                      (~locals[788] ^ locals[787]) & locals[800] ^ locals[788];
        locals[776] = (~((locals[704] ^ locals[787] ^ locals[816]) & locals[788]) ^
                       (locals[788] ^ locals[704]) & locals[800] ^
                       locals[787] & locals[816]) & locals[666] ^
                      (~locals[704] & locals[800] ^ ~locals[787] & locals[812] ^ locals[704]) & locals[788] ^
                      locals[787] ^ locals[704];
        locals[462] = ((locals[331] & 0x44444444 ^ locals[792] ^ 0xbbbbbbbb) & locals[774] ^
                       (locals[792] ^ 0xbbbbbbbb) & locals[331]) & 0xcccccccc;
        locals[666] = (~((locals[812] ^ locals[704]) & locals[788]) ^ (locals[800] ^ locals[704]) & locals[666] ^
                       locals[704] & locals[779] ^
                       locals[812] ^ locals[800]) & locals[787] ^
                      (~(~locals[800] & locals[666]) ^ locals[788] & locals[816]) & locals[704] ^
                      locals[788] ^ locals[666];
        locals[796] = ~((locals[812] & ~locals[653] ^ locals[787] & locals[720]) & locals[788]) ^
                      (~((locals[766] ^ locals[787]) & locals[653]) ^ locals[766] ^ locals[787]) & locals[812] ^
                      (locals[766] & locals[720] ^ locals[653] ^ locals[812]) & locals[92] ^ locals[653];
        locals[816] = locals[802] ^ ~locals[813];
        locals[800] = ~((~((locals[761] ^ locals[782] ^ locals[816]) & locals[811]) ^ locals[802] ^ locals[761]) &
                        locals[781]) ^
                      (locals[813] ^ locals[782]) & locals[811] ^ locals[813] ^ locals[802];
        locals[636] = locals[781] ^ ~locals[813];
        locals[773] =
            ((locals[813] ^ locals[781] ^ locals[802]) & locals[782] ^ locals[781] & locals[816] ^ locals[802]) &
            locals[811] ^
            (~((locals[802] ^ locals[636]) & locals[811]) ^ locals[813] ^ locals[781] ^ locals[802]) & locals[761] ^
            locals[802] & locals[636] ^ locals[813];
        locals[92] = ~((locals[812] ^ locals[787]) & locals[788]) ^ (locals[92] ^ ~locals[653]) & locals[766] ^
                     locals[812] & locals[787] ^
                     locals[92];
        locals[816] = (locals[761] ^ locals[782]) & locals[811];
        locals[811] = ~((~locals[816] ^ locals[813] ^ locals[761]) & locals[802]) ^
                      (locals[761] ^ locals[816]) & locals[813] ^ locals[781] ^
                      locals[811];
        locals[781] = locals[774] & locals[331] & 0x88888888;
        locals[816] = locals[796] & 0xaaaaaaaa;
        locals[331] = ((locals[816] ^ 0x55555555) & locals[92] ^ locals[796] ^ 0x55555555) & locals[720] ^
                      ~locals[816] & locals[92] ^
                      0xaaaaaaaa;
        locals[301] = (~((locals[811] ^ locals[120] ^ locals[18]) & locals[773]) ^
                       (~locals[811] ^ locals[773]) & locals[800] ^ locals[811] ^
                       locals[120]) & locals[480] ^ (locals[811] & locals[800] ^ locals[18]) & locals[773] ^
                      locals[811];
        locals[816] =
            ~(((locals[796] ^ 0xaaaaaaaa) & locals[720] ^ locals[796] & 0x55555555 ^ 0xaaaaaaaa) & locals[92]) ^
            locals[816];
        locals[636] = (~locals[120] ^ locals[18]) & locals[480];
        locals[802] = (~locals[636] ^ locals[18]) & locals[773] ^ (locals[636] ^ locals[18]) & locals[811] ^
                      locals[480];
        locals[636] = ~locals[92];
        locals[787] = ~(~(locals[796] & locals[636]) & locals[720] & 0xaaaaaaaa) ^ locals[796];
        locals[779] = ~locals[773];
        locals[773] = (~((locals[779] ^ locals[480]) & locals[811]) ^ locals[779] & locals[480] ^ locals[773]) &
                      locals[800] ^
                      (~((locals[120] ^ locals[779] ^ locals[18]) & locals[480]) ^ locals[18]) & locals[811] ^
                      ~locals[480] & locals[18] ^
                      locals[773];
        locals[811] = (locals[781] ^ locals[462]) & locals[749] ^ locals[781];
        locals[800] = locals[811] >> 1;
        locals[812] = locals[462] & locals[781];
        locals[704] = locals[812] >> 1;
        locals[761] = ~(locals[462] >> 1) & locals[781] >> 1 ^ locals[462] >> 1;
        locals[779] = (locals[811] ^ locals[812]) >> 1;
        locals[813] = (locals[781] ^ locals[749]) & locals[779];
        locals[812] = ((locals[811] & locals[812]) >> 1 ^ locals[462]) & (~locals[781] ^ locals[749]) ^
                      ((locals[811] ^ locals[812]) >> 1 ^ locals[813]) & locals[761] ^ locals[800] ^ locals[781];
        locals[779] = ((locals[704] ^ locals[462]) & locals[800] ^ (locals[800] ^ locals[462]) & locals[781] ^
                       ~(locals[761] & locals[779])) &
                      locals[749] ^
                      (~locals[704] & locals[761] ^ ~locals[462] & locals[781] ^ locals[704] ^ locals[462]) &
                      locals[800] ^
                      locals[781];
        locals[781] = (~(locals[704] & (locals[781] ^ locals[749])) ^ locals[781] ^ locals[749]) & locals[800] ^
                      locals[761] & locals[813] ^
                      locals[781];
        locals[704] = (~(locals[779] & (~locals[523] ^ locals[127])) ^ locals[781] & (~locals[523] ^ locals[127]) ^
                       locals[523] ^ locals[127])
                      & locals[812] ^ (~(locals[352] & locals[127]) ^ locals[779] ^ locals[781]) & locals[523] ^
                      (locals[779] ^ locals[781]) & locals[127] ^ locals[779];
        locals[761] =
            ((locals[779] ^ locals[523]) & locals[812] ^ (locals[523] ^ locals[352]) & locals[127] ^ locals[779]) &
            locals[781] ^
            (~(~locals[779] & locals[812]) ^ ~locals[352] & locals[127] ^ locals[779]) & locals[523] ^ locals[127];
        locals[523] =
            ((locals[812] ^ locals[523] ^ locals[352]) & locals[781] ^ locals[812] ^ locals[523] ^ locals[352]) &
            locals[127] ^
            ((locals[781] ^ locals[127]) & locals[812] ^ locals[781] ^ locals[127]) & locals[779] ^ locals[781] ^
            locals[523];
        locals[779] = ~locals[523];
        locals[813] = locals[773] & (locals[802] ^ locals[779]);
        locals[812] = locals[761] & locals[779];
        locals[811] = ~locals[761];
        locals[800] = ~(((locals[523] ^ locals[773] ^ locals[802] ^ locals[301]) & locals[761] ^
                         (locals[773] ^ locals[802] ^ locals[301]) & locals[523] ^ locals[773] ^ locals[802] ^
                         locals[301]) & locals[704]) ^
                      (~((locals[802] ^ locals[811]) & locals[523]) ^ locals[761] ^ locals[813]) & locals[301] ^
                      ((locals[761] ^ locals[802]) & locals[523] ^ locals[761] ^ locals[802]) & locals[773] ^
                      (locals[523] ^ locals[812]) & locals[802];
        locals[781] = locals[800] ^ locals[523];
        locals[749] = locals[704] & (locals[761] ^ locals[779]);
        locals[782] = (~locals[749] ^ locals[523] ^ locals[802] ^ locals[812]) & locals[773] ^
                      (locals[523] ^ locals[773] ^ locals[802] ^ locals[749] ^ locals[812]) & locals[301] ^
                      locals[523] ^ locals[802];
        locals[749] = locals[523] & ~locals[802];
        locals[773] = ((locals[773] ^ locals[811]) & locals[802] ^ locals[761]) & locals[523] ^
                      (~(locals[761] & (locals[802] ^ locals[779])) ^ locals[802] ^ locals[749]) & locals[704] ^
                      (locals[802] ^ locals[749] ^ locals[813]) & locals[301] ^ locals[761] & ~locals[802] ^
                      locals[773];
        locals[813] = locals[781] & locals[779];
        locals[749] = locals[773] & locals[779];
        locals[462] = (~locals[749] ^ locals[523]) & locals[782] & locals[781];
        locals[462] = ~((~((~((locals[800] & locals[773] ^ locals[813]) & locals[782]) ^
                            ~(locals[523] & locals[781]) & locals[773] ^
                            locals[523]) & locals[761]) ^ locals[523] ^ locals[462] ^ locals[749]) & locals[704]) ^
                      (~locals[462] ^ locals[523] ^ locals[749]) & locals[761] ^ locals[523] ^ locals[781];
        locals[800] = ((~((~(locals[761] & (locals[781] ^ locals[779])) ^ locals[523] ^ locals[813]) & locals[782]) ^
                        (locals[523] ^ ~locals[812]) & locals[781] ^ locals[523] ^ locals[761]) & locals[704] ^
                       (~(locals[782] & (~locals[813] ^ locals[523])) ^ locals[523] ^ locals[813]) & locals[761] ^
                       locals[523] ^ locals[781])
                      & locals[773] ^ (~(locals[782] & locals[781]) & locals[704] & locals[761] ^ locals[781]) &
                      locals[523] ^
                      locals[781];
        locals[749] = locals[781] & (locals[761] ^ locals[779]);
        locals[749] =
            (~((~locals[749] ^ locals[523] ^ locals[761]) & locals[773]) ^ locals[523] ^ locals[761] ^ locals[749]) &
            locals[704] ^
            (~(locals[773] & (~locals[813] ^ locals[523])) ^ locals[523] ^ locals[813]) & locals[761] ^
            locals[773] & (locals[781] ^ locals[779]) ^ locals[523] & locals[781];
        locals[813] = ~locals[797] & locals[709] ^ locals[793] & (locals[709] ^ locals[797]) ^ locals[797];
        locals[802] = (locals[813] ^ locals[749] ^ locals[462]) & locals[800] ^
                      (locals[813] ^ locals[462]) & locals[749] ^ locals[797];
        locals[794] = (~(locals[797] & (~locals[749] ^ locals[800])) ^ locals[749] ^ locals[800]) & locals[709] ^
                      locals[793] & (~locals[749] ^ locals[800]) & (locals[709] ^ locals[797]) ^ locals[797] ^
                      locals[749];
        locals[793] = (~locals[800] & locals[797] ^ locals[709] & (locals[797] ^ locals[800])) & locals[793] ^
                      (~((locals[709] ^ locals[462]) & locals[797]) ^ locals[709] ^ locals[462]) & locals[800] ^
                      ~((locals[797] ^ locals[800]) & locals[462]) & locals[749];
        locals[813] = ~locals[794];
        locals[749] = ~locals[781];
        locals[462] = locals[813] & 0xaaaaaaaa;
        locals[797] = ((((locals[749] & locals[793] ^ locals[781] & locals[813]) & 0x55555555 ^ locals[462]) &
                        locals[802] ^
                        (locals[781] & 0x55555555 ^ 0xaaaaaaaa) & locals[813]) & locals[773] ^
                       ((locals[793] & 0x55555555 ^ locals[462]) & locals[802] ^ locals[462]) & locals[781]) &
                      locals[782] ^
                      (~(locals[813] & locals[802]) ^ locals[794]) & locals[773] & locals[781] ^
                      (locals[794] ^ locals[793] ^ 0x55555555) & locals[802] ^ locals[794];
        locals[462] = ~locals[802];
        locals[774] = ~(((~locals[773] ^ locals[781] ^ locals[802]) & locals[793] ^
                         (locals[773] ^ locals[781] ^ locals[794]) & locals[802] ^
                         locals[773] ^ locals[794]) & locals[782]) ^
                      ((locals[781] ^ locals[794]) & locals[802] ^ (locals[749] ^ locals[802]) & locals[793] ^
                       locals[794]) & locals[773] ^
                      (~(locals[462] & locals[793]) ^ locals[802]) & locals[794] ^ locals[793] ^ locals[802];
        locals[800] = locals[781] & (locals[793] ^ locals[802]);
        locals[765] = (~(locals[773] & (locals[793] ^ locals[802])) ^ locals[800] ^ locals[793] ^ locals[802]) &
                      locals[782] ^
                      (~locals[800] ^ locals[793] ^ locals[802]) & locals[773] ^
                      (locals[813] & locals[802] ^ locals[794]) & locals[793] ^
                      locals[802];
        locals[766] =
            ((~locals[720] ^ locals[794] ^ locals[793]) & locals[802] ^ locals[720] ^ locals[794] ^ locals[793]) &
            locals[796] ^
            ((locals[796] ^ locals[802]) & locals[720] ^ locals[796] ^ locals[802]) & locals[92] ^ locals[720] ^
            locals[793] ^
            locals[802];
        locals[800] = ~((locals[794] ^ locals[793]) & locals[802]) ^ locals[781] ^ locals[794] ^ locals[793];
        locals[768] = ~(locals[782] & locals[800]) ^ locals[773] & locals[800] ^ locals[793] ^ locals[802];
        locals[800] = ~locals[796];
        locals[301] = (locals[800] ^ locals[794]) & locals[802];
        locals[301] = ~(((locals[800] ^ locals[793] ^ locals[802]) & locals[92] ^
                         (locals[800] ^ locals[802]) & locals[793] ^ locals[796] ^
                         locals[301] ^ locals[794]) & locals[720]) ^
                      (~(locals[800] & locals[794]) ^ locals[92] ^ locals[796]) & locals[802] ^
                      (locals[92] ^ locals[796] ^ locals[301] ^ locals[794]) & locals[793] ^
                      (locals[636] ^ locals[794]) & locals[796] ^
                      locals[92] ^ locals[794];
        locals[636] =
            (~((locals[796] ^ locals[636] ^ locals[802]) & locals[720]) ^ locals[92] ^ locals[796] ^ locals[802]) &
            locals[793] ^
            ((locals[720] ^ locals[793]) & locals[802] ^ locals[720] ^ locals[793]) & locals[794] ^ locals[796] ^
            locals[802];
        locals[800] = (~(locals[301] & 0xffff0000) ^ locals[766]) & locals[636] ^
                      ~locals[766] & locals[301] & 0xffff0000;
        locals[796] = ~locals[636] & locals[766] & 0xffff;
        locals[720] = ((locals[813] ^ locals[793]) & locals[802] ^ locals[813]) & locals[773];
        locals[749] = (((locals[813] ^ locals[793]) & locals[749] & locals[802] ^ locals[720] ^
                        locals[781] & locals[813] ^ locals[794]) &
                          locals[782] ^ locals[781] & locals[720] ^ locals[794]) & 0x55555555 ^
                      ((locals[794] ^ locals[793]) & 0x55555555 ^ locals[793]) & locals[802] ^ 0xaaaaaaaa;
        locals[720] = ((~locals[301] & locals[636] ^ ~locals[766] & locals[301] ^ locals[766]) & 0xffff) >> 1;
        locals[766] = ~(~(locals[796] >> 1) & locals[800] >> 1) & locals[720] ^ locals[800] >> 1;
        locals[462] = ~((((locals[782] & 0x55555555 ^ 0xaaaaaaaa) & locals[781] ^ locals[782]) & locals[773] ^
                         locals[782] & locals[781] ^ 0xaaaaaaaa) & locals[793]) & locals[802] ^
                      ~(~locals[782] & locals[773] & locals[781] & locals[462] & locals[813] & 0x55555555) ^
                      locals[462] & locals[794] & 0xaaaaaaaa ^ locals[782] & 0x55555555;
        locals[760] = ~(~((locals[800] & locals[796]) >> 1) & locals[720]) ^ locals[796] >> 1;
        locals[720] = ~locals[797] & locals[749];
        locals[802] = (locals[796] ^ locals[800]) >> 1;
        locals[813] = ((locals[811] ^ locals[797]) & locals[523] ^ (locals[523] ^ locals[797]) & locals[749] ^
                       (locals[523] ^ locals[761]) & locals[704] ^ locals[761]) & locals[462] ^
                      (locals[704] & locals[811] ^ locals[720] ^ locals[797]) & locals[523] ^ locals[704];
        locals[720] = (~(((locals[523] ^ locals[749] ^ locals[797]) & locals[462] ^
                          (locals[523] ^ locals[462]) & locals[761] ^ locals[720] ^
                          locals[797]) & locals[704] ^
                         (locals[749] & locals[797] ^ locals[523] ^ ~locals[812]) & locals[462] ^ locals[523]) ^
                       locals[813]) &
                      ((~((locals[779] ^ locals[749] ^ locals[797]) & locals[462]) ^
                        (locals[779] ^ locals[462]) & locals[761] ^ locals[720] ^
                        locals[797]) & locals[704] ^ (~(locals[779] & locals[462]) ^ locals[523]) & locals[761] ^
                       (locals[720] ^ locals[797]) & locals[462] ^ locals[523] ^ locals[720] ^ locals[797]);
        locals[636] = ~locals[720] ^ locals[813];
        locals[812] = ~((~locals[331] & locals[787] ^ ~locals[720] ^ locals[813]) & locals[816]) ^
                      locals[787] & locals[636] ^ locals[720] ^
                      locals[813];
        locals[704] = ~((~((~((locals[720] ^ locals[813]) & locals[331]) ^ locals[720] ^ locals[813]) & locals[816]) ^
                         locals[331]) &
                        locals[787]) ^ locals[816] ^ locals[720] ^ locals[813];
        locals[800] = locals[800] >> 0x11;
        locals[811] = locals[800] ^ 0xffffffff;
        locals[816] = ~((~(locals[816] & locals[636]) ^ locals[720] ^ locals[813]) & locals[331]) & locals[787] ^
                      locals[816];
        locals[301] = locals[816] ^ locals[768];
        locals[720] = locals[704] ^ ~locals[812];
        locals[331] = (locals[765] ^ locals[774]) & locals[768] ^ locals[816] & locals[720] ^ locals[704] ^
                      ~locals[774] & locals[765];
        locals[796] =
            ((~locals[816] ^ locals[765]) & locals[774] ^ (locals[765] ^ locals[720]) & locals[816] ^ locals[704]) &
            locals[768] ^
            (~(~locals[774] & locals[765]) ^ locals[812]) & locals[816];
        locals[720] = (locals[796] ^ locals[301]) & locals[331];
        locals[788] = ~((locals[816] & ~locals[812] ^ locals[301] ^ locals[720]) & locals[704]) ^
                      (locals[301] ^ locals[720]) & locals[812] ^
                      locals[331] ^ locals[816];
        locals[720] = ~locals[331];
        locals[636] = ~locals[301];
        locals[793] = ~(~(locals[301] & locals[720]) & locals[796] & 0xffff) ^
                      (locals[331] & locals[636] ^ locals[301]) & 0xffff;
        locals[779] = ~locals[796];
        locals[813] = locals[301] ^ locals[779];
        locals[787] = (~(locals[816] & (locals[812] ^ locals[813])) ^ locals[301]) & locals[331] ^
                      ~((locals[816] ^ locals[720]) & locals[812]) & locals[704] ^ locals[816] & locals[636] ^
                      locals[301] ^ locals[812];
        locals[704] = (~((locals[768] ^ locals[779]) & locals[812]) ^ locals[816] & locals[813] ^
                       locals[704] & (locals[812] ^ locals[813]) ^
                       locals[796]) & locals[331] ^ (locals[816] ^ locals[812] ^ locals[704]) & locals[301] ^
                      locals[812] ^ locals[704];
        locals[761] = ((locals[704] ^ 0xffff0000) & locals[787] ^ locals[704] ^ 0xffff0000) & locals[788] ^
                      ~locals[787] & locals[704] & 0xffff;
        locals[816] = ~locals[704];
        locals[812] = (locals[787] & locals[816] & 0xffff ^ 0xffff0000) & locals[788];
        locals[792] = locals[812] ^ 0xffff0000;
        locals[779] = locals[301] & locals[779] & locals[720] & 0xffff;
        locals[781] = ~(locals[331] & locals[813]) ^ locals[301];
        locals[782] = (~(locals[787] & locals[813]) ^ locals[796] ^ locals[301]) & locals[331] &
                      (locals[704] ^ locals[788]) ^
                      ~(locals[787] & (locals[704] ^ locals[788])) & locals[301] ^ locals[704] & locals[788];
        locals[773] = ((locals[781] ^ locals[779]) & locals[793]) >> 1 ^ ~(locals[781] >> 1) & locals[779] >> 1;
        locals[794] = ~(locals[779] << 0xf) & locals[793] << 0xf ^ locals[781] << 0xf ^ 0x7fff;
        locals[774] = ((locals[787] ^ 0xffff) & locals[788] ^ locals[787]) & locals[704] ^ 0xffff;
        locals[813] = (~((~(locals[704] & locals[813]) ^ locals[796] ^ locals[301]) & locals[788]) ^ locals[796] ^
                       locals[301] ^
                       locals[704] & locals[813]) & locals[331] ^
                      (locals[788] & locals[816] ^ locals[704]) & locals[301] ^ locals[788];
        locals[812] = locals[812] << 0x10;
        locals[765] = ~((locals[774] ^ locals[761]) << 0x10) & locals[812];
        locals[812] = ~(locals[774] << 0x10) ^ locals[812];
        locals[768] = (locals[779] & locals[793]) >> 1;
        locals[769] = (locals[779] ^ locals[793]) >> 1;
        locals[720] = (locals[792] ^ ~locals[774]) & locals[761];
        locals[709] = ((locals[769] ^ locals[774]) & locals[792] ^ (locals[769] ^ locals[792]) & locals[773] ^
                       locals[774] ^ locals[720]) &
                      locals[768] ^ (~(locals[774] & ~locals[792]) ^ locals[792]) & locals[761] ^
                      ~(locals[773] & ~locals[792]) & locals[769]
                      ^ locals[774] & locals[792];
        locals[788] = ((~((~((locals[301] ^ locals[816]) & locals[796]) ^ locals[704] & locals[636] ^ locals[301]) &
                          locals[787]) ^
                        (~(locals[796] & locals[636]) ^ locals[301]) & locals[704] ^ locals[796] ^ locals[301]) &
                       locals[788] ^
                       ~(locals[704] & locals[787]) & locals[796] & locals[301]) & locals[331] ^
                      (~(~locals[788] & locals[787] & locals[301]) ^ locals[788] ^ locals[301]) & locals[704] ^
                      locals[788];
        locals[301] = ((locals[781] ^ locals[793]) & locals[779] ^ locals[781]) << 0xf ^ 0x7fff;
        locals[779] = (~(locals[781] << 0xf) & locals[779] << 0xf ^ ~(locals[793] << 0xf)) & 0xffff8000;
        locals[816] = (locals[749] ^ ~locals[788] ^ locals[782]) & locals[813];
        locals[331] =
            ~(((locals[797] ^ ~locals[788] ^ locals[782]) & locals[749] ^ ~locals[816] ^ locals[788] ^ locals[797]) &
              locals[462]) ^
            ((locals[782] ^ locals[788] ^ locals[813]) & locals[749] ^ locals[788] ^ locals[813] ^ locals[782]) &
            locals[797] ^
            locals[782] & (locals[788] ^ locals[813]) ^ locals[788];
        locals[796] = (locals[761] & locals[774] & locals[792]) << 0x10;
        locals[793] = ~locals[796];
        locals[636] = locals[792] ^ ~locals[773];
        locals[787] = ~(((locals[792] ^ locals[761] ^ locals[769] ^ locals[773]) & locals[774] ^
                         (locals[761] ^ locals[769] ^ locals[773]) & locals[792] ^ locals[769] ^ locals[773] ^
                         locals[761]) & locals[768]) ^
                      ((locals[761] ^ locals[636]) & locals[774] ^ (locals[761] ^ ~locals[773]) & locals[792] ^
                       locals[773] ^ locals[761]) &
                      locals[769] ^ locals[774];
        locals[792] =
            (~((locals[773] ^ ~locals[774]) & locals[768]) ^ locals[774] & locals[636] ^ locals[773] ^ locals[720]) &
            locals[769] ^
            (~locals[761] & locals[792] ^ locals[768] & locals[773]) & locals[774] ^ locals[768] ^ locals[792];
        locals[636] = (~((~locals[813] ^ locals[462]) & locals[749]) ^ locals[813] ^ locals[462]) & locals[797] ^
                      ~((locals[788] ^ locals[816]) & locals[462]) ^ locals[788] & locals[813] ^ locals[782];
        locals[816] = (~locals[765] ^ locals[794]) & locals[301];
        locals[816] = (locals[793] & locals[301] ^ locals[794] & (locals[301] ^ locals[796])) & locals[779] ^
                      (~locals[816] ^ locals[765] ^ locals[794]) & locals[793] ^
                      ~(locals[765] & (locals[301] ^ locals[796])) & locals[812] ^
                      locals[794] ^ locals[816];
        locals[749] = (locals[462] ^ locals[797]) & locals[749];
        locals[704] = (locals[301] & (locals[765] ^ locals[812]) ^ locals[765] ^ locals[812]) & locals[794] ^
                      (locals[765] & locals[796] ^ locals[793]) & locals[812] ^
                      (locals[301] ^ locals[794]) & locals[779] & (locals[765] ^ locals[812]) ^ locals[793] ^
                      locals[301] ^ locals[765];
        locals[720] = (~locals[636] ^ locals[331]) &
                      (~((locals[813] ^ locals[782] ^ locals[749] ^ locals[462] ^ locals[797]) & locals[788]) ^
                       (~locals[749] ^ locals[813] ^ locals[462] ^ locals[797]) & locals[782] ^ locals[813] ^
                       locals[462]);
        locals[813] = (locals[636] ^ locals[331]) & 0xffff0000 ^ ~(locals[720] & 0xffff0000);
        locals[812] = ~(((locals[793] ^ locals[301] ^ locals[765] ^ locals[812]) & locals[779] ^
                         (locals[793] ^ locals[765] ^ locals[812]) & locals[301] ^ locals[793] ^ locals[765] ^
                         locals[812]) & locals[794]) ^
                      (~((locals[812] ^ locals[796]) & locals[779]) ^ locals[793] ^ locals[812]) & locals[301] ^
                      ((locals[793] ^ locals[779] ^ locals[812]) & locals[301] ^ locals[793] ^ locals[812]) &
                      locals[765] ^ locals[812];
        locals[636] = ~locals[331] & locals[636];
        locals[779] = locals[636] & 0xffff ^ locals[720];
        locals[749] = locals[636] & 0xffff0000;
        locals[301] = locals[636] >> 0x10;
        locals[720] = locals[720] >> 0x10;
        locals[462] = ~((locals[813] & locals[636]) >> 0x10) ^ locals[720];
        locals[301] = (~locals[301] & locals[720] ^ locals[301]) & locals[813] >> 0x10 ^ locals[301];
        locals[796] = ~locals[720] ^ locals[813] >> 0x10;
        locals[720] = (locals[779] ^ locals[749]) & (locals[760] ^ locals[766]);
        locals[797] = ~(locals[749] & (~locals[760] ^ locals[766])) & locals[779] ^
                      (locals[779] ^ locals[749] ^ locals[720]) & locals[813] ^
                      (~locals[760] ^ locals[766]) & locals[802] ^ locals[760];
        locals[636] = ~(((locals[749] ^ locals[802]) & locals[779] ^ (locals[779] ^ locals[802]) & locals[766] ^
                         locals[813] & (locals[779] ^ locals[749])) & locals[760]) ^
                      (~(~locals[749] & locals[813]) ^ ~locals[802] & locals[766] ^ locals[749] ^ locals[802]) &
                      locals[779] ^ locals[766];
        locals[760] = (~(locals[749] & (locals[760] ^ locals[766])) ^ locals[760] ^ locals[766]) & locals[779] ^
                      locals[813] & locals[720] ^
                      locals[760];
        locals[331] = (locals[301] & locals[800] ^ locals[301]) & locals[811] ^
                      (locals[462] & locals[301] ^ locals[301]) & locals[796] ^
                      locals[301];
        locals[720] = ~locals[704];
        locals[802] =
            ((locals[636] ^ locals[760] ^ locals[816]) & locals[797] ^ locals[636] ^ locals[760] ^ locals[816]) &
            locals[704] ^
            ((locals[797] ^ locals[704]) & locals[816] ^ locals[797] & locals[720]) & locals[812] ^ locals[636] ^
            locals[797];
        locals[793] = (~((~locals[797] ^ locals[704]) & locals[816]) ^ locals[704] ^ locals[797] & locals[720]) &
                      locals[812] ^
                      (~((~locals[636] ^ locals[760] ^ locals[816]) & locals[704]) ^ locals[760]) & locals[797] ^
                      locals[760] & locals[720] ^
                      locals[636];
        locals[797] = (locals[636] & locals[720] ^ locals[816] & (locals[636] ^ locals[704])) & locals[812] ^
                      (~((locals[797] ^ locals[816]) & locals[636]) ^ locals[797] ^ locals[816]) & locals[704] ^
                      (locals[797] & (locals[636] ^ locals[704]) ^ locals[636] ^ locals[704]) & locals[760] ^
                      locals[797];
        locals[784] = (locals[793] ^ locals[802]) & 0x30003;
        locals[816] = ~locals[797];
        locals[720] = ~locals[802];
        locals[636] = locals[802] & locals[816];
        locals[704] = ~(locals[793] & locals[720] & locals[816] & 0xc000c0) ^
                      (locals[636] & 0xffcfffcf ^ locals[797]) & 0xf000f0;
        locals[761] = ((locals[797] & 0xc000c ^ locals[720]) & locals[793] ^ locals[797] & 0xc000c) & 0x300c300c;
        locals[781] = (locals[797] & locals[802] & 0xc000c ^ 0x30003000) & locals[793];
        locals[796] = ~(locals[811] & locals[800]) ^ (~locals[796] ^ locals[301]) & locals[462] ^ locals[811] ^
                      locals[796];
        locals[782] =
            ((~(locals[797] & 0x300030) & locals[802] ^ locals[816]) & locals[793] ^ locals[797] & 0xffcfffcf) &
            0xf000f0;
        locals[779] = ~locals[331];
        locals[813] = ~(locals[792] & (locals[796] ^ locals[301]));
        locals[749] = ~((~((locals[301] ^ locals[792] ^ locals[709]) & locals[796]) ^
                         (locals[792] ^ locals[709] ^ locals[779]) & locals[301]
                         ^ locals[709]) &
                        locals[787]) ^ ((locals[331] ^ locals[709]) & locals[796] ^ locals[709] & locals[779]) &
                                     locals[301]
                                     ^ locals[813] & locals[709];
        locals[773] = ((locals[796] ^ locals[301]) & locals[709] ^ locals[796] ^ locals[301] ^ locals[813]) &
                      locals[787] ^
                      (~(locals[796] & locals[779]) ^ locals[331]) & locals[301] ^
                      (locals[796] ^ locals[301] ^ locals[813]) & locals[709];
        locals[794] = ((locals[797] & 0xc000c00 ^ 0xc000c000) & locals[802] ^ (locals[797] ^ 0xf3fff3ff) & 0xcc00cc00) &
            locals[793] ^ ~(locals[802] & 0xc000c00) & locals[797] & 0xcc00cc00;
        locals[774] = (locals[793] ^ locals[802]) & 0xc000c00;
        locals[765] = ((locals[793] ^ 0xffcfffcf) & locals[802] ^ 0x300030) & locals[797] & 0xf000f0;
        locals[766] = (locals[704] & (locals[765] ^ locals[782]) ^ locals[782]) << 4;
        locals[768] = (~(locals[797] & 0xc000c00) & locals[802] ^ ~(locals[797] & 0xf3fff3ff)) & locals[793] &
                      0xcc00cc00 ^
                      (locals[802] & 0xc000c00 ^ 0xc000c000) & locals[797];
        locals[301] = ((~locals[796] ^ locals[331]) & locals[301] ^ locals[792]) & (locals[787] ^ locals[709]) ^
                      locals[796] ^ locals[301];
        locals[779] = locals[301] & ~locals[773];
        locals[462] = (~(locals[773] & 0xfffcfffc) ^ locals[779]) & locals[749] & 0x30033003;
        locals[813] = ~(locals[704] << 4);
        locals[787] = ~((locals[765] & locals[782]) << 4 & locals[813]);
        locals[800] = locals[782] >> 2;
        locals[769] = ~((locals[782] & locals[765]) >> 2) & locals[704] >> 2 ^ locals[800];
        locals[709] = ~locals[793] & locals[797] & locals[720] & 0x30003;
        locals[800] = ~(~(~locals[800] & locals[765] >> 2) & locals[704] >> 2) ^ locals[800];
        locals[796] = ~((~(locals[797] & 0x30003) & locals[802] ^ locals[816] & 0xfffcfffc) & locals[793] & 0x3030303) ^
                      locals[797] & 0x3000300 ^ locals[636] & 0x30003;
        locals[788] = ~(locals[749] & locals[779] & 0x30003) ^ locals[773] & 0x30003000;
        locals[792] = (locals[765] ^ locals[782]) >> 2;
        locals[816] = ~locals[749];
        locals[720] = locals[749] & 0x300030;
        locals[760] = ((locals[301] & locals[816] & 0x300030 ^ ~locals[720]) & locals[773] ^ locals[720]) & 0xc030c030;
        locals[814] = ~((locals[301] ^ 0x30003) & locals[773] & locals[816] & 0x30033003) ^ locals[749] & 0x30003;
        locals[779] = ~(locals[774] >> 4);
        locals[331] = locals[794] >> 4;
        locals[699] = ~(locals[331] & locals[779]) & locals[768] >> 4 ^ locals[331];
        locals[790] = (((locals[749] ^ 0xc000c0) & locals[301] ^ locals[816] & 0xc000c0) & locals[773] ^
                       locals[749] & ~locals[301]) &
                      0x3c003c0;
        locals[812] = ~(locals[814] << 6);
        locals[802] = locals[462] << 6;
        locals[753] = ~(locals[802] & locals[812]) & locals[788] << 6 ^ locals[802];
        locals[777] = ~((locals[709] ^ locals[784]) >> 6) & 0x3ffffff;
        locals[811] = locals[773] & locals[816] ^ locals[749];
        locals[778] = ~((locals[749] & 0xc000c ^ locals[773] ^ 0xfff3fff3) & locals[301] & 0xc0c0c0c) ^
                      locals[811] & 0xc000c;
        locals[799] = (locals[749] & ~locals[773] & 0x3000300 ^ 0xc000c0) & locals[301];
        locals[795] = (((locals[749] ^ 0xff3fff3f) & locals[773] ^ 0xc000c0) & locals[301] ^ locals[811] & 0xff3fff3f) &
                      0x3c003c0;
        locals[704] = ~(locals[782] << 4 & locals[813]) & locals[765] << 4 ^ locals[704] << 4;
        locals[782] = ~(((locals[709] ^ locals[784]) & locals[796]) << 2);
        locals[796] = locals[796] >> 6;
        locals[813] = ~locals[796];
        locals[765] = (~(locals[709] >> 6 & locals[813]) & locals[784] >> 6 ^ locals[813]) & 0x3ffffff;
        locals[796] = (locals[784] >> 6 & locals[813] ^ locals[796]) & locals[709] >> 6 ^ locals[796] ^ 0xfc000000;
        locals[811] = locals[799] << 8;
        locals[813] = ~(locals[795] << 8);
        locals[751] = (locals[795] & locals[790]) << 8 ^ locals[811] & locals[813];
        locals[735] = ~(locals[301] & 0xc000c00) ^ locals[773] & 0xc000c00;
        locals[784] = locals[784] << 2;
        locals[707] = ~locals[784] & locals[709] << 2 ^ locals[784];
        locals[784] = ~(locals[709] << 2) ^ locals[784];
        locals[812] = (locals[462] & locals[788]) << 6 & locals[812] ^ ~locals[802] & locals[814] << 6;
        locals[636] = ((~locals[636] & 0xc000c ^ locals[797]) & locals[793] ^ locals[797] & 0xfff3fff3) & 0x300c300c;
        locals[720] = locals[773] & locals[301] & locals[816] & 0xc000c000 ^ locals[720];
        locals[648] = (locals[761] ^ locals[636]) >> 10;
        locals[462] = locals[462] >> 6;
        locals[793] = ~(locals[788] >> 6) & locals[462] ^ locals[814] >> 6;
        locals[802] = (locals[761] ^ locals[636]) << 8;
        locals[802] = ~locals[802] & locals[781] << 8 ^ locals[802];
        locals[816] = locals[761] >> 10;
        locals[797] = ~((locals[781] ^ locals[636]) >> 10) & locals[816];
        locals[709] = (locals[814] ^ locals[788]) << 6;
        locals[805] = (locals[773] ^ ~locals[301]) & locals[749] & 0xc000c00;
        locals[807] = locals[781] >> 10 & ~(locals[636] >> 10) & locals[816] ^ ~locals[816] & locals[636] >> 10;
        locals[331] = locals[331] ^ locals[779];
        locals[808] = ~(locals[814] >> 6) & locals[788] >> 6 ^ locals[462];
        locals[732] = (locals[735] ^ locals[778]) << 0xc;
        locals[816] = ~(locals[781] << 8);
        locals[580] = ~((locals[761] & locals[636]) << 8 & locals[816]);
        locals[761] = locals[790] << 8 & locals[813] ^ locals[811];
        locals[749] = (locals[301] ^ 0xffcfffcf) & locals[749];
        locals[301] = ((locals[749] ^ 0xffcfffcf) & locals[773] ^ locals[749]) & 0xc030c030;
        locals[721] = locals[301] << 2 & ~(locals[760] << 2) & ~(locals[720] << 2);
        locals[816] = locals[636] << 8 ^ locals[816];
        locals[636] = ~locals[709] ^ locals[812];
        locals[810] = ~(((~locals[812] ^ locals[782]) & locals[707] ^ (locals[709] ^ locals[782]) & locals[812] ^
                         locals[636] & locals[753] ^
                         locals[709] ^ locals[782]) &
                        locals[784]) ^ (~(locals[707] & locals[782]) ^ locals[709] & locals[753]) & locals[812]
                                     ^ locals[707];
        locals[749] = locals[805] << 0xc;
        locals[781] = ~locals[749] & locals[778] << 0xc ^ (locals[805] ^ locals[735]) << 0xc;
        locals[749] = ~(~(~(locals[778] << 0xc) & locals[749]) & locals[735] << 0xc) ^ locals[749];
        locals[782] = (~((locals[709] ^ locals[784]) & locals[812]) ^ (~locals[812] ^ locals[784]) & locals[782] ^
                       locals[636] & locals[753] ^
                       locals[709] ^ locals[784]) & locals[707] ^
                      (locals[784] & locals[782] ^ locals[709] & locals[753]) & locals[812] ^
                      locals[784];
        locals[403] = ~(~((locals[768] & locals[794]) >> 4) & locals[774] >> 4) ^ locals[768] >> 4;
        locals[773] = ~(locals[735] << 4) & locals[778] << 4 ^ locals[805] << 4;
        locals[708] = ~locals[811] & locals[795] << 8 ^ locals[790] << 8;
        locals[462] = ~((locals[814] & locals[788]) >> 6) ^ locals[462];
        locals[811] = ~(locals[805] << 4) & locals[735] << 4 ^ locals[778] << 4;
        locals[788] = ((locals[805] ^ locals[778]) & locals[735] ^ locals[805]) << 4;
        locals[814] = ~((locals[301] ^ locals[720]) << 2) & locals[760] << 2 ^ locals[720] << 2;
        locals[707] = (~(locals[636] & locals[707]) ^ locals[636] & locals[784] ^ locals[709] ^ locals[812]) &
                      locals[753] ^
                      (~((~locals[707] ^ locals[784]) & locals[812]) ^ locals[707] ^ locals[784]) & locals[709] ^
                      (locals[707] ^ locals[784]) & locals[812] ^ locals[707];
        locals[636] = (~locals[301] ^ locals[760]) & locals[720];
        locals[779] = (locals[301] ^ locals[760]) & locals[720];
        locals[709] = ~((locals[636] ^ locals[301] ^ locals[331]) & locals[403]) ^
                      (~locals[636] ^ locals[301] ^ locals[331]) & locals[699] ^
                      locals[779] ^ locals[301] ^ locals[331];
        locals[636] = ~locals[768] ^ locals[788];
        locals[813] = ~locals[794] ^ locals[788];
        locals[812] = ~locals[768] & locals[794];
        locals[676] = ((locals[636] ^ locals[773]) & locals[811] ^ ~locals[794] & locals[768] ^
                       locals[636] & locals[773] ^ locals[794]) &
                      locals[774] ^ (~((locals[813] ^ locals[773]) & locals[768]) ^ locals[794] ^ locals[773]) &
                      locals[811] ^
                      (~(locals[813] & locals[768]) ^ locals[794]) & locals[773] ^ locals[812];
        locals[753] = (locals[301] ^ locals[760]) << 2;
        locals[636] = ~locals[708] ^ locals[751];
        locals[813] = locals[636] & locals[704];
        locals[813] = ((locals[787] ^ locals[704]) & locals[636] ^ locals[708] ^ locals[751]) & locals[766] ^
                      (~locals[813] ^ locals[708] ^ locals[751]) & locals[787] ^ locals[751] ^ locals[813];
        locals[778] = (~locals[779] ^ locals[301]) & locals[699] ^ (locals[779] ^ locals[301]) & locals[403] ^
                      locals[720];
        locals[636] = (~locals[774] ^ locals[794]) & locals[768] ^ locals[774] ^ locals[794] ^ locals[788];
        locals[735] = ~(locals[811] & locals[636]) ^ locals[773] & locals[636] ^ locals[768] ^ locals[774];
        locals[784] = (~((~locals[749] ^ locals[732] ^ locals[580]) & locals[802]) ^
                       (locals[749] ^ locals[580]) & locals[732] ^
                       locals[749] & locals[580]) & locals[781] ^ ~(~locals[802] & locals[732]) & locals[580] ^
                      (locals[781] ^ locals[732] ^ locals[580]) & locals[816] & locals[802];
        locals[636] = ~locals[761];
        locals[805] = (~((locals[636] ^ locals[751] ^ locals[704]) & locals[708]) ^
                       (locals[708] ^ locals[704]) & locals[787] ^
                       locals[636] & locals[751]) & locals[766] ^
                      (~locals[751] & locals[761] ^ ~(~locals[704] & locals[787]) ^ locals[704]) & locals[708] ^
                      locals[751];
        locals[773] = ((locals[773] ^ locals[768] ^ locals[788]) & locals[811] ^
                       locals[773] & (locals[768] ^ locals[788]) ^ locals[812]) &
                      locals[774] ^
                      (~((locals[773] ^ locals[794] ^ locals[788]) & locals[768]) ^ locals[794] ^ locals[788]) &
                      locals[811] ^
                      (~(locals[768] & (locals[794] ^ locals[788])) ^ locals[794] ^ locals[788]) & locals[773];
        locals[811] = locals[795] >> 2;
        locals[779] = ~(locals[799] >> 2);
        locals[794] = locals[811] ^ locals[779];
        locals[812] = ~locals[807];
        locals[774] = ~(((locals[808] ^ locals[807] ^ locals[797] ^ locals[648]) & locals[793] ^
                         (locals[812] ^ locals[797] ^ locals[648]) & locals[808]) & locals[462]) ^
                      ((locals[807] ^ locals[648]) & locals[793] ^ locals[808] ^ locals[807] ^ locals[648]) &
                      locals[797] ^
                      (locals[812] ^ locals[793] ^ locals[648]) & locals[808] ^ locals[793] ^ locals[648];
        locals[812] =
            ~(((~locals[808] ^ locals[648]) & locals[462] ^ (locals[807] ^ locals[648]) & locals[797] ^ locals[808]) &
              locals[793])
            ^ (~locals[462] & locals[808] ^ locals[812] & locals[797]) & locals[648] ^ locals[807] ^ locals[797];
        locals[768] = ~(locals[811] & locals[779]) & locals[790] >> 2 ^ locals[799] >> 2;
        locals[462] = (locals[808] ^ locals[793]) & locals[462];
        locals[648] = (locals[807] & locals[648] ^ locals[462] ^ locals[808] ^ locals[793]) & locals[797] ^
                      (locals[462] ^ locals[808] ^ locals[793] ^ locals[648]) & locals[807] ^ locals[793] ^ locals[648];
        locals[779] = ~((~locals[781] ^ locals[580]) & locals[816]) & locals[802] ^
                      (locals[749] ^ locals[732] ^ locals[802]) & locals[781] & locals[580] ^ locals[732];
        locals[708] = ~(((locals[751] ^ locals[704]) & locals[787] ^ (locals[636] ^ locals[704]) & locals[751] ^
                         locals[708] & (locals[636] ^ locals[751])) & locals[766]) ^
                      (~locals[708] & locals[761] ^ ~locals[704] & locals[787] ^ locals[704]) & locals[751] ^
                      locals[708];
        locals[403] = ((~locals[301] ^ locals[331] ^ locals[760]) & locals[720] ^
                       (locals[331] ^ locals[720]) & locals[403] ^ locals[301]) &
            locals[699] ^ (~locals[331] & locals[403] ^ locals[331] ^ locals[760]) & locals[720] ^ locals[403];
        locals[811] = ~(~((locals[795] & locals[799]) >> 2) & locals[790] >> 2) ^ locals[811];
        locals[580] = ~(~((locals[781] ^ locals[816] ^ locals[580]) & locals[732]) & locals[802]) ^
                      ~((~locals[732] ^ locals[802]) & locals[749]) & locals[781] ^ locals[732] ^ locals[580];
        locals[816] = ~locals[580];
        locals[720] = (locals[816] ^ locals[784]) & locals[779];
        locals[749] = (locals[580] & ~locals[707] ^ (locals[816] ^ locals[707]) & locals[810] ^ locals[707]) &
                      locals[782] ^
                      (~(locals[816] & locals[784]) ^ locals[580]) & locals[779] ^
                      (locals[580] & (locals[784] ^ locals[707]) ^ locals[720]) & locals[810] ^ locals[784];
        locals[636] = locals[648] & locals[774];
        locals[462] = ~((~((locals[403] ^ locals[648] ^ locals[774] ^ locals[778]) & locals[812]) ^ locals[636]) &
                        locals[709]) ^
                      ~locals[812] & locals[648] & locals[774] ^ locals[403];
        locals[301] = (~((locals[779] ^ locals[816] ^ locals[707] ^ locals[810]) & locals[784]) ^
                       (~locals[779] ^ locals[707] ^ locals[810]) & locals[580] ^ locals[779] ^ locals[707] ^
                       locals[810]) & locals[782] ^
                      (~((locals[580] ^ locals[779] ^ locals[707]) & locals[784]) ^
                       (locals[779] ^ locals[707]) & locals[580] ^ locals[779] ^
                       locals[707]) & locals[810] ^ locals[580];
        locals[810] = ~(((locals[816] ^ locals[707]) & locals[784] ^ (locals[784] ^ locals[707]) & locals[810] ^
                         locals[580] ^ locals[720] ^
                         locals[707]) & locals[782]) ^
                      (~(~locals[707] & locals[810]) ^ locals[580] & locals[779]) & locals[784] ^ locals[580]
                      ^ locals[810];
        locals[816] = (locals[648] ^ locals[774]) & locals[812];
        locals[331] = (~locals[816] ^ locals[778] & locals[709] ^ locals[636]) & locals[403] ^
                      (locals[816] ^ locals[636] ^ locals[778]) & locals[709] ^ locals[812];
        locals[816] = (~locals[796] ^ locals[777]) & locals[765];
        locals[720] = ~locals[811];
        locals[802] = (locals[811] ^ locals[768]) & locals[794] ^ locals[720] & locals[768] ^
                      locals[796] & locals[777] ^ locals[816];
        locals[636] = (~locals[814] ^ locals[721]) & locals[753];
        locals[779] = locals[800] & locals[769] ^ ~locals[636] ^ locals[814];
        locals[793] = (locals[800] ^ locals[636] ^ locals[814] ^ locals[721]) & locals[769] ^
                      (locals[779] ^ locals[721]) & locals[792] ^
                      locals[721];
        locals[811] = (~((locals[720] ^ locals[777]) & locals[794]) ^ (locals[720] ^ locals[796]) & locals[777] ^
                       locals[811] ^ locals[816]) &
            locals[768] ^ (~locals[765] & locals[796] ^ locals[811] & locals[794]) & locals[777];
        locals[768] = locals[768] ^ locals[777];
        locals[704] = ~(((~locals[800] ^ locals[753] ^ locals[792]) & locals[769] ^ locals[753]) & locals[721]) ^
                      (~((~locals[769] ^ locals[721]) & locals[753]) ^ locals[769] ^ locals[721]) & locals[814] ^
                      ~locals[753] & locals[769] ^
                      locals[753] ^ locals[792];
        locals[761] = ((~locals[648] ^ locals[774]) & (locals[403] ^ locals[709]) ^ locals[648] ^ locals[774]) &
                      locals[812] ^
                      (~locals[403] ^ locals[709]) & locals[648] & locals[774] ^
                      ~(locals[778] & locals[709]) & locals[403];
        locals[816] = locals[761] & 0x44444444;
        locals[800] = ((~locals[462] ^ locals[816]) & locals[331] ^ locals[462]) & 0xcccccccc ^ 0x33333333;
        locals[721] = (locals[636] ^ locals[814]) & locals[769] ^ ~(locals[779] & locals[792]) ^ locals[636] ^
                      locals[814] ^ locals[721];
        locals[720] = locals[802] ^ locals[811] ^ locals[768];
        locals[636] = (~locals[811] ^ locals[768]) & locals[735];
        locals[796] = ((locals[720] ^ locals[676]) & locals[735] ^ locals[720] & locals[676] ^ locals[811] ^
                       locals[768] ^ locals[802]) &
                      locals[773] ^ (locals[636] ^ locals[768] ^ locals[676]) & locals[802] ^
                      (~locals[768] ^ locals[735]) & locals[811] ^
                      (locals[811] ^ locals[768] ^ locals[735]) & locals[676] ^ locals[735];
        locals[779] = (locals[810] ^ locals[301]) & 0x44444444;
        locals[812] = ~((~((~locals[721] ^ locals[813]) & locals[704]) ^ (~locals[704] ^ locals[813]) & locals[708] ^
                         ~locals[793] & locals[721] ^ locals[813]) & locals[805]) ^
                      (~(locals[708] & locals[813]) ^ locals[721] & locals[793]) & locals[704] ^ locals[708];
        locals[788] = ((locals[816] ^ 0x88888888) & locals[331] ^ locals[816] ^ 0x88888888) & locals[462] ^ 0x77777777;
        locals[787] = ~(~locals[301] & locals[810] & 0x44444444) ^ locals[301] & 0x44444444;
        locals[749] = ~((~locals[301] & 0xbbbbbbbb ^ locals[749]) & locals[810] & 0xcccccccc) ^
                      (locals[749] ^ 0xbbbbbbbb) & locals[301] & 0xcccccccc;
        locals[816] = ~locals[704] ^ locals[793];
        locals[301] =
            ~((~(locals[816] & locals[708]) ^ locals[816] & locals[805] ^ locals[704] ^ locals[793]) & locals[721]) ^
            locals[704] ^
            locals[805];
        locals[720] = locals[787] ^ locals[749];
        locals[793] = locals[720] >> 1;
        locals[704] = (~(locals[816] & locals[721]) ^ locals[704] ^ locals[813]) & locals[708] ^
                      (locals[816] & locals[721] ^ locals[704] ^ locals[813]) & locals[805] ^ locals[704];
    }
}