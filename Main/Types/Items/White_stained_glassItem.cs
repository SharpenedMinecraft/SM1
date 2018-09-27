
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class White_stained_glassItem : ItemStack
    {
        public override string Id => "minecraft:white_stained_glass";
        public override Int32 ProtocolId => 305;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new White_stained_glassBlock(), player);
        }

    }
}
