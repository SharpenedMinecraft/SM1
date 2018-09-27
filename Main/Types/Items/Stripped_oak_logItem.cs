
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Stripped_oak_logItem : ItemStack
    {
        public override string Id => "minecraft:stripped_oak_log";
        public override Int32 ProtocolId => 38;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Stripped_oak_logBlock(), player);
        }

    }
}
