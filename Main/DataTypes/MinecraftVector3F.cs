using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftVector3F : MinecraftType<Vector3F>
    {
        public MinecraftVector3F(Stream stream) : base(stream)
        {
        }

        public override Vector3F Read()
        {
            var mcfloat = new MinecraftFloat(Stream);
            return new Vector3F(mcfloat.Read(), mcfloat.Read(), mcfloat.Read());
        }

        public override void Write(Vector3F value)
        {
            var mcfloat = new MinecraftFloat(Stream);
            mcfloat.Write(value.X);
            mcfloat.Write(value.Y);
            mcfloat.Write(value.Z);
        }
    }
}
