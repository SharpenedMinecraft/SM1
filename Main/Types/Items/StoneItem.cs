
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class StoneItem : ItemStack
    {
        public override string Id => "minecraft:stone";
        public override Int32 ProtocolId => 1;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new StoneBlock(), player);
        }

    }
}
