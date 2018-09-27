
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cracked_stone_bricksItem : ItemStack
    {
        public override string Id => "minecraft:cracked_stone_bricks";
        public override Int32 ProtocolId => 195;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cracked_stone_bricksBlock(), player);
        }

    }
}
