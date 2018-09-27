
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brown_woolItem : ItemStack
    {
        public override string Id => "minecraft:brown_wool";
        public override Int32 ProtocolId => 88;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brown_woolBlock(), player);
        }

    }
}
