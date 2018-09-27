
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Pink_bedItem : ItemStack
    {
        public override string Id => "minecraft:pink_bed";
        public override Int32 ProtocolId => 586;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Pink_bedBlock(), player);
        }

    }
}
