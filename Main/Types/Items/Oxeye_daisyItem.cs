
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Oxeye_daisyItem : ItemStack
    {
        public override string Id => "minecraft:oxeye_daisy";
        public override Int32 ProtocolId => 101;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Oxeye_daisyBlock(), player);
        }

    }
}
