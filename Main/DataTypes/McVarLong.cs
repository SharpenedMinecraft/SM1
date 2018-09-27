using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftVarLong : MinecraftType<VarLong>
    {
        public MinecraftVarLong(Stream stream) : base(stream)
        {
        }

        public override VarLong Read()
        {
            var v = 0;
            var size = 0;
            int b;
            while (((b = Stream.ReadByte()) & 0x80) == 0x80)
            {
                if (b == -1)
                    throw new EndOfStreamException();

                v |= (b & 0x7F) << (size++ * 7);
                if (size > 10)
                {
                    throw new IOException("VarLong too long. That's what she said.");
                }
            }
            var value = (v | ((b & 0x7F) << (size * 7)));
            return value;
        }

        public override void Write(VarLong value)
        {
            Int64 i = value;
            do
            {
                byte temp = (byte)(i & 0x7F);
                i = (long)((ulong)i >> 7);
                if (i != 0)
                    temp |= 0x80;
                Stream.WriteByte(temp);
            }
            while (i != 0);
            /*while ((i & ~0x7F) != 0)
            {
                Stream.WriteByte((Byte)((i & 0x7F) | 0x80));
                i >>= 7;
            }
            Stream.WriteByte((Byte)i);*/
        }
    }
}
