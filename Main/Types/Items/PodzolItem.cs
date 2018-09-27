
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class PodzolItem : ItemStack
    {
        public override string Id => "minecraft:podzol";
        public override Int32 ProtocolId => 11;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new PodzolBlock(), player);
        }

    }
}
