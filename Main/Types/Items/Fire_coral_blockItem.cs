
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Fire_coral_blockItem : ItemStack
    {
        public override string Id => "minecraft:fire_coral_block";
        public override Int32 ProtocolId => 430;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Fire_coral_blockBlock(), player);
        }

    }
}
