
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class AndesiteItem : ItemStack
    {
        public override string Id => "minecraft:andesite";
        public override Int32 ProtocolId => 6;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new AndesiteBlock(), player);
        }

    }
}
