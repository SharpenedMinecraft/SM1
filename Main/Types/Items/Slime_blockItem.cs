
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Slime_blockItem : ItemStack
    {
        public override string Id => "minecraft:slime_block";
        public override Int32 ProtocolId => 297;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Slime_blockBlock(), player);
        }

    }
}
