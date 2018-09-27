
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Black_woolItem : ItemStack
    {
        public override string Id => "minecraft:black_wool";
        public override Int32 ProtocolId => 91;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Black_woolBlock(), player);
        }

    }
}
