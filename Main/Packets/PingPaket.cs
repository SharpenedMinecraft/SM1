using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class PingPaket : MinecraftPacket
    {
        public override State State => State.Status;
        public override bool Serverbound => true;
        public override int Id => 0x01;

        public long Payload;

        public PingPaket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var v = Read<Int64>();
            Client.Send(new PongPaket(Client)
            {
                Payload = v
            });
        }
    }
}
