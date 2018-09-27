
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brown_stained_glassItem : ItemStack
    {
        public override string Id => "minecraft:brown_stained_glass";
        public override Int32 ProtocolId => 317;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brown_stained_glassBlock(), player);
        }

    }
}
