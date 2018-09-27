
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Creeper_headItem : ItemStack
    {
        public override string Id => "minecraft:creeper_head";
        public override Int32 ProtocolId => 691;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Creeper_headBlock(), player);
        }

    }
}
