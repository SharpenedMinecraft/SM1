
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Mossy_cobblestoneItem : ItemStack
    {
        public override string Id => "minecraft:mossy_cobblestone";
        public override Int32 ProtocolId => 132;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Mossy_cobblestoneBlock(), player);
        }

    }
}
