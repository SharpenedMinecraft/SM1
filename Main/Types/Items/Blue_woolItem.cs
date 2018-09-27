
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_woolItem : ItemStack
    {
        public override string Id => "minecraft:blue_wool";
        public override Int32 ProtocolId => 87;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_woolBlock(), player);
        }

    }
}
