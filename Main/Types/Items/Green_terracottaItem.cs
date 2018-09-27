
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Green_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:green_terracotta";
        public override Int32 ProtocolId => 270;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Green_terracottaBlock(), player);
        }

    }
}
