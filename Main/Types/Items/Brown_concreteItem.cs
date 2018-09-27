
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brown_concreteItem : ItemStack
    {
        public override string Id => "minecraft:brown_concrete";
        public override Int32 ProtocolId => 401;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brown_concreteBlock(), player);
        }

    }
}
