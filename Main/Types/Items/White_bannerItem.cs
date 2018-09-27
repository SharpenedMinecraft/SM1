
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class White_bannerItem : ItemStack
    {
        public override string Id => "minecraft:white_banner";
        public override Int32 ProtocolId => 719;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new White_bannerBlock(), player);
        }

    }
}
