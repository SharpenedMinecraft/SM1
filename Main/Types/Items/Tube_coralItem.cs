
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Tube_coralItem : ItemStack
    {
        public override string Id => "minecraft:tube_coral";
        public override Int32 ProtocolId => 432;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Tube_coralBlock(), player);
        }

    }
}
