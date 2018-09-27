
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Gold_blockItem : ItemStack
    {
        public override string Id => "minecraft:gold_block";
        public override Int32 ProtocolId => 104;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Gold_blockBlock(), player);
        }

    }
}
