
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class PeonyItem : ItemStack
    {
        public override string Id => "minecraft:peony";
        public override Int32 ProtocolId => 302;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new PeonyBlock(), player);
        }

    }
}
