
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_nether_bricksItem : ItemStack
    {
        public override string Id => "minecraft:red_nether_bricks";
        public override Int32 ProtocolId => 352;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_nether_bricksBlock(), player);
        }

    }
}
