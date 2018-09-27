
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Spruce_pressure_plateItem : ItemStack
    {
        public override string Id => "minecraft:spruce_pressure_plate";
        public override Int32 ProtocolId => 155;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Spruce_pressure_plateBlock(), player);
        }

    }
}
