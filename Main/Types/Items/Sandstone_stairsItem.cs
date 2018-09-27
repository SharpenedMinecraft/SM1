
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Sandstone_stairsItem : ItemStack
    {
        public override string Id => "minecraft:sandstone_stairs";
        public override Int32 ProtocolId => 223;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Sandstone_stairsBlock(), player);
        }

    }
}
