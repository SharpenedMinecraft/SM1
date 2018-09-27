
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cyan_terracottaItem : ItemStack
    {
        public override string Id => "minecraft:cyan_terracotta";
        public override Int32 ProtocolId => 266;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cyan_terracottaBlock(), player);
        }

    }
}
