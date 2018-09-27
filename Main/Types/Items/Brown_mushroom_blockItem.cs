
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brown_mushroom_blockItem : ItemStack
    {
        public override string Id => "minecraft:brown_mushroom_block";
        public override Int32 ProtocolId => 197;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brown_mushroom_blockBlock(), player);
        }

    }
}
