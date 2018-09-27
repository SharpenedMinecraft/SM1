
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Pink_bannerItem : ItemStack
    {
        public override string Id => "minecraft:pink_banner";
        public override Int32 ProtocolId => 725;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Pink_bannerBlock(), player);
        }

    }
}
