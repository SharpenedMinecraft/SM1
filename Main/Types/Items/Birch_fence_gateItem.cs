
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Birch_fence_gateItem : ItemStack
    {
        public override string Id => "minecraft:birch_fence_gate";
        public override Int32 ProtocolId => 206;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Birch_fence_gateBlock(), player);
        }

    }
}
