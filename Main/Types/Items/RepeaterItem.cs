
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class RepeaterItem : ItemStack
    {
        public override string Id => "minecraft:repeater";
        public override Int32 ProtocolId => 451;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new RepeaterBlock(), player);
        }

    }
}
