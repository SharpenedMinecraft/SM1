
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Quartz_pillarItem : ItemStack
    {
        public override string Id => "minecraft:quartz_pillar";
        public override Int32 ProtocolId => 253;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Quartz_pillarBlock(), player);
        }

    }
}
