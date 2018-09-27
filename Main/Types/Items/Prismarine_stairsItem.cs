
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Prismarine_stairsItem : ItemStack
    {
        public override string Id => "minecraft:prismarine_stairs";
        public override Int32 ProtocolId => 340;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Prismarine_stairsBlock(), player);
        }

    }
}
