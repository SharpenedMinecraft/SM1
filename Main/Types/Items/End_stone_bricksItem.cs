
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class End_stone_bricksItem : ItemStack
    {
        public override string Id => "minecraft:end_stone_bricks";
        public override Int32 ProtocolId => 220;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new End_stone_bricksBlock(), player);
        }

    }
}
