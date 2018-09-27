
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class ConduitItem : ItemStack
    {
        public override string Id => "minecraft:conduit";
        public override Int32 ProtocolId => 443;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new ConduitBlock(), player);
        }

    }
}
