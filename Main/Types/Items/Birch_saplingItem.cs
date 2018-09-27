
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Birch_saplingItem : ItemStack
    {
        public override string Id => "minecraft:birch_sapling";
        public override Int32 ProtocolId => 21;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Birch_saplingBlock(), player);
        }

    }
}
