
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Purple_woolItem : ItemStack
    {
        public override string Id => "minecraft:purple_wool";
        public override Int32 ProtocolId => 86;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Purple_woolBlock(), player);
        }

    }
}
