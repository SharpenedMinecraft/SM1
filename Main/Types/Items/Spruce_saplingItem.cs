
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Spruce_saplingItem : ItemStack
    {
        public override string Id => "minecraft:spruce_sapling";
        public override Int32 ProtocolId => 20;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Spruce_saplingBlock(), player);
        }

    }
}
