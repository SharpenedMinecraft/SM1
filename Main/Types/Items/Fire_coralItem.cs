
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Fire_coralItem : ItemStack
    {
        public override string Id => "minecraft:fire_coral";
        public override Int32 ProtocolId => 435;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Fire_coralBlock(), player);
        }

    }
}
