
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brain_coral_fanItem : ItemStack
    {
        public override string Id => "minecraft:brain_coral_fan";
        public override Int32 ProtocolId => 438;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brain_coral_fanBlock(), player);
        }

    }
}
