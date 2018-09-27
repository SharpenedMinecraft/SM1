
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dead_brain_coral_blockItem : ItemStack
    {
        public override string Id => "minecraft:dead_brain_coral_block";
        public override Int32 ProtocolId => 423;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dead_brain_coral_blockBlock(), player);
        }

    }
}
