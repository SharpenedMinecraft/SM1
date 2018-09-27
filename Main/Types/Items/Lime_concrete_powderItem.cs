
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Lime_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:lime_concrete_powder";
        public override Int32 ProtocolId => 410;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Lime_concrete_powderBlock(), player);
        }

    }
}
