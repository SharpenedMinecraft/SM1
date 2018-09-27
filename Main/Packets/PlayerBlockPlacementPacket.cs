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
    public class PlayerBlockPlacementPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x1F;

        public PlayerBlockPlacementPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var location = Read<Vector3>();
            var face = (Face)(int)Read<VarInt>();
            var HandUse = (Hand)(int)Read<VarInt>();

            //TODO: Calculation for slabs and such
            //http://wiki.vg/Protocol#Player_Block_Placement
            //In-block Coords
            var CursorPositionX = Read<Single>();
            var CursorPositionY = Read<Single>();
            var CursorPositionZ = Read<Single>();

            switch (face)
            {
                case Face.NegativeXWest:
                    location.X--;
                    break;
                case Face.NegativeYBottom:
                    location.Y--;
                    break;
                case Face.NegativeZNorth:
                    location.Z--;
                    break;
                case Face.PositiveXEast:
                    location.X++;
                    break;
                case Face.PositiveYTop:
                    location.Y++;
                    break;
                case Face.PositiveZSouth:
                    location.Z++;
                    break;
            }


            Player.Inventory.Selected.OnUse(this.World, location, Player);

            if (Player.GameMode != GameMode.Creative)
                Player.Inventory.Selected.ItemCount--;
        }
    }
}
