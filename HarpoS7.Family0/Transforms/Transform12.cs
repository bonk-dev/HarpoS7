using System.Runtime.InteropServices;
using HarpoS7.Family0.Data;
using HarpoS7.Family0.Exceptions;

namespace HarpoS7.Family0.Transforms;

public static class Transform12
{
    public const int ContextSize = sizeof(uint) * 894;
    
    public static void Execute(Span<byte> context, int index, int count)
    {
        if (count == 0) return;

        if (context.Length < ContextSize)
        {
            throw new BufferLengthException(
                nameof(context), false, ContextSize, context.Length);
        }

        var metadata = MemoryMarshal.Cast<byte, uint>(BlobReader.Transform12Metadata.Span);
        
        for (var i = 0; i < count; ++i)
        {
            var metadataDword = metadata[index + i];
            
            var dstIndex = (int)(metadataDword >> 0x16 & 0xFF) * 6 * sizeof(uint);
            var dst = context[dstIndex..];
            
            var intermediateIndex = metadataDword >> 0xB & 0x3FF;
            var src = intermediateIndex < 0x100
                ? context[(int)(intermediateIndex * 6 * sizeof(uint))..]
                : Transform12Data.BigIntData.Span[(int)((intermediateIndex - 0x100) * 6 * sizeof(uint))..];
            
            intermediateIndex = metadataDword & 0x3FF;
            var src2 = intermediateIndex < 0x100
                ? context[(int)(intermediateIndex * 6 * sizeof(uint))..]
                : Transform12Data.BigIntData.Span[(int)((intermediateIndex - 0x100) * 6 * sizeof(uint))..];
            
            metadataDword >>= 0x1E;
            switch (metadataDword)
            {
                case 0:
                    BigIntMultiplication.Execute(dst, src, src2);
                    break;
                case 1:
                    BigIntSquare.Execute(dst, src);
                    break;
                case 2:
                    BigIntAddition.Execute(dst, src, src2);
                    break;
                default:
                    BigIntSubtraction.Execute(dst, src, src2);
                    break;
            }
        }
    }
}