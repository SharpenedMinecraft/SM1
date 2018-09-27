
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Infested_stone_bricksItem : ItemStack
    {
        public override string Id => "minecraft:infested_stone_bricks";
        public override Int32 ProtocolId => 189;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Infested_stone_bricksBlock(), player);
        }

    }
}
