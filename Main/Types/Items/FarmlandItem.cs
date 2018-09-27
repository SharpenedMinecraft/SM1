
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class FarmlandItem : ItemStack
    {
        public override string Id => "minecraft:farmland";
        public override Int32 ProtocolId => 147;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new FarmlandBlock(), player);
        }

    }
}
