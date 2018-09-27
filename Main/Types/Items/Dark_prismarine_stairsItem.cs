
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dark_prismarine_stairsItem : ItemStack
    {
        public override string Id => "minecraft:dark_prismarine_stairs";
        public override Int32 ProtocolId => 342;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dark_prismarine_stairsBlock(), player);
        }

    }
}
