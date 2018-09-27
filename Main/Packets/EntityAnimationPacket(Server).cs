using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class ArmAnimationPacketServer : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x1D;

        public ArmAnimationPacketServer(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var armUsed = (Hand)(int)Read<VarInt>();
            //TODO: Broadcast

            AnimationType type;
            if (armUsed == Hand.MainHand)
                type = AnimationType.SwingMainArm;
            else
                type = AnimationType.SwingOffhand;

            Client.SendToAll(new EntityAnimationPacketClient(Client)
            {
                EntityId = Player.EntityId,
                type = type
            }, x => ((MinecraftClient)x).Player != this.Client.Player);
        }
    }
}
