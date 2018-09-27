
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Redstone_blockItem : ItemStack
    {
        public override string Id => "minecraft:redstone_block";
        public override Int32 ProtocolId => 248;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Redstone_blockBlock(), player);
        }

    }
}
