
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Carved_pumpkinItem : ItemStack
    {
        public override string Id => "minecraft:carved_pumpkin";
        public override Int32 ProtocolId => 176;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Carved_pumpkinBlock(), player);
        }

    }
}
