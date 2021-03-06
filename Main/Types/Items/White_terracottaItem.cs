
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class White_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:white_terracotta";
        public override Int32 ProtocolId => 257;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new White_terracottaBlock(), player);
        }

    }
}
