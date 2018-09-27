
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class RailItem : ItemStack
    {
        public override string Id => "minecraft:rail";
        public override Int32 ProtocolId => 150;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new RailBlock(), player);
        }

    }
}
