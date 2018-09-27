
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Chiseled_red_sandstoneItem : ItemStack
    {
        public override string Id => "minecraft:chiseled_red_sandstone";
        public override Int32 ProtocolId => 345;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Chiseled_red_sandstoneBlock(), player);
        }

    }
}
