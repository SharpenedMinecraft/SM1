
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class CauldronItem : ItemStack
    {
        public override string Id => "minecraft:cauldron";
        public override Int32 ProtocolId => 620;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new CauldronBlock(), player);
        }

    }
}
