
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Oak_barkItem : ItemStack
    {
        public override string Id => "minecraft:oak_bark";
        public override Int32 ProtocolId => 44;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Oak_barkBlock(), player);
        }

    }
}
