
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Lime_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:lime_terracotta";
        public override Int32 ProtocolId => 262;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Lime_terracottaBlock(), player);
        }

    }
}
