
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Gray_stained_glassItem : ItemStack
    {
        public override string Id => "minecraft:gray_stained_glass";
        public override Int32 ProtocolId => 312;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Gray_stained_glassBlock(), player);
        }

    }
}
