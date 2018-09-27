
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Stone_bricksItem : ItemStack
    {
        public override string Id => "minecraft:stone_bricks";
        public override Int32 ProtocolId => 193;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Stone_bricksBlock(), player);
        }

    }
}
