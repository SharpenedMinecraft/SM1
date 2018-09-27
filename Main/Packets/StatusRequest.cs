using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class StatusRequest : MinecraftPacket
    {
        public override State State => State.Status;
        public override bool Serverbound => true;
        public override int Id => 0x00;

        public StatusRequest(MinecraftClient client) 
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            Client.Send(new StatusResponse(Client));
        }
    }
}
