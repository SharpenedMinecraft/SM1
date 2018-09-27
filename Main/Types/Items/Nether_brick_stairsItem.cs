
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Nether_brick_stairsItem : ItemStack
    {
        public override string Id => "minecraft:nether_brick_stairs";
        public override Int32 ProtocolId => 216;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Nether_brick_stairsBlock(), player);
        }

    }
}
