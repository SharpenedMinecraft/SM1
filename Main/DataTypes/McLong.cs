using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftLong : MinecraftType<Int64>
    {
        public MinecraftLong(Stream stream) : base(stream)
        { }

        public override Int64 Read()
        {
            return (Int64)new MinecraftULong(Stream).Read();
        }

        public override Int64[] ReadArray(int length)
        {
            return (Int64[])(Array)new MinecraftULong(Stream).ReadArray(length);
        }

        public override void Write(Int64 value)
        {
            new MinecraftULong(Stream).Write((UInt64)value);
        }

        public override void WriteArray(Int64[] value)
        {
            new MinecraftULong(Stream).WriteArray((UInt64[])(Array)value);
        }
    }
}
