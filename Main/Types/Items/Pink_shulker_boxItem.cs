
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Pink_shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:pink_shulker_box";
        public override Int32 ProtocolId => 363;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Pink_shulker_boxBlock(), player);
        }

    }
}
