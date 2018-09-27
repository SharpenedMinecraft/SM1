
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:red_concrete_powder";
        public override Int32 ProtocolId => 419;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_concrete_powderBlock(), player);
        }

    }
}
