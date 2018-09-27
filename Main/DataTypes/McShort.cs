using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftShort : MinecraftType<Int16>
    {
        public MinecraftShort(Stream stream) : base(stream)
        { }

        public override Int16 Read()
        {
            return (Int16)new MinecraftUShort(Stream).Read();
        }

        public override Int16[] ReadArray(int length)
        {
            return (Int16[])(Array)new MinecraftUShort(Stream).ReadArray(length);
        }

        public override void Write(Int16 value)
        {
            new MinecraftUShort(Stream).Write((UInt16)value);
        }

        public override void WriteArray(Int16[] value)
        {
            new MinecraftUShort(Stream).WriteArray((UInt16[])(Array)value);
        }
    }
}
