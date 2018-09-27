
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:red_terracotta";
        public override Int32 ProtocolId => 271;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_terracottaBlock(), player);
        }

    }
}
