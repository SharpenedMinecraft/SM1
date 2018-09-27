using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class DisconnectPlayPaket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x1B;

        //TODO: Support for Actual McMessage

        public ChatMessage Reason;

        public DisconnectPlayPaket(MinecraftClient client)
            : base(client)
        {

        }

        public override void Initialize(int length, Stream stream)
        {
            base.Initialize(length, stream);
        }

        public override void WritePacket()
        {
            Write(Reason.ToJson());
            Client.Close();
        }
    }
}
