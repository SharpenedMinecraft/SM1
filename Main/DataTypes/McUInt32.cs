using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftUInt32 : MinecraftType<UInt32>
    {
        public MinecraftUInt32(Stream stream) : base(stream)
        {
        }

        public override UInt32 Read()
        {
            var Uint8 = new MinecraftByte(Stream);
            var value = (UInt32)(
            (Uint8.Read() << 24) |
            (Uint8.Read() << 16) |
            (Uint8.Read() << 8) |
            Uint8.Read());
            return value;
        }

        public override void Write(UInt32 value)
        {
            this.Stream.Write(new[]
            {
                    (byte)((value & 0xFF000000) >> 24),
                    (byte)((value & 0xFF0000) >> 16),
                    (byte)((value & 0xFF00) >> 8),
                    (byte)(value & 0xFF)
            }, 0, 4);
        }
    }
}
