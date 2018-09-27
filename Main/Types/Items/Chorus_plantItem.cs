
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Chorus_plantItem : ItemStack
    {
        public override string Id => "minecraft:chorus_plant";
        public override Int32 ProtocolId => 136;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Chorus_plantBlock(), player);
        }

    }
}
