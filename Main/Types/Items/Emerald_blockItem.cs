
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Emerald_blockItem : ItemStack
    {
        public override string Id => "minecraft:emerald_block";
        public override Int32 ProtocolId => 227;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Emerald_blockBlock(), player);
        }

    }
}
