
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Stone_pressure_plateItem : ItemStack
    {
        public override string Id => "minecraft:stone_pressure_plate";
        public override Int32 ProtocolId => 153;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Stone_pressure_plateBlock(), player);
        }

    }
}
