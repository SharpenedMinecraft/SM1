
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Birch_barkItem : ItemStack
    {
        public override string Id => "minecraft:birch_bark";
        public override Int32 ProtocolId => 46;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Birch_barkBlock(), player);
        }

    }
}
