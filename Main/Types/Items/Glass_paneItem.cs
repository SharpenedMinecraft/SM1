
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Glass_paneItem : ItemStack
    {
        public override string Id => "minecraft:glass_pane";
        public override Int32 ProtocolId => 201;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Glass_paneBlock(), player);
        }

    }
}
