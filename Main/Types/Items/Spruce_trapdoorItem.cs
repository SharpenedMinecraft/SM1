
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Spruce_trapdoorItem : ItemStack
    {
        public override string Id => "minecraft:spruce_trapdoor";
        public override Int32 ProtocolId => 182;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Spruce_trapdoorBlock(), player);
        }

    }
}
