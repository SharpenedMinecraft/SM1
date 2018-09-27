
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Azure_bluetItem : ItemStack
    {
        public override string Id => "minecraft:azure_bluet";
        public override Int32 ProtocolId => 96;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Azure_bluetBlock(), player);
        }

    }
}
