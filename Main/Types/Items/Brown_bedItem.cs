
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brown_bedItem : ItemStack
    {
        public override string Id => "minecraft:brown_bed";
        public override Int32 ProtocolId => 592;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brown_bedBlock(), player);
        }

    }
}
