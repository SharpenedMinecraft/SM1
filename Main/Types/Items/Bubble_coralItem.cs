
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Bubble_coralItem : ItemStack
    {
        public override string Id => "minecraft:bubble_coral";
        public override Int32 ProtocolId => 434;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Bubble_coralBlock(), player);
        }

    }
}
