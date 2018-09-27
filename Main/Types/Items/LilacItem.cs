
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class LilacItem : ItemStack
    {
        public override string Id => "minecraft:lilac";
        public override Int32 ProtocolId => 300;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new LilacBlock(), player);
        }

    }
}
