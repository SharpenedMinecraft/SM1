
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Structure_voidItem : ItemStack
    {
        public override string Id => "minecraft:structure_void";
        public override Int32 ProtocolId => 354;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Structure_voidBlock(), player);
        }

    }
}
