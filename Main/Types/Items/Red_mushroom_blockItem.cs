
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_mushroom_blockItem : ItemStack
    {
        public override string Id => "minecraft:red_mushroom_block";
        public override Int32 ProtocolId => 198;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_mushroom_blockBlock(), player);
        }

    }
}
