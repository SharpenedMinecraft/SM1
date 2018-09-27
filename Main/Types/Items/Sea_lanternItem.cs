
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Sea_lanternItem : ItemStack
    {
        public override string Id => "minecraft:sea_lantern";
        public override Int32 ProtocolId => 343;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Sea_lanternBlock(), player);
        }

    }
}
