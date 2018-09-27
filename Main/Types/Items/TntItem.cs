
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class TntItem : ItemStack
    {
        public override string Id => "minecraft:tnt";
        public override Int32 ProtocolId => 130;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new TntBlock(), player);
        }

    }
}
