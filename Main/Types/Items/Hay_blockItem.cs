
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Hay_blockItem : ItemStack
    {
        public override string Id => "minecraft:hay_block";
        public override Int32 ProtocolId => 275;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Hay_blockBlock(), player);
        }

    }
}
