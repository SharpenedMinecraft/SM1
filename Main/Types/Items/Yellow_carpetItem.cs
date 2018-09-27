
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Yellow_carpetItem : ItemStack
    {
        public override string Id => "minecraft:yellow_carpet";
        public override Int32 ProtocolId => 280;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Yellow_carpetBlock(), player);
        }

    }
}
