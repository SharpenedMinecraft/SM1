
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Jungle_pressure_plateItem : ItemStack
    {
        public override string Id => "minecraft:jungle_pressure_plate";
        public override Int32 ProtocolId => 157;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Jungle_pressure_plateBlock(), player);
        }

    }
}
