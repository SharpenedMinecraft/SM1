
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Smooth_quartzItem : ItemStack
    {
        public override string Id => "minecraft:smooth_quartz";
        public override Int32 ProtocolId => 125;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Smooth_quartzBlock(), player);
        }

    }
}
