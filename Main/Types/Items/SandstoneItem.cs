
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class SandstoneItem : ItemStack
    {
        public override string Id => "minecraft:sandstone";
        public override Int32 ProtocolId => 62;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new SandstoneBlock(), player);
        }

    }
}
