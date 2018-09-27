using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftUInt128 : MinecraftType<UInt128>
    {
        public MinecraftUInt128(Stream stream) : base(stream)
        {
        }

        public override UInt128 Read()
        {
            var l = new MinecraftULong(Stream);
            return new UInt128(l.Read(), l.Read());
        }

        public override void Write(UInt128 value)
        {
            var l = new MinecraftULong(Stream);
            l.WriteArray(new UInt64[] { value.hi, value.lo });
        }
    }

    public static class GUIDExtensions
    {
        public static UInt128 ToUInt128(this Guid g)
        {
            var array = g.ToByteArray();
            var hi = BitConverter.ToUInt64(array, 8);
            var lo = BitConverter.ToUInt64(array, 0);
            return new UInt128(hi, lo);
        }

        public static Guid ToGuid(this UInt128 i)
        {
            byte[] data = new byte[16];
            Array.Copy(BitConverter.GetBytes(i.hi), 0, data, 8, 8);
            Array.Copy(BitConverter.GetBytes(i.lo), 0, data, 0, 8);
            return new Guid(data);
        }
    }
}
