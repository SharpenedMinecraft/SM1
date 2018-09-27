
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:shulker_box";
        public override Int32 ProtocolId => 356;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Shulker_boxBlock(), player);
        }

    }
}
