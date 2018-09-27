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
    public class TeleportConfirmPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x00;

        public TeleportConfirmPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var id = (int)Read<VarInt>();
            if (!Client.TeleportManager.EndTeleport(id))
                Client.SendToAll(new DisconnectPlayPaket(Client)
                {
                    Reason = new ChatMessage()
                    {
                        Text = "Invalid Movement!"
                    }
                }, x => ((MinecraftClient)x).Player != this.Client.Player);
        }
    }
}
