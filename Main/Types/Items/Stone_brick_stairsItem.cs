
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Stone_brick_stairsItem : ItemStack
    {
        public override string Id => "minecraft:stone_brick_stairs";
        public override Int32 ProtocolId => 211;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Stone_brick_stairsBlock(), player);
        }

    }
}
