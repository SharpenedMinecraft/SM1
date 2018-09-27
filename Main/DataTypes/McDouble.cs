using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftDouble : MinecraftType<Double>
    {
        public MinecraftDouble(Stream stream) : base(stream)
        { }

        public override Double Read()
        {
            UInt64 v = new MinecraftULong(Stream).Read();
            Double value;
            unsafe
            {
                value = *(double*)&v;
            }
            return value;
        }

        public override void Write(Double value)
        {
            ulong v = 0;
            bool worked = false;
            unsafe
            {
                v = *(ulong*)&value;
                worked = true;
            }
            if (!worked)
                throw new Exception("UNSAFE FAILED");
            new MinecraftULong(Stream).Write(v);
        }
    }
}
