using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftByte : MinecraftType<Byte>
    {
        public MinecraftByte(Stream stream) : base(stream)
        {
        }

        public override Byte Read()
        {
            int value = Stream.ReadByte();
            if (value == -1)
                throw new EndOfStreamException();
            return (byte)value;
        }

        public override Byte[] ReadArray(int length)
        {
            var result = new Byte[length];
            if (length == 0) return result;
            int n = length;
            while (true)
            {
                n -= Stream.Read(result, length - n, n);
                if (n == 0)
                    break;
            }
            return result;
        }

        public override void Write(Byte value)
        {
            Stream.WriteByte(value);
        }

        public override void WriteArray(Byte[] value)
        {
            Stream.Write(value, 0, value.Length);
        }
    }
}
