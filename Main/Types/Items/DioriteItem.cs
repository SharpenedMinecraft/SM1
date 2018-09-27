
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class DioriteItem : ItemStack
    {
        public override string Id => "minecraft:diorite";
        public override Int32 ProtocolId => 4;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new DioriteBlock(), player);
        }

    }
}
