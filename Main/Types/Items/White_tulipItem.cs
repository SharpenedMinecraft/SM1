
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class White_tulipItem : ItemStack
    {
        public override string Id => "minecraft:white_tulip";
        public override Int32 ProtocolId => 99;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new White_tulipBlock(), player);
        }

    }
}
