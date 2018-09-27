
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Green_glazed_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:green_glazed_terracotta";
        public override Int32 ProtocolId => 386;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Green_glazed_terracottaBlock(), player);
        }

    }
}
