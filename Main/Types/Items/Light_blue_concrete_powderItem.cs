
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Light_blue_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:light_blue_concrete_powder";
        public override Int32 ProtocolId => 408;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Light_blue_concrete_powderBlock(), player);
        }

    }
}
