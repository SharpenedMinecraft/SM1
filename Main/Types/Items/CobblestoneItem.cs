
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class CobblestoneItem : ItemStack
    {
        public override string Id => "minecraft:cobblestone";
        public override Int32 ProtocolId => 12;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new CobblestoneBlock(), player);
        }

    }
}
