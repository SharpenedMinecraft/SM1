
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Purple_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:purple_terracotta";
        public override Int32 ProtocolId => 267;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Purple_terracottaBlock(), player);
        }

    }
}
