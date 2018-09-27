
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Snow_blockItem : ItemStack
    {
        public override string Id => "minecraft:snow_block";
        public override Int32 ProtocolId => 165;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Snow_blockBlock(), player);
        }

    }
}
