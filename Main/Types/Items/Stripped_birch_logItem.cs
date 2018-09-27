
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Stripped_birch_logItem : ItemStack
    {
        public override string Id => "minecraft:stripped_birch_log";
        public override Int32 ProtocolId => 40;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Stripped_birch_logBlock(), player);
        }

    }
}
