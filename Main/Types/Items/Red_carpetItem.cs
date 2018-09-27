
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_carpetItem : ItemStack
    {
        public override string Id => "minecraft:red_carpet";
        public override Int32 ProtocolId => 290;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_carpetBlock(), player);
        }

    }
}
