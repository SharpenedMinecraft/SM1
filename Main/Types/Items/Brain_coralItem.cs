
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brain_coralItem : ItemStack
    {
        public override string Id => "minecraft:brain_coral";
        public override Int32 ProtocolId => 433;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brain_coralBlock(), player);
        }

    }
}
