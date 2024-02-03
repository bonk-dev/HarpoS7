// ReSharper disable UseCollectionExpression

namespace HarpoS7.Fingerprint;

public static class ContextMutator
{
    private delegate void MutateBigContext(Span<uint> dataArray);

    private static readonly MutateBigContext[] MutateFunctions = new MutateBigContext[FingerprintConsts.NumberOfMutations]
    {
        Mutate1,
        Mutate2,
        Mutate3,
        Mutate4,
        Mutate5,
        Mutate6,
        Mutate7,
        Mutate8,
        Mutate9,
        Mutate10,
        Mutate11,
        Mutate12,
        Mutate13,
        Mutate14,
        Mutate15,
        Mutate16,
        Mutate17,
        Mutate18,
        Mutate19,
        Mutate20
    };

    public static void Mutate(Span<uint> bigContext, int mutationIndex) =>
        MutateFunctions[mutationIndex](bigContext);

    private static void Mutate1(Span<uint> dataArray)
    {
        dataArray[0] *= 0xc551c475;
        dataArray[4] += 0x5a3ce23f;
        dataArray[6] += 0x24c4b704;
        dataArray[9] *= 0x3a348c87;
        dataArray[10] ^= 0xe8a0d051;
        dataArray[12] ^= 0xb0a18ddc;
        dataArray[15] += 0xe6cfff9;
        dataArray[16] += 0x290941f5;
        dataArray[17] ^= 0xe05c9e67;
        dataArray[18] += 0x8d991cbf;
        dataArray[20] += 0x7c651375;
        dataArray[23] += 0x3dbca07;
        dataArray[26] ^= 0x38654993;
        dataArray[27] ^= 0x4ab799fd;
        dataArray[31] += 0x55b9f61a;
        dataArray[40] ^= 0xc9b436d8;
        dataArray[44] += 0x539ae883;
        dataArray[46] += 0x18176ebd;
    }

    private static void Mutate2(Span<uint> dataArray)
    {
        dataArray[0] *= 0x42967e37;
        dataArray[1] += 0x51968185;
        dataArray[5] += 0x987ed03c;
        dataArray[6] += 0x1f11f5fa;
        dataArray[7] += 0xe322c228;
        dataArray[8] *= 0x1f78887f;
        dataArray[13] += 0xa7a09105;
        dataArray[29] += 0x9cc748b8;
        dataArray[30] *= 0x89f16b7d;
        dataArray[32] ^= 0xe06c99e3;
        dataArray[37] += 0xc4655338;
        dataArray[40] ^= 0x8caa3547;
    }

    private static void Mutate3(Span<uint> dataArray)
    {
        dataArray[3] *= 0x28962a69;
        dataArray[5] += 0xa9bd33ba;
        dataArray[8] *= 0xebcb47b;
        dataArray[12] += 0x3ea5db4e;
        dataArray[14] *= 0xc7836217;
        dataArray[15] ^= 0xb994eece;
        dataArray[17] += 0x1736bce;
        dataArray[20] *= 0xc82a970f;
        dataArray[36] += 0xe64656cb;
        dataArray[37] ^= 0xde5d4ceb;
        dataArray[38] += 0x66a89813;
        dataArray[42] += 0x4cc9a7ec;
        dataArray[43] += 0x450604bb;
        dataArray[46] += 0x510d007b;
    }

    private static void Mutate4(Span<uint> dataArray)
    {
        dataArray[1] ^= 0xacce30dd;
        dataArray[4] += 0xa1b8d9eb;
        dataArray[12] ^= 0x899e18a;
        dataArray[15] ^= 0xf2890304;
        dataArray[16] ^= 0xe06f5d78;
        dataArray[18] += 0xd3e03b9f;
        dataArray[20] += 0x9ab2e0a8;
        dataArray[27] += 0xad1b4532;
        dataArray[30] ^= 0x8458e921;
        dataArray[31] ^= 0xeffde864;
        dataArray[33] ^= 0xe173b52a;
        dataArray[36] += 0x8631899d;
        dataArray[38] += 0xf3d7a161;
        dataArray[40] *= 0x8185c265;
        dataArray[43] *= 0x869534ef;
    }

