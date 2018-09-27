
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Light_blue_stained_glassItem : ItemStack
    {
        public override string Id => "minecraft:light_blue_stained_glass";
        public override Int32 ProtocolId => 308;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Light_blue_stained_glassBlock(), player);
        }

    }
}
