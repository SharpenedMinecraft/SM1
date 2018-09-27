
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Lily_padItem : ItemStack
    {
        public override string Id => "minecraft:lily_pad";
        public override Int32 ProtocolId => 213;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Lily_padBlock(), player);
        }

    }
}
