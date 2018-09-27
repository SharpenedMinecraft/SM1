
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Green_concreteItem : ItemStack
    {
        public override string Id => "minecraft:green_concrete";
        public override Int32 ProtocolId => 402;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Green_concreteBlock(), player);
        }

    }
}
