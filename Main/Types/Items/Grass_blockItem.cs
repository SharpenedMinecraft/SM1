
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Grass_blockItem : ItemStack
    {
        public override string Id => "minecraft:grass_block";
        public override Int32 ProtocolId => 8;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Grass_blockBlock(), player);
        }

    }
}
