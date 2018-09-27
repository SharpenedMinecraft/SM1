
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dead_bushItem : ItemStack
    {
        public override string Id => "minecraft:dead_bush";
        public override Int32 ProtocolId => 72;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dead_bushBlock(), player);
        }

    }
}
