
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Magenta_woolItem : ItemStack
    {
        public override string Id => "minecraft:magenta_wool";
        public override Int32 ProtocolId => 78;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Magenta_woolBlock(), player);
        }

    }
}
