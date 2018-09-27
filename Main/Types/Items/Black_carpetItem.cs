
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Black_carpetItem : ItemStack
    {
        public override string Id => "minecraft:black_carpet";
        public override Int32 ProtocolId => 291;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Black_carpetBlock(), player);
        }

    }
}
