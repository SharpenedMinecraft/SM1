
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Packed_iceItem : ItemStack
    {
        public override string Id => "minecraft:packed_ice";
        public override Int32 ProtocolId => 294;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Packed_iceBlock(), player);
        }

    }
}
