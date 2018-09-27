
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Jungle_logItem : ItemStack
    {
        public override string Id => "minecraft:jungle_log";
        public override Int32 ProtocolId => 35;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Jungle_logBlock(), player);
        }

    }
}
