
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Gray_carpetItem : ItemStack
    {
        public override string Id => "minecraft:gray_carpet";
        public override Int32 ProtocolId => 283;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Gray_carpetBlock(), player);
        }

    }
}
