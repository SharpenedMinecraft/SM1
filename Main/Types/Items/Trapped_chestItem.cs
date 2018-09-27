
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Trapped_chestItem : ItemStack
    {
        public override string Id => "minecraft:trapped_chest";
        public override Int32 ProtocolId => 244;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Trapped_chestBlock(), player);
        }

    }
}
