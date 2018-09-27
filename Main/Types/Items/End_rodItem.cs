
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class End_rodItem : ItemStack
    {
        public override string Id => "minecraft:end_rod";
        public override Int32 ProtocolId => 135;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new End_rodBlock(), player);
        }

    }
}
