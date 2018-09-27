
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Nether_quartz_oreItem : ItemStack
    {
        public override string Id => "minecraft:nether_quartz_ore";
        public override Int32 ProtocolId => 249;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Nether_quartz_oreBlock(), player);
        }

    }
}