    private static void Mutate5(Span<uint> dataArray)
    {
        dataArray[2] += 0xaec2762b;
        dataArray[3] ^= 0x8f628ac4;
        dataArray[4] += 0xdcae806;
        dataArray[6] *= 0x99dd5fb7;
        dataArray[7] += 0x9efd7a1e;
        dataArray[9] ^= 0x985a979b;
        dataArray[13] *= 0xa57c5335;
        dataArray[18] *= 0x9bb85be1;
        dataArray[21] *= 0x51eed407;
        dataArray[22] ^= 0x762677c9;
        dataArray[24] += 0x43d29837;
        dataArray[25] += 0xa06c7b4d;
        dataArray[31] ^= 0xee07aeab;
        dataArray[34] += 0x5fb317b3;
        dataArray[36] *= 0x9c94abcb;
        dataArray[37] += 0x8436db72;
        dataArray[41] *= 0x422e5985;
        dataArray[42] += 0x83e8e090;
        dataArray[43] += 0xac28b6f2;
        dataArray[44] += 0xbad34267;
        dataArray[45] *= 0x93ca228b;
    }


    private static void Mutate10(Span<uint> dataArray)
    {
        dataArray[1] += 0xbac6d922;
        dataArray[2] += 0x4f3eb80e;
        dataArray[8] *= 0x3d38a553;
        dataArray[12] ^= 0x2f12fe36;
        dataArray[15] *= 0x98a8c771;
        dataArray[17] *= 0x16e0e36d;
        dataArray[24] ^= 0x23863b4b;
        dataArray[34] ^= 0x4d9a383a;
        dataArray[39] *= 0x7c7ca07;
        dataArray[44] *= 0xe762c8b7;
    }

    private static void Mutate8(Span<uint> dataArray)
    {
        dataArray[2] *= 0x7f5dcaeb;
        dataArray[3] += 0x48551c90;
        dataArray[5] ^= 0xec4da17f;
        dataArray[7] *= 0x108ab211;
        dataArray[11] ^= 0xa31e7550;
        dataArray[16] *= 0xd4b3fe61;
        dataArray[20] ^= 0xd7d9db1b;
        dataArray[25] += 0x78ced8f6;
        dataArray[36] += 0x37b8ab4e;
        dataArray[39] += 0x8da7607e;
        dataArray[41] += 0xda5739f1;
        dataArray[42] *= 0xb80ac61f;
        dataArray[45] += 0x176a83;
    }

    private static void Mutate14(Span<uint> dataArray)
    {
        dataArray[3] ^= 0xff1bdc56;
        dataArray[8] *= 0x30d4727b;
        dataArray[17] += 0x7f84bc7a;
        dataArray[19] *= 0x7590335b;
        dataArray[20] ^= 0x9b55acce;
        dataArray[22] *= 0x73b2b0b5;
        dataArray[26] ^= 0xc8fdd43e;
        dataArray[27] += 0x508e8ca3;
        dataArray[29] *= 0x820e132b;
        dataArray[32] ^= 0x4f7b68a9;
        dataArray[36] *= 0x5562795;
        dataArray[37] += 0xc42a172a;
    }

    private static void Mutate13(Span<uint> dataArray)
    {
        dataArray[7] ^= 0xcab24c13;
        dataArray[9] *= 0xe98993f1;
        dataArray[10] *= 0x805f3a53;
        dataArray[15] *= 0x9b98f86b;
        dataArray[22] *= 0x331f82e5;
        dataArray[24] += 0xbcd03b;
        dataArray[31] += 0x542f80c4;
        dataArray[39] += 0x661e2392;
        dataArray[41] += 0xc024e796;
        dataArray[42] ^= 0x4b8dda5c;
        dataArray[44] ^= 0x79a70b58;
    }

    private static void Mutate18(Span<uint> dataArray)
    {
        dataArray[3] += 0x255c11cd;
        dataArray[11] += 0xd49d8af9;
        dataArray[20] += 0x88f4384b;
        dataArray[22] ^= 0x6b92f5ea;
        dataArray[38] *= 0x28ed43eb;
    }

    private static void Mutate20(Span<uint> dataArray)
    {
        dataArray[25] += 0xfb33f767;
        dataArray[40] *= 0x1c24a56d;
        dataArray[41] += 0xf7be7f36;
    }

