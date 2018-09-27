
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class MyceliumItem : ItemStack
    {
        public override string Id => "minecraft:mycelium";
        public override Int32 ProtocolId => 212;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new MyceliumBlock(), player);
        }

    }
}
