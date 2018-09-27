
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class DropperItem : ItemStack
    {
        public override string Id => "minecraft:dropper";
        public override Int32 ProtocolId => 256;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new DropperBlock(), player);
        }

    }
}
