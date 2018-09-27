
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Flower_potItem : ItemStack
    {
        public override string Id => "minecraft:flower_pot";
        public override Int32 ProtocolId => 680;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Flower_potBlock(), player);
        }

    }
}
