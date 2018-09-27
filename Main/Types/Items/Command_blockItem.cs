
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Command_blockItem : ItemStack
    {
        public override string Id => "minecraft:command_block";
        public override Int32 ProtocolId => 231;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Command_blockBlock(), player);
        }

    }
}
