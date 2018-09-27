
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dead_horn_coral_blockItem : ItemStack
    {
        public override string Id => "minecraft:dead_horn_coral_block";
        public override Int32 ProtocolId => 426;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dead_horn_coral_blockBlock(), player);
        }

    }
}
