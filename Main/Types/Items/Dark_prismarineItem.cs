
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dark_prismarineItem : ItemStack
    {
        public override string Id => "minecraft:dark_prismarine";
        public override Int32 ProtocolId => 339;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dark_prismarineBlock(), player);
        }

    }
}