    private static void Mutate11(Span<uint> dataArray)
    {
        dataArray[6] *= 0xe36e6e11;
        dataArray[7] += 0xbd46ad3d;
        dataArray[8] += 0xae67e446;
        dataArray[11] += 0x649489d6;
        dataArray[12] += 0xf2cf4001;
        dataArray[13] ^= 0x54feb45b;
        dataArray[14] += 0x504905a8;
        dataArray[16] *= 0x82294465;
        dataArray[17] += 0x218fa5a7;
        dataArray[19] *= 0x48d23bf;
        dataArray[20] += 0xf1dda6aa;
        dataArray[22] ^= 0x1651d393;
        dataArray[23] += 0xef93cb7a;
        dataArray[24] ^= 0xc72bb8d5;
        dataArray[29] *= 0x87dcb6df;
        dataArray[32] += 0x9c566923;
        dataArray[33] ^= 0x7222e139;
        dataArray[34] ^= 0xdbca324a;
        dataArray[35] *= 0x2fbc1e63;
        dataArray[40] += 0x880a7ddb;
        dataArray[42] += 0x90b382a5;
        dataArray[43] += 0xaf4e8b44;
        dataArray[44] *= 0x5022c641;
    }

    private static void Mutate12(Span<uint> dataArray)
    {
        dataArray[0] += 0xda6370be;
        dataArray[2] += 0xc557634e;
        dataArray[3] += 0x4277fc49;
        dataArray[6] ^= 0xa0e17060;
        dataArray[7] *= 0x847aba01;
        dataArray[8] += 0x19502f85;
        dataArray[10] ^= 0xbbc8dd06;
        dataArray[12] += 0xced1478d;
        dataArray[15] ^= 0x33944292;
        dataArray[16] ^= 0x10e66836;
        dataArray[18] += 0xa2633508;
        dataArray[23] += 0x1ccc6e2f;
        dataArray[25] += 0x7d6d08c6;
        dataArray[29] *= 0xb74ed70b;
        dataArray[31] ^= 0x97101dd5;
        dataArray[38] *= 0xdd8e20cd;
        dataArray[39] += 0xc51edee2;
        dataArray[42] += 0xeb848ed1;
        dataArray[43] += 0x3971d228;
        dataArray[45] *= 0xe37d7ea5;
    }

    private static void Mutate17(Span<uint> dataArray)
    {
        dataArray[0] *= 0xe542db5;
        dataArray[1] += 0x5fc4b478;
        dataArray[2] += 0x5e5df058;
        dataArray[10] ^= 0x23610aed;
        dataArray[11] ^= 0x20aadfc9;
        dataArray[13] *= 0xedbea43d;
        dataArray[14] *= 0x47177a53;
        dataArray[16] += 0x2e1f5486;
        dataArray[18] += 0x4751dd49;
        dataArray[19] *= 0xfb7e1873;
        dataArray[21] ^= 0x50156d2;
        dataArray[22] ^= 0xdfee2293;
        dataArray[23] *= 0x72d95c07;
        dataArray[24] += 0x6e0c0764;
        dataArray[30] += 0x4ab7f490;
        dataArray[32] += 0x76fbafb4;
        dataArray[40] *= 0x75d2f32d;
        dataArray[43] += 0x690cc85b;
        dataArray[45] ^= 0x3b5a7279;
    }

    private static void Mutate9(Span<uint> dataArray)
    {
        dataArray[3] += 0xfcd609fb;
        dataArray[7] *= 0x563c6de9;
        dataArray[8] += 0xab03e852;
        dataArray[13] *= 0x7ef6de9f;
        dataArray[15] ^= 0x448a5337;
        dataArray[17] ^= 0x5d09c044;
        dataArray[18] += 0x124523a2;
        dataArray[19] *= 0xf8c41d8b;
        dataArray[20] ^= 0xb9588423;
        dataArray[21] += 0x2f37c09b;
        dataArray[24] *= 0x581b4667;
        dataArray[27] *= 0xe03a3491;
        dataArray[32] += 0xc9a9fa6d;
        dataArray[35] += 0x964f3892;
        dataArray[39] *= 0x5eb2acfb;
        dataArray[41] ^= 0xdc31b541;
        dataArray[46] ^= 0xada59cd3;
    }

