
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Pink_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:pink_terracotta";
        public override Int32 ProtocolId => 263;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Pink_terracottaBlock(), player);
        }

    }
}
