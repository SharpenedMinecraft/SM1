
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class DandelionItem : ItemStack
    {
        public override string Id => "minecraft:dandelion";
        public override Int32 ProtocolId => 92;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new DandelionBlock(), player);
        }

    }
}
