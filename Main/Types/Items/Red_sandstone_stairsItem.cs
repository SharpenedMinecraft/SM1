
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_sandstone_stairsItem : ItemStack
    {
        public override string Id => "minecraft:red_sandstone_stairs";
        public override Int32 ProtocolId => 347;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_sandstone_stairsBlock(), player);
        }

    }
}
