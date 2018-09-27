
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Mob_spawnerItem : ItemStack
    {
        public override string Id => "minecraft:mob_spawner";
        public override Int32 ProtocolId => 141;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Mob_spawnerBlock(), player);
        }

    }
}
