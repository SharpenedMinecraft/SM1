
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Green_stained_glassItem : ItemStack
    {
        public override string Id => "minecraft:green_stained_glass";
        public override Int32 ProtocolId => 318;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Green_stained_glassBlock(), player);
        }

    }
}
