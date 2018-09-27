
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dark_oak_pressure_plateItem : ItemStack
    {
        public override string Id => "minecraft:dark_oak_pressure_plate";
        public override Int32 ProtocolId => 159;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dark_oak_pressure_plateBlock(), player);
        }

    }
}
