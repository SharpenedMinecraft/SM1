
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Nether_wart_blockItem : ItemStack
    {
        public override string Id => "minecraft:nether_wart_block";
        public override Int32 ProtocolId => 351;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Nether_wart_blockBlock(), player);
        }

    }
}
