using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftVarInt : MinecraftType<VarInt>
    {
        public MinecraftVarInt(Stream stream) : base(stream)
        {
        }

        public override VarInt Read()
        {
            var MinecraftByte = new MinecraftByte(Stream);
            var v = 0;
            var size = 0;
            int b;
            while (((b = MinecraftByte.Read()) & 0x80) == 0x80)
            {
                if (b == -1)
                    throw new EndOfStreamException();

                v |= (b & 0x7F) << (size++ * 7);
                if (size > 5)
                {
                    throw new IOException("VarInt too long. Hehe that's punny.");
                }
            }
            var value = (v | ((b & 0x7F) << (size * 7)));
            return value;
        }

        public override void Write(VarInt value)
        {
            var MinecraftByte = new MinecraftByte(Stream);
            while ((value & -128) != 0)
            {
                MinecraftByte.Write((byte) (value & 127 | 128));
                value = (int) (((uint) value.value) >> 7);
            }

            MinecraftByte.Write((byte) value);
        }
    }
}
