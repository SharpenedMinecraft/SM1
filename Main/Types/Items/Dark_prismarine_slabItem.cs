
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dark_prismarine_slabItem : ItemStack
    {
        public override string Id => "minecraft:dark_prismarine_slab";
        public override Int32 ProtocolId => 124;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dark_prismarine_slabBlock(), player);
        }

    }
}
