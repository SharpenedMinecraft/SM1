
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cobblestone_stairsItem : ItemStack
    {
        public override string Id => "minecraft:cobblestone_stairs";
        public override Int32 ProtocolId => 151;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cobblestone_stairsBlock(), player);
        }

    }
}
