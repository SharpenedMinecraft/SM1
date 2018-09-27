
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Infested_stoneItem : ItemStack
    {
        public override string Id => "minecraft:infested_stone";
        public override Int32 ProtocolId => 187;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Infested_stoneBlock(), player);
        }

    }
}
