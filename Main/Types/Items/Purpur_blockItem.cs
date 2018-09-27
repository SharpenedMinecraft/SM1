
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Purpur_blockItem : ItemStack
    {
        public override string Id => "minecraft:purpur_block";
        public override Int32 ProtocolId => 138;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Purpur_blockBlock(), player);
        }

    }
}
