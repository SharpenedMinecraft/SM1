
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Polished_andesiteItem : ItemStack
    {
        public override string Id => "minecraft:polished_andesite";
        public override Int32 ProtocolId => 7;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Polished_andesiteBlock(), player);
        }

    }
}
