
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Green_bedItem : ItemStack
    {
        public override string Id => "minecraft:green_bed";
        public override Int32 ProtocolId => 593;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Green_bedBlock(), player);
        }

    }
}
