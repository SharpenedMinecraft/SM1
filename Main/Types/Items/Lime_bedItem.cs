
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Lime_bedItem : ItemStack
    {
        public override string Id => "minecraft:lime_bed";
        public override Int32 ProtocolId => 585;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Lime_bedBlock(), player);
        }

    }
}
