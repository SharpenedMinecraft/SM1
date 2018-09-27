using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class ChatMessagePacketClient : MinecraftPacket
    {
        public ChatMessagePacketClient(MinecraftClient client) : base(client)
        {
        }

        public override State State => State.Play;
        public override bool Clientbound => true; //Clientbound => true;
        public override int Id => 0x0E;

        public ChatMessage msg;
        public ChatPosition position;

        public override void WritePacket()
        {
            Write(msg);
            Write((byte)position);
        }
    }
}
