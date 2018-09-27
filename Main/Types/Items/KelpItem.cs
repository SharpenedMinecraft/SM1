
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class KelpItem : ItemStack
    {
        public override string Id => "minecraft:kelp";
        public override Int32 ProtocolId => 543;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new KelpBlock(), player);
        }

    }
}
