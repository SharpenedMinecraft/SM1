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
    public class JoinGamePacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x24;

        public Int32 EntityID;
        public GameMode mode;
        public int dimension;
        public Difficulty difficulty;
        public Byte PlayerCount; //Ignored
        public WorldType LevelType;
        public Boolean ReducedDebugInfo;

        public JoinGamePacket(MinecraftClient client)
            : base(client)
        {
        }

        public override void Initialize(int length, Stream stream)
        { 
            base.Initialize(length, stream);
            EntityID = Player.EntityId;
            mode = Player.GameMode;
            dimension = Player.Transform.Dimension;
            difficulty = World.Difficulty;
            PlayerCount = (Byte)World.WorldPlayers.Count;
            LevelType = World.WorldType;
#if DEBUG
            ReducedDebugInfo = false;
#else
            ReducedDebugInfo = true;
#endif
        }

        public override void WritePacket()
        {
            Write(EntityID);
            Write((Byte)mode);
            Write(dimension);
            Write((byte)difficulty);
            Write(PlayerCount);
            Write(LevelType.type.GetString());
            Write(ReducedDebugInfo);

            World.Entities.Add(Player);
            Client.StartKeepAlive();
        }
    }
}
