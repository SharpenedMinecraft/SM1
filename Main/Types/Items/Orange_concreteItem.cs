
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Orange_concreteItem : ItemStack
    {
        public override string Id => "minecraft:orange_concrete";
        public override Int32 ProtocolId => 390;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Orange_concreteBlock(), player);
        }

    }
}
