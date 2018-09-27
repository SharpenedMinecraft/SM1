using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class ChatMessagePacketServer : MinecraftPacket
    {
        public ChatMessagePacketServer(MinecraftClient client) : base(client)
        {
        }

        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x01;
        public override void ReadPacket()
        {
            var msg = Read<string>();
            ChatManager.Process(msg, this.Client);
        }
    }
}
