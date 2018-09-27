
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Pink_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:pink_concrete_powder";
        public override Int32 ProtocolId => 411;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Pink_concrete_powderBlock(), player);
        }

    }
}
