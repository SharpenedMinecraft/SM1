
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Redstone_oreItem : ItemStack
    {
        public override string Id => "minecraft:redstone_ore";
        public override Int32 ProtocolId => 160;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Redstone_oreBlock(), player);
        }

    }
}
