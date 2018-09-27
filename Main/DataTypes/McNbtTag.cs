using fNbt;
using fNbt.Tags;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftNbtCompound : MinecraftType<NbtCompound>
    {
        public MinecraftNbtCompound(Stream stream) : base(stream)
        {
        }

        public override NbtCompound Read()
        {
            var v = new NbtFile();
            v.LoadFromStream(Stream, NbtCompression.None);
            return v.RootTag;
        }

        public override void Write(NbtCompound value)
        {
            var serverFile = new NbtFile(value);
            serverFile.SaveToStream(Stream, NbtCompression.None);
        }
    }
}
