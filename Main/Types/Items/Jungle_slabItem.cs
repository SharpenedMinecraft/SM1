
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Jungle_slabItem : ItemStack
    {
        public override string Id => "minecraft:jungle_slab";
        public override Int32 ProtocolId => 109;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Jungle_slabBlock(), player);
        }

    }
}
