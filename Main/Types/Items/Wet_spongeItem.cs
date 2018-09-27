
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Wet_spongeItem : ItemStack
    {
        public override string Id => "minecraft:wet_sponge";
        public override Int32 ProtocolId => 57;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Wet_spongeBlock(), player);
        }

    }
}
