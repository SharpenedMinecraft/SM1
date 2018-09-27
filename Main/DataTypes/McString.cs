using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftString : MinecraftType<String>
    {
        public MinecraftString(Stream stream) : base(stream)
        {
        }

        public override String Read()
        {
            Int32 length = new MinecraftVarInt(Stream).Read();
            if (length == 0) return string.Empty;
            var data = new MinecraftByte(Stream).ReadArray(length);
            var value = Encoding.UTF8.GetString(data);
            return value;
        }

        public override void Write(String value)
        {
            var b = Encoding.UTF8.GetBytes(value);
            new MinecraftVarInt(Stream).Write(b.Length);
            if (value.Length > 0)
                new MinecraftByte(Stream).WriteArray(b);
        }
    }
}
