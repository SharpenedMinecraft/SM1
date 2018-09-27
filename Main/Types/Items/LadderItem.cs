
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class LadderItem : ItemStack
    {
        public override string Id => "minecraft:ladder";
        public override Int32 ProtocolId => 149;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new LadderBlock(), player);
        }

    }
}
