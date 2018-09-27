using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class ServerDifficultyPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x0D;

        public Difficulty Difficulty;

        public ServerDifficultyPacket(MinecraftClient client)
            : base(client)
        {
        }

        public override void Initialize(int length, Stream stream) 
        { 
            base.Initialize(length, stream);
            Difficulty = World.Difficulty;
        }

        public override void WritePacket()
        {
            Write((Byte)Difficulty);
        }
    }
}
