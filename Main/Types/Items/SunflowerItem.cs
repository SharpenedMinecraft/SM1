
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class SunflowerItem : ItemStack
    {
        public override string Id => "minecraft:sunflower";
        public override Int32 ProtocolId => 299;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new SunflowerBlock(), player);
        }

    }
}
