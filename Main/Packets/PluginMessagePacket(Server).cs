using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class PluginMessagePacketServer : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x09;

        public string Channel;

        public PluginMessagePacketServer(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            Channel = Read<String>();
            

            //TODO: Implement Plugin Channels
        }
    }
}
