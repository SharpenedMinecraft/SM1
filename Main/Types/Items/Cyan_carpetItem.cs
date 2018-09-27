
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cyan_carpetItem : ItemStack
    {
        public override string Id => "minecraft:cyan_carpet";
        public override Int32 ProtocolId => 285;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cyan_carpetBlock(), player);
        }

    }
}
