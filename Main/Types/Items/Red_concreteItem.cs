
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Red_concreteItem : ItemStack
    {
        public override string Id => "minecraft:red_concrete";
        public override Int32 ProtocolId => 403;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Red_concreteBlock(), player);
        }

    }
}
