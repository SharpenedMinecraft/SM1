
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Coarse_dirtItem : ItemStack
    {
        public override string Id => "minecraft:coarse_dirt";
        public override Int32 ProtocolId => 10;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Coarse_dirtBlock(), player);
        }

    }
}
