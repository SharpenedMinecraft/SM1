
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class AirItem : ItemStack
    {
        public override string Id => "minecraft:air";
        public override Int32 ProtocolId => 0;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new AirBlock(), player);
        }

    }
}
