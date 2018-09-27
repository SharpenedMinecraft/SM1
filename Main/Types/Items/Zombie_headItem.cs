
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Zombie_headItem : ItemStack
    {
        public override string Id => "minecraft:zombie_head";
        public override Int32 ProtocolId => 690;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Zombie_headBlock(), player);
        }

    }
}
