
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Purple_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:purple_concrete_powder";
        public override Int32 ProtocolId => 415;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Purple_concrete_powderBlock(), player);
        }

    }
}
