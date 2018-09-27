
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Lime_carpetItem : ItemStack
    {
        public override string Id => "minecraft:lime_carpet";
        public override Int32 ProtocolId => 281;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Lime_carpetBlock(), player);
        }

    }
}
