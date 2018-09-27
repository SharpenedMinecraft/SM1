
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Magenta_bedItem : ItemStack
    {
        public override string Id => "minecraft:magenta_bed";
        public override Int32 ProtocolId => 582;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Magenta_bedBlock(), player);
        }

    }
}
