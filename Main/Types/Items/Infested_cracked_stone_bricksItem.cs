
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Infested_cracked_stone_bricksItem : ItemStack
    {
        public override string Id => "minecraft:infested_cracked_stone_bricks";
        public override Int32 ProtocolId => 191;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Infested_cracked_stone_bricksBlock(), player);
        }

    }
}
