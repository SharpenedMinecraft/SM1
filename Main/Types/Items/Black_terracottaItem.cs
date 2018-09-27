
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Black_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:black_terracotta";
        public override Int32 ProtocolId => 272;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Black_terracottaBlock(), player);
        }

    }
}
