using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftBoolean : MinecraftType<Boolean>
    {
        public MinecraftBoolean(Stream stream) : base(stream)
        {
        }

        public override Boolean Read()
        {
            var v = new MinecraftByte(Stream).Read() != 0;
            return v;
        }

        public override void Write(Boolean value)
        {
            new MinecraftByte(Stream).Write(value ? (byte)1 : (byte)0);
        }
    }
}
