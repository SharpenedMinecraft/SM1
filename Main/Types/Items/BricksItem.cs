
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class BricksItem : ItemStack
    {
        public override string Id => "minecraft:bricks";
        public override Int32 ProtocolId => 129;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new BricksBlock(), player);
        }

    }
}
