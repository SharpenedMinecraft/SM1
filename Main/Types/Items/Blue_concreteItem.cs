
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Blue_concreteItem : ItemStack
    {
        public override string Id => "minecraft:blue_concrete";
        public override Int32 ProtocolId => 400;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Blue_concreteBlock(), player);
        }

    }
}
