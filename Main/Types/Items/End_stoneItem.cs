
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class End_stoneItem : ItemStack
    {
        public override string Id => "minecraft:end_stone";
        public override Int32 ProtocolId => 219;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new End_stoneBlock(), player);
        }

    }
}
