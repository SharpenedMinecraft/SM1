
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brown_bannerItem : ItemStack
    {
        public override string Id => "minecraft:brown_banner";
        public override Int32 ProtocolId => 731;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brown_bannerBlock(), player);
        }

    }
}
