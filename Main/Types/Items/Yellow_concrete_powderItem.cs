
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Yellow_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:yellow_concrete_powder";
        public override Int32 ProtocolId => 409;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Yellow_concrete_powderBlock(), player);
        }

    }
}
