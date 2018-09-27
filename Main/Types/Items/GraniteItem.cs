
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class GraniteItem : ItemStack
    {
        public override string Id => "minecraft:granite";
        public override Int32 ProtocolId => 2;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new GraniteBlock(), player);
        }

    }
}
