
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Chiseled_stone_bricksItem : ItemStack
    {
        public override string Id => "minecraft:chiseled_stone_bricks";
        public override Int32 ProtocolId => 196;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Chiseled_stone_bricksBlock(), player);
        }

    }
}
