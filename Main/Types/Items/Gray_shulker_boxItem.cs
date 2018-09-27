
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Gray_shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:gray_shulker_box";
        public override Int32 ProtocolId => 364;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Gray_shulker_boxBlock(), player);
        }

    }
}
