
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Yellow_shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:yellow_shulker_box";
        public override Int32 ProtocolId => 361;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Yellow_shulker_boxBlock(), player);
        }

    }
}
