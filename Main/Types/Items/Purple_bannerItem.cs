
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Purple_bannerItem : ItemStack
    {
        public override string Id => "minecraft:purple_banner";
        public override Int32 ProtocolId => 729;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Purple_bannerBlock(), player);
        }

    }
}
