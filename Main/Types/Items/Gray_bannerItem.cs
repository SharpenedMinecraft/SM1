
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Gray_bannerItem : ItemStack
    {
        public override string Id => "minecraft:gray_banner";
        public override Int32 ProtocolId => 726;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Gray_bannerBlock(), player);
        }

    }
}
