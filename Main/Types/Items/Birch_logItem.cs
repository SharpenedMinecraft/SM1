
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Birch_logItem : ItemStack
    {
        public override string Id => "minecraft:birch_log";
        public override Int32 ProtocolId => 34;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Birch_logBlock(), player);
        }

    }
}
