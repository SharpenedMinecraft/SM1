
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Purple_carpetItem : ItemStack
    {
        public override string Id => "minecraft:purple_carpet";
        public override Int32 ProtocolId => 286;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Purple_carpetBlock(), player);
        }

    }
}
