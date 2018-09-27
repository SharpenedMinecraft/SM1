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
    public class MinecraftRotation : MinecraftType<Rotation>
    {
        public MinecraftRotation(Stream stream) : base(stream)
        { }

        public override Rotation Read()
        {
            var v = new MinecraftFloat(Stream);
            return new Rotation(v.Read(), v.Read(), v.Read());
        }

        public override void Write(Rotation value)
        {
            var v = new MinecraftFloat(Stream);
            v.Write(value.Yaw);
            v.Write(value.Pitch);
            v.Write(value.Roll);
        }
    }
}
