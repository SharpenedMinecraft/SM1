
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Jack_o_lanternItem : ItemStack
    {
        public override string Id => "minecraft:jack_o_lantern";
        public override Int32 ProtocolId => 180;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Jack_o_lanternBlock(), player);
        }

    }
}
