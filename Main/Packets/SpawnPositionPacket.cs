using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class SpawnPositionPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x48;

        public Vector3 Position;

        public SpawnPositionPacket(MinecraftClient client)
            : base(client)
        {
        }

        public override void WritePacket()
        {
            Position = Player.SpawnPosition;

            Write(Position);
        }
    }
}
