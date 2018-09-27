
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_bedItem : ItemStack
    {
        public override string Id => "minecraft:blue_bed";
        public override Int32 ProtocolId => 591;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_bedBlock(), player);
        }

    }
}
