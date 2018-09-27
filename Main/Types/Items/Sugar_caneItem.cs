
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Sugar_caneItem : ItemStack
    {
        public override string Id => "minecraft:sugar_cane";
        public override Int32 ProtocolId => 542;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Sugar_caneBlock(), player);
        }

    }
}
