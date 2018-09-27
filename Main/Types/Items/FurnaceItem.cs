
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class FurnaceItem : ItemStack
    {
        public override string Id => "minecraft:furnace";
        public override Int32 ProtocolId => 148;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new FurnaceBlock(), player);
        }

    }
}
