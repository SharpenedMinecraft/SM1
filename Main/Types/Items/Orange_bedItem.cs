
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Orange_bedItem : ItemStack
    {
        public override string Id => "minecraft:orange_bed";
        public override Int32 ProtocolId => 581;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Orange_bedBlock(), player);
        }

    }
}
