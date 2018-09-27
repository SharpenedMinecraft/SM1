
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Smooth_stoneItem : ItemStack
    {
        public override string Id => "minecraft:smooth_stone";
        public override Int32 ProtocolId => 128;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Smooth_stoneBlock(), player);
        }

    }
}
