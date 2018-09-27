
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Light_blue_glazed_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:light_blue_glazed_terracotta";
        public override Int32 ProtocolId => 376;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Light_blue_glazed_terracottaBlock(), player);
        }

    }
}