    private static void Mutate19(Span<uint> dataArray)
    {
        dataArray[1] *= 0x55101d7b;
        dataArray[5] ^= 0x258f3aad;
        dataArray[7] *= 0xb93d2bf9;
        dataArray[8] *= 0xa2222463;
        dataArray[12] += 0x2fa5ea81;
        dataArray[17] ^= 0x9dac5020;
        dataArray[20] *= 0xde7f9a9d;
        dataArray[28] ^= 0xf96422ac;
        dataArray[29] += 0xb9743074;
        dataArray[33] ^= 0x5d85ce6a;
        dataArray[34] *= 0x25c082b7;
        dataArray[35] += 0x3787ea;
        dataArray[38] ^= 0x95706820;
        dataArray[40] += 0xd5fb07ae;
        dataArray[43] += 0x171f451c;
        dataArray[44] ^= 0x9b8854e9;
        dataArray[45] ^= 0xbb2909cb;
    }

    private static void Mutate15(Span<uint> dataArray)
    {
        dataArray[0] += 0xe98b9f1e;
        dataArray[2] += 0x380af9b2;
        dataArray[3] *= 0x3c706b0d;
        dataArray[5] *= 0x6e29a923;
        dataArray[7] += 0x7d2ae218;
        dataArray[8] ^= 0x4a3fc9a9;
        dataArray[9] ^= 0xa7e5999d;
        dataArray[10] += 0xcfc42df5;
        dataArray[12] ^= 0x33055b2f;
        dataArray[16] *= 0x79787ceb;
        dataArray[19] += 0xcdfcf95e;
        dataArray[20] *= 0x3f2358e7;
        dataArray[21] ^= 0x527a1642;
        dataArray[24] += 0x1ccc6d9d;
        dataArray[25] += 0xdfa010a0;
        dataArray[26] += 0x98e4473c;
        dataArray[29] += 0xefd8678b;
        dataArray[30] ^= 0xadee92e3;
        dataArray[33] *= 0x68e6f119;
        dataArray[36] *= 0x6669b03d;
        dataArray[38] ^= 0xd3d66255;
        dataArray[44] ^= 0xbfc7fd97;
    }

    private static void Mutate16(Span<uint> dataArray)
    {
        dataArray[8] += 0x10af2eb4;
        dataArray[9] += 0xaa07ed58;
        dataArray[13] += 0xefdff81a;
        dataArray[21] += 0xb14c4ba3;
        dataArray[37] += 0x3c3a86f;
        dataArray[38] += 0x47c594c0;
        dataArray[39] += 0xac726e4a;
        dataArray[41] += 0x5b830a4b;
    }

    private static void Mutate6(Span<uint> dataArray)
    {
        dataArray[3] *= 0xf2602dff;
        dataArray[11] *= 0x2eb0cc29;
        dataArray[12] ^= 0x2dfcdd09;
        dataArray[15] += 0xb90dbb9d;
        dataArray[30] += 0x8bfc6993;
        dataArray[32] += 0x314d8e10;
        dataArray[36] += 0x50249de8;
        dataArray[40] ^= 0x6d86bf1;
        dataArray[41] ^= 0x8e2afc03;
    }

    private static void Mutate7(Span<uint> dataArray)
    {
        dataArray[0] *= 0x3c552a65;
        dataArray[2] += 0x36bae71b;
        dataArray[3] += 0xc99b2a5b;
        dataArray[4] += 0xcbc82579;
        dataArray[7] ^= 0x99021301;
        dataArray[8] += 0x3454ec1e;
        dataArray[14] *= 0xf69c620f;
        dataArray[15] += 0xcf234534;
        dataArray[16] *= 0xe736daa3;
        dataArray[17] ^= 0xd7a7b0c9;
        dataArray[21] ^= 0xe0eab46c;
        dataArray[22] += 0x139456c1;
        dataArray[23] += 0x3ad80336;
        dataArray[25] += 0x6808cd02;
        dataArray[31] += 0x78af3be2;
        dataArray[33] *= 0x2bd84531;
        dataArray[35] ^= 0x29e03f10;
        dataArray[36] *= 0x44987057;
        dataArray[39] *= 0x7ec01c3b;
        dataArray[40] *= 0x14d02fa9;
        dataArray[41] += 0xe1dfc285;
        dataArray[43] ^= 0x998f9764;
    }
}