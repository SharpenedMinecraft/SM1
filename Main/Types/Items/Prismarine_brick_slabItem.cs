
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Prismarine_brick_slabItem : ItemStack
    {
        public override string Id => "minecraft:prismarine_brick_slab";
        public override Int32 ProtocolId => 123;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Prismarine_brick_slabBlock(), player);
        }

    }
}
