
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Black_bannerItem : ItemStack
    {
        public override string Id => "minecraft:black_banner";
        public override Int32 ProtocolId => 734;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Black_bannerBlock(), player);
        }

    }
}
