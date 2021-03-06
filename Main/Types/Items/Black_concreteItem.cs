
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Black_concreteItem : ItemStack
    {
        public override string Id => "minecraft:black_concrete";
        public override Int32 ProtocolId => 404;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Black_concreteBlock(), player);
        }

    }
}
