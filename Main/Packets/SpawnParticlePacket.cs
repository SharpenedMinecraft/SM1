using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Packets
{
    public class SpawnParticlePacket : MinecraftPacket
    {
        public SpawnParticlePacket(MinecraftClient client) : base(client)
        {
        }

        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x23;

        public int ID;
        public bool LongRange;
        public Vector3F Position;
        public Vector3F Offset;
        public Int32 ParticleCount;
        public float ParticleData;
        public VarInt[] Data;

        public override void WritePacket()
        {
            Write(ID);
            Write(LongRange);
            Write(Position);
            Write(Offset);
            Write(ParticleData);
            Write(ParticleCount);
            Write(Data.Length);
            if (Data.Length != 0)
                Write(Data);
        }
    }
}
