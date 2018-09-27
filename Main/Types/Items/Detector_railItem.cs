
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Detector_railItem : ItemStack
    {
        public override string Id => "minecraft:detector_rail";
        public override Int32 ProtocolId => 67;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Detector_railBlock(), player);
        }

    }
}
