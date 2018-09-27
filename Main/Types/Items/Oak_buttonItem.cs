
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Oak_buttonItem : ItemStack
    {
        public override string Id => "minecraft:oak_button";
        public override Int32 ProtocolId => 235;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Oak_buttonBlock(), player);
        }

    }
}
