
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class ChestItem : ItemStack
    {
        public override string Id => "minecraft:chest";
        public override Int32 ProtocolId => 143;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new ChestBlock(), player);
        }

    }
}
