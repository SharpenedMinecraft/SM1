
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Soul_sandItem : ItemStack
    {
        public override string Id => "minecraft:soul_sand";
        public override Int32 ProtocolId => 178;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Soul_sandBlock(), player);
        }

    }
}
