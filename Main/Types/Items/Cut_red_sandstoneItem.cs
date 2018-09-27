
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cut_red_sandstoneItem : ItemStack
    {
        public override string Id => "minecraft:cut_red_sandstone";
        public override Int32 ProtocolId => 346;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cut_red_sandstoneBlock(), player);
        }

    }
}
