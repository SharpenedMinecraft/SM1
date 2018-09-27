
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Daylight_detectorItem : ItemStack
    {
        public override string Id => "minecraft:daylight_detector";
        public override Int32 ProtocolId => 247;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Daylight_detectorBlock(), player);
        }

    }
}
