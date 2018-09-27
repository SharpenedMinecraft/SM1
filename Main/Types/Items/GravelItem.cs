
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class GravelItem : ItemStack
    {
        public override string Id => "minecraft:gravel";
        public override Int32 ProtocolId => 28;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new GravelBlock(), player);
        }

    }
}
