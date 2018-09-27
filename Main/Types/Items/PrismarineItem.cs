
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class PrismarineItem : ItemStack
    {
        public override string Id => "minecraft:prismarine";
        public override Int32 ProtocolId => 337;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new PrismarineBlock(), player);
        }

    }
}
