
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Light_blue_bannerItem : ItemStack
    {
        public override string Id => "minecraft:light_blue_banner";
        public override Int32 ProtocolId => 722;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Light_blue_bannerBlock(), player);
        }

    }
}
