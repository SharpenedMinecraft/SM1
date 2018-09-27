
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class BeaconItem : ItemStack
    {
        public override string Id => "minecraft:beacon";
        public override Int32 ProtocolId => 232;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new BeaconBlock(), player);
        }

    }
}
