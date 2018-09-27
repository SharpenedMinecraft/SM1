
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class TerracottaItem : ItemStack
    {
        public override string Id => "minecraft:terracotta";
        public override Int32 ProtocolId => 292;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new TerracottaBlock(), player);
        }

    }
}
