
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Iron_doorItem : ItemStack
    {
        public override string Id => "minecraft:iron_door";
        public override Int32 ProtocolId => 444;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Iron_doorBlock(), player);
        }

    }
}
