
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Lapis_blockItem : ItemStack
    {
        public override string Id => "minecraft:lapis_block";
        public override Int32 ProtocolId => 60;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Lapis_blockBlock(), player);
        }

    }
}
