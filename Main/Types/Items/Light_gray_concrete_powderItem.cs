
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Light_gray_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:light_gray_concrete_powder";
        public override Int32 ProtocolId => 413;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Light_gray_concrete_powderBlock(), player);
        }

    }
}
