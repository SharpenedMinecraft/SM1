
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class GlowstoneItem : ItemStack
    {
        public override string Id => "minecraft:glowstone";
        public override Int32 ProtocolId => 179;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new GlowstoneBlock(), player);
        }

    }
}
