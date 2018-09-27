
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Jungle_trapdoorItem : ItemStack
    {
        public override string Id => "minecraft:jungle_trapdoor";
        public override Int32 ProtocolId => 184;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Jungle_trapdoorBlock(), player);
        }

    }
}
