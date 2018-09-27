
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class ObsidianItem : ItemStack
    {
        public override string Id => "minecraft:obsidian";
        public override Int32 ProtocolId => 133;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new ObsidianBlock(), player);
        }

    }
}
