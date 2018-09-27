
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brick_slabItem : ItemStack
    {
        public override string Id => "minecraft:brick_slab";
        public override Int32 ProtocolId => 116;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brick_slabBlock(), player);
        }

    }
}
