using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftPosition : MinecraftType<Vector3>
    {
        public MinecraftPosition(Stream stream) : base(stream)
        { }

        public override Vector3 Read()
        {
            var v = new MinecraftLong(Stream).Read();
            var x = v >> 38;
            var y = (v >> 26) & 0xFFF;
            var z = v << 38 >> 38;
            return new Vector3((long)x, (long)y, (long)z);
        }

        public override void Write(Vector3 value)
        {
            new MinecraftLong(Stream).Write((
                 (((long)value.X & 0x3FFFFFF) << 38)
                 | (((long)value.Y & 0xFFF) << 26)
                 | ((long)value.Z & 0x3FFFFFF)));
        }
    }
}
