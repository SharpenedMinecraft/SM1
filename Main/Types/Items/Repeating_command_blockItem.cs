
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Repeating_command_blockItem : ItemStack
    {
        public override string Id => "minecraft:repeating_command_block";
        public override Int32 ProtocolId => 348;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Repeating_command_blockBlock(), player);
        }

    }
}
