
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Nether_brick_fenceItem : ItemStack
    {
        public override string Id => "minecraft:nether_brick_fence";
        public override Int32 ProtocolId => 215;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Nether_brick_fenceBlock(), player);
        }

    }
}
