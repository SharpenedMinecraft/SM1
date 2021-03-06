
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class SnowItem : ItemStack
    {
        public override string Id => "minecraft:snow";
        public override Int32 ProtocolId => 163;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new SnowBlock(), player);
        }

    }
}
