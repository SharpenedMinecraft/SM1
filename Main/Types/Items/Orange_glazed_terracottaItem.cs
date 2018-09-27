
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Orange_glazed_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:orange_glazed_terracotta";
        public override Int32 ProtocolId => 374;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Orange_glazed_terracottaBlock(), player);
        }

    }
}
