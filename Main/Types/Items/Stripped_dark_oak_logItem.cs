
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Stripped_dark_oak_logItem : ItemStack
    {
        public override string Id => "minecraft:stripped_dark_oak_log";
        public override Int32 ProtocolId => 43;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Stripped_dark_oak_logBlock(), player);
        }

    }
}
