
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Chain_command_blockItem : ItemStack
    {
        public override string Id => "minecraft:chain_command_block";
        public override Int32 ProtocolId => 349;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Chain_command_blockBlock(), player);
        }

    }
}
