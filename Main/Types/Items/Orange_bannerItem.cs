
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Orange_bannerItem : ItemStack
    {
        public override string Id => "minecraft:orange_banner";
        public override Int32 ProtocolId => 720;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Orange_bannerBlock(), player);
        }

    }
}
