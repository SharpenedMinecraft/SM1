
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class End_portal_frameItem : ItemStack
    {
        public override string Id => "minecraft:end_portal_frame";
        public override Int32 ProtocolId => 218;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new End_portal_frameBlock(), player);
        }

    }
}
