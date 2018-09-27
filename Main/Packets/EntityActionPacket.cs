using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class EntityActionPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x15;

        public EntityActionPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var EntityID = Read<VarInt>();
            var ActionId = Read<VarInt>();
            //This is used if Action Is Horse Jump, else its 0!
            var JumpBoost = Read<VarInt>();

            var entity = World.WorldEntities.First(x => x.EntityId == EntityID);
            //TODO: Process these Actions
            switch (ActionId)
            {
                case 0:
                    if (!entity.Effects.HasFlag(EntityEffect.Crouched))
                        entity.Effects |= EntityEffect.Crouched;
                    break;
                case 1:
                    if (entity.Effects.HasFlag(EntityEffect.Crouched))
                        entity.Effects &= EntityEffect.Crouched;
                    break;
                case 2:
                    //Leave Bed
                    break;
                case 3:
                    if (!entity.Effects.HasFlag(EntityEffect.Sprinting))
                        entity.Effects |= EntityEffect.Sprinting;
                    break;
                case 4:
                    if (entity.Effects.HasFlag(EntityEffect.Sprinting))
                        entity.Effects &= EntityEffect.Sprinting;
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:
                    if (!entity.Effects.HasFlag(EntityEffect.FlyingElytra))
                        entity.Effects |= EntityEffect.FlyingElytra;
                    break;
            }
        }
    }
}
