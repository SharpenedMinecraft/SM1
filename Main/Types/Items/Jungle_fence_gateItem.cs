
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Jungle_fence_gateItem : ItemStack
    {
        public override string Id => "minecraft:jungle_fence_gate";
        public override Int32 ProtocolId => 207;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Jungle_fence_gateBlock(), player);
        }

    }
}
