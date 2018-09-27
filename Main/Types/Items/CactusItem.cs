
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class CactusItem : ItemStack
    {
        public override string Id => "minecraft:cactus";
        public override Int32 ProtocolId => 166;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new CactusBlock(), player);
        }

    }
}
