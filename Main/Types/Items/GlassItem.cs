
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class GlassItem : ItemStack
    {
        public override string Id => "minecraft:glass";
        public override Int32 ProtocolId => 58;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new GlassBlock(), player);
        }

    }
}
