
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_sandstone_slabItem : ItemStack
    {
        public override string Id => "minecraft:red_sandstone_slab";
        public override Int32 ProtocolId => 120;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_sandstone_slabBlock(), player);
        }

    }
}
