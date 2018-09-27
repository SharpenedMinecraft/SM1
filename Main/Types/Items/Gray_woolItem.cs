
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Gray_woolItem : ItemStack
    {
        public override string Id => "minecraft:gray_wool";
        public override Int32 ProtocolId => 83;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Gray_woolBlock(), player);
        }

    }
}
