using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftInt32 : MinecraftType<Int32>
    {
        public MinecraftInt32(Stream stream) : base(stream)
        { }

        public override Int32 Read()
        {
            return (Int32)new MinecraftUInt32(Stream).Read();
        }

        public override Int32[] ReadArray(int length)
        {
            return (Int32[])(Array)new MinecraftUInt32(Stream).ReadArray(length);
        }

        public override void Write(Int32 value)
        {
            new MinecraftUInt32(Stream).Write((UInt32)value);
        }

        public override void WriteArray(Int32[] value)
        {
            new MinecraftUInt32(Stream).WriteArray((UInt32[])(Array)value);
        }
    }
}
