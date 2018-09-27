
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:blue_concrete_powder";
        public override Int32 ProtocolId => 416;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_concrete_powderBlock(), player);
        }

    }
}
