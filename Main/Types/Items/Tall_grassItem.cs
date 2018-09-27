
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Tall_grassItem : ItemStack
    {
        public override string Id => "minecraft:tall_grass";
        public override Int32 ProtocolId => 303;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Tall_grassBlock(), player);
        }

    }
}
