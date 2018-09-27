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
    //http://wiki.vg/Protocol#Open_Window
    public class OpenWindowPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x14;

        public Window window;
        public byte WindowID;

        public OpenWindowPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void WritePacket()
        {
            Write(WindowID);
            Write(window.Type);
            Write(window.Title);
            Write(window.SlotCount);
            //TODO: Entity Horse
            //Entity ID 	Optional Int 	EntityHorse's EID. Only sent when Window Type is “EntityHorse” 
        }
    }
}
