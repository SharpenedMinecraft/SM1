
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Tripwire_hookItem : ItemStack
    {
        public override string Id => "minecraft:tripwire_hook";
        public override Int32 ProtocolId => 226;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Tripwire_hookBlock(), player);
        }

    }
}
