
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Activator_railItem : ItemStack
    {
        public override string Id => "minecraft:activator_rail";
        public override Int32 ProtocolId => 255;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Activator_railBlock(), player);
        }

    }
}
