using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftSByte : MinecraftType<SByte>
    {
        public MinecraftSByte(Stream stream) : base(stream)
        { }

        public override SByte Read()
        {
            return (sbyte)new MinecraftByte(Stream).Read();
        }

        public override SByte[] ReadArray(int length)
        {
            return (sbyte[])(Array)new MinecraftByte(Stream).ReadArray(length);
        }

        public override void Write(SByte value)
        {
            new MinecraftByte(Stream).Write((Byte)value);
        }

        public override void WriteArray(SByte[] value)
        {
            Stream.Write((Byte[])(Array)value, 0, value.Length);
        }
    }
}
