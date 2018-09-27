
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Quartz_blockItem : ItemStack
    {
        public override string Id => "minecraft:quartz_block";
        public override Int32 ProtocolId => 252;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Quartz_blockBlock(), player);
        }

    }
}
