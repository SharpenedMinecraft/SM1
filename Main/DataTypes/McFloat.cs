using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftFloat : MinecraftType<Single>
    {
        public MinecraftFloat(Stream stream) : base(stream)
        { }

        public override Single Read()
        {
            UInt32 v = new MinecraftUInt32(Stream).Read();
            unsafe
            {
                return *(float*)&v;
            }
        }

        public override void Write(Single value)
        {
            UInt32 v = 0;
            bool worked = false;
            unsafe
            {
                v = *(uint*)&value;
                worked = true;
            }
            if (!worked)
                throw new Exception("UNSAFE FAILED");
            new MinecraftUInt32(Stream).Write(v);
        }
    }
}
