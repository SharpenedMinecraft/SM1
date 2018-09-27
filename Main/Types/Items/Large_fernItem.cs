
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Large_fernItem : ItemStack
    {
        public override string Id => "minecraft:large_fern";
        public override Int32 ProtocolId => 304;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Large_fernBlock(), player);
        }

    }
}
