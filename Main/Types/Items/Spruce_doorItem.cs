
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Spruce_doorItem : ItemStack
    {
        public override string Id => "minecraft:spruce_door";
        public override Int32 ProtocolId => 446;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Spruce_doorBlock(), player);
        }

    }
}
