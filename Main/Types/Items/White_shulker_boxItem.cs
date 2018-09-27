
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class White_shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:white_shulker_box";
        public override Int32 ProtocolId => 357;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new White_shulker_boxBlock(), player);
        }

    }
}
