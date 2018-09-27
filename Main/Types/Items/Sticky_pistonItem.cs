
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Sticky_pistonItem : ItemStack
    {
        public override string Id => "minecraft:sticky_piston";
        public override Int32 ProtocolId => 68;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Sticky_pistonBlock(), player);
        }

    }
}
