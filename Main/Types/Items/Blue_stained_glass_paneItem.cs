
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_stained_glass_paneItem : ItemStack
    {
        public override string Id => "minecraft:blue_stained_glass_pane";
        public override Int32 ProtocolId => 332;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_stained_glass_paneBlock(), player);
        }

    }
}
