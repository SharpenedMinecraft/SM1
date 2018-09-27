
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class VineItem : ItemStack
    {
        public override string Id => "minecraft:vine";
        public override Int32 ProtocolId => 203;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new VineBlock(), player);
        }

    }
}
