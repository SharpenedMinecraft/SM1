
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_iceItem : ItemStack
    {
        public override string Id => "minecraft:blue_ice";
        public override Int32 ProtocolId => 442;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_iceBlock(), player);
        }

    }
}
