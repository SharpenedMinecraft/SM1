using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftULong : MinecraftType<UInt64>
    {
        public MinecraftULong(Stream stream) : base(stream)
        {
        }

        public override UInt64 Read()
        {
            var UInt8 = new MinecraftByte(Stream);
            var v1 = (ulong)UInt8.Read();
            var v2 = (ulong)UInt8.Read();
            var v3 = (ulong)UInt8.Read();
            var v4 = (ulong)UInt8.Read();
            var v5 = (ulong)UInt8.Read();
            var v6 = (ulong)UInt8.Read();
            var v7 = (ulong)UInt8.Read();
            var v8 = (ulong)UInt8.Read();
            var value = unchecked(
                (v1 << 56) |
                (v2 << 48) |
                (v3 << 40) |
                (v4 << 32) |
                (v5 << 24) |
                (v6 << 16) |
                (v7 << 8) |
                (v8));
            return value;
        }

        public override void Write(UInt64 value)
        {
            this.Stream.Write(new[]
            {
                    (byte)((value & 0xFF00000000000000) >> 56),
                    (byte)((value & 0xFF000000000000) >> 48),
                    (byte)((value & 0xFF0000000000) >> 40),
                    (byte)((value & 0xFF00000000) >> 32),
                    (byte)((value & 0xFF000000) >> 24),
                    (byte)((value & 0xFF0000) >> 16),
                    (byte)((value & 0xFF00) >> 8),
                    (byte)(value & 0xFF)
                }, 0, 8);
        }
    }
}
