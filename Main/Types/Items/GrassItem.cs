
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class GrassItem : ItemStack
    {
        public override string Id => "minecraft:grass";
        public override Int32 ProtocolId => 70;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new GrassBlock(), player);
        }

    }
}
