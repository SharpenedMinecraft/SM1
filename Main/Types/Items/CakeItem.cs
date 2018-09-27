
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class CakeItem : ItemStack
    {
        public override string Id => "minecraft:cake";
        public override Int32 ProtocolId => 579;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new CakeBlock(), player);
        }

    }
}
