
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class White_carpetItem : ItemStack
    {
        public override string Id => "minecraft:white_carpet";
        public override Int32 ProtocolId => 276;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new White_carpetBlock(), player);
        }

    }
}
