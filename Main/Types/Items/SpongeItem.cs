
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class SpongeItem : ItemStack
    {
        public override string Id => "minecraft:sponge";
        public override Int32 ProtocolId => 56;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new SpongeBlock(), player);
        }

    }
}
