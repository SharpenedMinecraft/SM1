using SharpenedMinecraft.DataTypes;
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
    public class PlayerDiggingPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x14;

        public PlayerDiggingPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var i = (int)Read<VarInt>();
            var pos = Read<Vector3>();
            var i2 = Read<byte>();

            var Status = (DiggingStatus)i;
            var face = (Face)i2;

            switch (Status)
            {
                case DiggingStatus.FinishedDigging:
                    World.SetBlock(pos, Block.Air, Player);
                    if (Player.GameMode != GameMode.Creative)
                    {
                        //TODO: Drop item
                    }
                    break;
                case DiggingStatus.StartedDigging:
                    if (Player.GameMode == GameMode.Creative)
                    {
                        World.SetBlock(pos, Block.Air, Player);
                    }
                    break;
                default:

                    break;
            }

            if (Status == DiggingStatus.FinishedDigging)
            {
                World.SetBlock(pos, Block.Air, Player);
            }
            else if (Status == DiggingStatus.StartedDigging)
            {


            }
        }
    }
}
