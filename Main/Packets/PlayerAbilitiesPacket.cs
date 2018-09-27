using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class PlayerAbilitiesPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x2D;

        Byte Flags;
        Single FlyingSpeed;
        Single FOVMod;

        public PlayerAbilitiesPacket(MinecraftClient client)
            : base(client)
        {
        }

        public override void Initialize(int length, Stream stream) 
        { 
            base.Initialize(length, stream);
            Flags = (byte)Player.Abilities.Flags;
            FlyingSpeed = Player.Abilities.FlyingSpeed;
            FOVMod = Player.Abilities.FOVMod;
        }

        public override void WritePacket()
        {
            Write(Flags);
            Write(FlyingSpeed);
            Write(FOVMod);
        }
    }
}
