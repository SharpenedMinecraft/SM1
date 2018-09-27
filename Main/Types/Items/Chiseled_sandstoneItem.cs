
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Chiseled_sandstoneItem : ItemStack
    {
        public override string Id => "minecraft:chiseled_sandstone";
        public override Int32 ProtocolId => 63;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Chiseled_sandstoneBlock(), player);
        }

    }
}
