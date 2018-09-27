using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class LoginStartPacket : MinecraftPacket
    {
        public override State State => State.Login;
        public override bool Serverbound => true;
        public override int Id => 0x00;

        public string Name;

        public LoginStartPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            Name = Read<string>();

            int i = 1;
            while (World.Players.Any(x => x.Name == Name))
            {
                if (Client.Server.Configuration.OnlineMode)
                    throw new Exception("Player already present");
                else
                {
                    //TODO: Update
                    Name = Name + "_" + i;
                    var v = Name.Length - 16; //16 is the max Name Length
                    if (v > 0)
                        Name = Name.Remove(0, v);
                }
                i++;
            }
            Player.Name = Name;

            Client.Send(new LoginSuccessPacket(Client));

            //TODO: Re-enable Encryption
            //wrapper.QueueWrite(new EncryptionRequestPacket(wrapper));
        }
    }
}
