
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Smooth_sandstoneItem : ItemStack
    {
        public override string Id => "minecraft:smooth_sandstone";
        public override Int32 ProtocolId => 127;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Smooth_sandstoneBlock(), player);
        }

    }
}
