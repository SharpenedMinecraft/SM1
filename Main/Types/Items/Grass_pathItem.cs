
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Grass_pathItem : ItemStack
    {
        public override string Id => "minecraft:grass_path";
        public override Int32 ProtocolId => 298;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Grass_pathBlock(), player);
        }

    }
}
