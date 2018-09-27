
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class BarrierItem : ItemStack
    {
        public override string Id => "minecraft:barrier";
        public override Int32 ProtocolId => 273;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new BarrierBlock(), player);
        }

    }
}
