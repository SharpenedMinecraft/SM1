
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Quartz_stairsItem : ItemStack
    {
        public override string Id => "minecraft:quartz_stairs";
        public override Int32 ProtocolId => 254;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Quartz_stairsBlock(), player);
        }

    }
}
