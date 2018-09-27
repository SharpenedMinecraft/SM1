
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Petrified_oak_slabItem : ItemStack
    {
        public override string Id => "minecraft:petrified_oak_slab";
        public override Int32 ProtocolId => 114;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Petrified_oak_slabBlock(), player);
        }

    }
}
