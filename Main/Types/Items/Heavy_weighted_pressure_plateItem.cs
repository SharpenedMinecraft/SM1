
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Heavy_weighted_pressure_plateItem : ItemStack
    {
        public override string Id => "minecraft:heavy_weighted_pressure_plate";
        public override Int32 ProtocolId => 246;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Heavy_weighted_pressure_plateBlock(), player);
        }

    }
}
