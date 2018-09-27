
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Gray_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:gray_concrete_powder";
        public override Int32 ProtocolId => 412;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Gray_concrete_powderBlock(), player);
        }

    }
}
