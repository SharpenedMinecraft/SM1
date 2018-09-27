
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Nether_bricksItem : ItemStack
    {
        public override string Id => "minecraft:nether_bricks";
        public override Int32 ProtocolId => 214;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Nether_bricksBlock(), player);
        }

    }
}
