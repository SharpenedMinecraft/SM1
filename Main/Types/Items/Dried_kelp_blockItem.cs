
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dried_kelp_blockItem : ItemStack
    {
        public override string Id => "minecraft:dried_kelp_block";
        public override Int32 ProtocolId => 544;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dried_kelp_blockBlock(), player);
        }

    }
}
