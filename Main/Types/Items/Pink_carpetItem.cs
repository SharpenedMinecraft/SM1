
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Pink_carpetItem : ItemStack
    {
        public override string Id => "minecraft:pink_carpet";
        public override Int32 ProtocolId => 282;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Pink_carpetBlock(), player);
        }

    }
}
