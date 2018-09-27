
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Chorus_flowerItem : ItemStack
    {
        public override string Id => "minecraft:chorus_flower";
        public override Int32 ProtocolId => 137;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Chorus_flowerBlock(), player);
        }

    }
}
