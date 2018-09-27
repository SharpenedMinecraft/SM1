
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Bubble_coral_fanItem : ItemStack
    {
        public override string Id => "minecraft:bubble_coral_fan";
        public override Int32 ProtocolId => 439;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Bubble_coral_fanBlock(), player);
        }

    }
}
