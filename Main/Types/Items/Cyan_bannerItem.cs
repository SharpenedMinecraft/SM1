
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cyan_bannerItem : ItemStack
    {
        public override string Id => "minecraft:cyan_banner";
        public override Int32 ProtocolId => 728;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cyan_bannerBlock(), player);
        }

    }
}
