
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class WheatItem : ItemStack
    {
        public override string Id => "minecraft:wheat";
        public override Int32 ProtocolId => 497;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new WheatBlock(), player);
        }

    }
}
