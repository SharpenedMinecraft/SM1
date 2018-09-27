
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_tulipItem : ItemStack
    {
        public override string Id => "minecraft:red_tulip";
        public override Int32 ProtocolId => 97;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_tulipBlock(), player);
        }

    }
}
