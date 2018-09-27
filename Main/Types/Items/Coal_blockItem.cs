
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Coal_blockItem : ItemStack
    {
        public override string Id => "minecraft:coal_block";
        public override Int32 ProtocolId => 293;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Coal_blockBlock(), player);
        }

    }
}
