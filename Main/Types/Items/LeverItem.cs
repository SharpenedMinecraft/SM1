
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class LeverItem : ItemStack
    {
        public override string Id => "minecraft:lever";
        public override Int32 ProtocolId => 152;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new LeverBlock(), player);
        }

    }
}
