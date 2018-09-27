
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Green_bannerItem : ItemStack
    {
        public override string Id => "minecraft:green_banner";
        public override Int32 ProtocolId => 732;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Green_bannerBlock(), player);
        }

    }
}
