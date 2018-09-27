
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class PoppyItem : ItemStack
    {
        public override string Id => "minecraft:poppy";
        public override Int32 ProtocolId => 93;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new PoppyBlock(), player);
        }

    }
}
