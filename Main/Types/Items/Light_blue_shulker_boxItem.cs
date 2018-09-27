
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Light_blue_shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:light_blue_shulker_box";
        public override Int32 ProtocolId => 360;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Light_blue_shulker_boxBlock(), player);
        }

    }
}
