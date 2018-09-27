
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class FernItem : ItemStack
    {
        public override string Id => "minecraft:fern";
        public override Int32 ProtocolId => 71;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new FernBlock(), player);
        }

    }
}
