
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Polished_graniteItem : ItemStack
    {
        public override string Id => "minecraft:polished_granite";
        public override Int32 ProtocolId => 3;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Polished_graniteBlock(), player);
        }

    }
}
