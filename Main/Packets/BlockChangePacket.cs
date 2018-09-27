using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class BlockChangePacket : MinecraftPacket
    {
        public BlockChangePacket(MinecraftClient client) : base(client)
        {
        }

        public override State State => State.Play;
        public override bool Clientbound => true; //Clientbound => true;
        public override int Id => 0x0B;

        public Vector3 Position;
        public Block newblock;

        public override void WritePacket()
        {
            Write(Position);
            Write(newblock);
        }
    }
}
