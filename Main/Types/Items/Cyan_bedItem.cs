
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cyan_bedItem : ItemStack
    {
        public override string Id => "minecraft:cyan_bed";
        public override Int32 ProtocolId => 589;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cyan_bedBlock(), player);
        }

    }
}
