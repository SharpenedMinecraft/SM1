
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Pink_concreteItem : ItemStack
    {
        public override string Id => "minecraft:pink_concrete";
        public override Int32 ProtocolId => 395;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Pink_concreteBlock(), player);
        }

    }
}
