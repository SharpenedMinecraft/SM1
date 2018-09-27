
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dark_oak_saplingItem : ItemStack
    {
        public override string Id => "minecraft:dark_oak_sapling";
        public override Int32 ProtocolId => 24;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dark_oak_saplingBlock(), player);
        }

    }
}
