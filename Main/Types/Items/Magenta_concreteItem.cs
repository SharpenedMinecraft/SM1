
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Magenta_concreteItem : ItemStack
    {
        public override string Id => "minecraft:magenta_concrete";
        public override Int32 ProtocolId => 391;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Magenta_concreteBlock(), player);
        }

    }
}
