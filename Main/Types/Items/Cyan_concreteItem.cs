
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cyan_concreteItem : ItemStack
    {
        public override string Id => "minecraft:cyan_concrete";
        public override Int32 ProtocolId => 398;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cyan_concreteBlock(), player);
        }

    }
}
