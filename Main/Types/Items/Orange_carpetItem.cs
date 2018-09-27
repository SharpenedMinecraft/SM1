
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Orange_carpetItem : ItemStack
    {
        public override string Id => "minecraft:orange_carpet";
        public override Int32 ProtocolId => 277;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Orange_carpetBlock(), player);
        }

    }
}
