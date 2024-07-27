using System.Diagnostics;
using System.Runtime.InteropServices;
using HarpoS7.Monoliths.Data;

namespace HarpoS7.Monoliths.Transforms;

public static class Transform12
{
    public const int ContextSize = sizeof(uint) * 0x247;
    
    public static void Execute(Span<byte> context, int index, int count)
    {
        if (count == 0) return;

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
                    Transform9.Execute(dst, src, src2);
                    break;
                case 1:
                    Transform10.Execute(dst, src);
                    break;
                case 2:
                    Transform8.Execute(dst, src, src2);
                    break;
                default:
                    Transform11.Execute(dst, src, src2);
                    break;
            }
            
            Debug.WriteLine("I: " + i);
        }
        
        Debugger.Break();
    }
}