
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class HopperItem : ItemStack
    {
        public override string Id => "minecraft:hopper";
        public override Int32 ProtocolId => 250;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new HopperBlock(), player);
        }

    }
}
