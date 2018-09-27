
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Iron_oreItem : ItemStack
    {
        public override string Id => "minecraft:iron_ore";
        public override Int32 ProtocolId => 30;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Iron_oreBlock(), player);
        }

    }
}
