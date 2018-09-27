
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Jungle_planksItem : ItemStack
    {
        public override string Id => "minecraft:jungle_planks";
        public override Int32 ProtocolId => 16;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Jungle_planksBlock(), player);
        }

    }
}
