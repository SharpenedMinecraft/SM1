using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftUShort : MinecraftType<UInt16>
    {
        public MinecraftUShort(Stream stream) : base(stream)
        {
        }

        public override UInt16 Read()
        {
            var MinecraftByte = new MinecraftByte(Stream);
            var value = (ushort)(
                (MinecraftByte.Read() << 8) |
                MinecraftByte.Read());
            return value;
        }

        public override void Write(UInt16 value)
        {
            this.Stream.Write(new[]
            {
                    (byte)((value & 0xFF00) >> 8),
                    (byte)(value & 0xFF)
                }, 0, 2);
        }
    }
}
