
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Gray_concreteItem : ItemStack
    {
        public override string Id => "minecraft:gray_concrete";
        public override Int32 ProtocolId => 396;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Gray_concreteBlock(), player);
        }

    }
}
