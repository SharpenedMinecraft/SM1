
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Chiseled_quartz_blockItem : ItemStack
    {
        public override string Id => "minecraft:chiseled_quartz_block";
        public override Int32 ProtocolId => 251;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Chiseled_quartz_blockBlock(), player);
        }

    }
}
