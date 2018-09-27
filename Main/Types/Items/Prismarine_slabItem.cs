
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Prismarine_slabItem : ItemStack
    {
        public override string Id => "minecraft:prismarine_slab";
        public override Int32 ProtocolId => 122;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Prismarine_slabBlock(), player);
        }

    }
}
