
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class SeagrassItem : ItemStack
    {
        public override string Id => "minecraft:seagrass";
        public override Int32 ProtocolId => 73;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new SeagrassBlock(), player);
        }

    }
}
