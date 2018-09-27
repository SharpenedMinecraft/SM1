using fNbt.Tags;
using SharpenedMinecraft.Packets;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Plugins
{
    public abstract class CustomBlock : Mob_spawnerBlock
    {
        public override abstract string BlockId { get; }
        public sealed override BlockState[] PossibleStates => base.PossibleStates;

        public override void OnPlace(Vector3 location, Player causing)
        {
            causing.Client.SendToAll(new UpdateBlockEntityPacket(causing.Client)
            {
                Action = UpdateBlockEntityPacket.PacketAction.MobSpawner,
                Position = location,
            });
        }
    }
}
