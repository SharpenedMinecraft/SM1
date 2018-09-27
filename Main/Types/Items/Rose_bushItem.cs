
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Rose_bushItem : ItemStack
    {
        public override string Id => "minecraft:rose_bush";
        public override Int32 ProtocolId => 301;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Rose_bushBlock(), player);
        }

    }
}
