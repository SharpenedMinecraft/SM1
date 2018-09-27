
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class DirtItem : ItemStack
    {
        public override string Id => "minecraft:dirt";
        public override Int32 ProtocolId => 9;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new DirtBlock(), player);
        }

    }
}
