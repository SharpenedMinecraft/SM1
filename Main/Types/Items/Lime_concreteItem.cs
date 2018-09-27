
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Lime_concreteItem : ItemStack
    {
        public override string Id => "minecraft:lime_concrete";
        public override Int32 ProtocolId => 394;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Lime_concreteBlock(), player);
        }

    }
}
