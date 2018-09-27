
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_glazed_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:blue_glazed_terracotta";
        public override Int32 ProtocolId => 384;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_glazed_terracottaBlock(), player);
        }

    }
}
