
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_stained_glassItem : ItemStack
    {
        public override string Id => "minecraft:red_stained_glass";
        public override Int32 ProtocolId => 319;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_stained_glassBlock(), player);
        }

    }
}
