
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Yellow_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:yellow_terracotta";
        public override Int32 ProtocolId => 261;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Yellow_terracottaBlock(), player);
        }

    }
}
