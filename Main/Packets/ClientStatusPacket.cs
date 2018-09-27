using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class ClientStatusPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x02;

        public Int32 ActionID;

        public ClientStatusPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            ActionID = Read<int>();
            //TODO: Queue Packets here!
            if (ActionID == 0)
            {
                //Perform Respawn
            }
            else if (ActionID == 1)
            {
                //Request Stats
            }
            else
                throw new Exception("Read Error i guess?");
        }
    }
}
