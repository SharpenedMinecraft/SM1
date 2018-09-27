
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Magma_blockItem : ItemStack
    {
        public override string Id => "minecraft:magma_block";
        public override Int32 ProtocolId => 350;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Magma_blockBlock(), player);
        }

    }
}
