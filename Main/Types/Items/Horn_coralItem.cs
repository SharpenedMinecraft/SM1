
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Horn_coralItem : ItemStack
    {
        public override string Id => "minecraft:horn_coral";
        public override Int32 ProtocolId => 436;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Horn_coralBlock(), player);
        }

    }
}
