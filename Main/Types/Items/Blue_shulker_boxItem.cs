
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:blue_shulker_box";
        public override Int32 ProtocolId => 368;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_shulker_boxBlock(), player);
        }

    }
}
