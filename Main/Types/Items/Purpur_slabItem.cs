
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Purpur_slabItem : ItemStack
    {
        public override string Id => "minecraft:purpur_slab";
        public override Int32 ProtocolId => 121;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Purpur_slabBlock(), player);
        }

    }
}
