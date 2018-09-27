
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brown_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:brown_terracotta";
        public override Int32 ProtocolId => 269;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brown_terracottaBlock(), player);
        }

    }
}
