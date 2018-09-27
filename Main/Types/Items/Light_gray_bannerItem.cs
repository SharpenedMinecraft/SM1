
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Light_gray_bannerItem : ItemStack
    {
        public override string Id => "minecraft:light_gray_banner";
        public override Int32 ProtocolId => 727;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Light_gray_bannerBlock(), player);
        }

    }
}
