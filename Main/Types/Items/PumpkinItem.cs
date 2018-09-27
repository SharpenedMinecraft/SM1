
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class PumpkinItem : ItemStack
    {
        public override string Id => "minecraft:pumpkin";
        public override Int32 ProtocolId => 175;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new PumpkinBlock(), player);
        }

    }
}
