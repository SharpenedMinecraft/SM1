
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Lime_bannerItem : ItemStack
    {
        public override string Id => "minecraft:lime_banner";
        public override Int32 ProtocolId => 724;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Lime_bannerBlock(), player);
        }

    }
}
