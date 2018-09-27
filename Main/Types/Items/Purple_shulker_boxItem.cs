
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Purple_shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:purple_shulker_box";
        public override Int32 ProtocolId => 367;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Purple_shulker_boxBlock(), player);
        }

    }
}
