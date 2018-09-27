
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_carpetItem : ItemStack
    {
        public override string Id => "minecraft:blue_carpet";
        public override Int32 ProtocolId => 287;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_carpetBlock(), player);
        }

    }
}
