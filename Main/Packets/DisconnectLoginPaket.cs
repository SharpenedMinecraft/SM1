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
   public class DisconnectLoginPaket : MinecraftPacket
    {
        public override State State => State.Login;
        public override bool Clientbound => true;
        public override int Id => 0x00;

        //TODO: Support for Actual McMessage

        public ChatMessage Reason;

        public DisconnectLoginPaket(MinecraftClient client)
            : base(client)
        {

        }

        public override void WritePacket()
        {
            Write(Reason.ToString());
            Client.Close();
        }
    }
}
