using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class PongPaket : MinecraftPacket
    {
        public override State State => State.Status;
        public override bool Clientbound => true;
        public override int Id => 0x01;

        public long Payload;

        public PongPaket(MinecraftClient client)
            : base(client)
        {
        }


        public override void WritePacket()
        {
            Write(Payload);
            Client.Close();
        }
    }
}
