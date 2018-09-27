
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class AlliumItem : ItemStack
    {
        public override string Id => "minecraft:allium";
        public override Int32 ProtocolId => 95;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new AlliumBlock(), player);
        }

    }
}
