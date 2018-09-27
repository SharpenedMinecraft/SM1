
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Orange_tulipItem : ItemStack
    {
        public override string Id => "minecraft:orange_tulip";
        public override Int32 ProtocolId => 98;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Orange_tulipBlock(), player);
        }

    }
}
