using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftBlockState : MinecraftType<Block>
    {
        public MinecraftBlockState(Stream stream) : base(stream)
        {
        }

        public override Block Read()
        {
            var v = new MinecraftVarInt(Stream).Read();
            var value = Block.GetBlock(v);
            return value;
        }

        public override void Write(Block value)
        {
            new MinecraftVarInt(Stream).Write(value.StateId);
        }
    }
}
