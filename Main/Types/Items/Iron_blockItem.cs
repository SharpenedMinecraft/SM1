
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Iron_blockItem : ItemStack
    {
        public override string Id => "minecraft:iron_block";
        public override Int32 ProtocolId => 105;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Iron_blockBlock(), player);
        }

    }
}
