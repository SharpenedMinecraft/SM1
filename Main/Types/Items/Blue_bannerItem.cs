
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_bannerItem : ItemStack
    {
        public override string Id => "minecraft:blue_banner";
        public override Int32 ProtocolId => 730;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_bannerBlock(), player);
        }

    }
}
