
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Black_shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:black_shulker_box";
        public override Int32 ProtocolId => 372;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Black_shulker_boxBlock(), player);
        }

    }
}
