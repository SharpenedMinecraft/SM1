
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Birch_trapdoorItem : ItemStack
    {
        public override string Id => "minecraft:birch_trapdoor";
        public override Int32 ProtocolId => 183;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Birch_trapdoorBlock(), player);
        }

    }
}
