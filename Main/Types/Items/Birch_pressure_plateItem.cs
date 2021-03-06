
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Birch_pressure_plateItem : ItemStack
    {
        public override string Id => "minecraft:birch_pressure_plate";
        public override Int32 ProtocolId => 156;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Birch_pressure_plateBlock(), player);
        }

    }
}
