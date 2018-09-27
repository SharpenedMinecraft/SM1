
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brewing_standItem : ItemStack
    {
        public override string Id => "minecraft:brewing_stand";
        public override Int32 ProtocolId => 619;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brewing_standBlock(), player);
        }

    }
}
