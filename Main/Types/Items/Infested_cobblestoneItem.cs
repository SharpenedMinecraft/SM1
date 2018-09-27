
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Infested_cobblestoneItem : ItemStack
    {
        public override string Id => "minecraft:infested_cobblestone";
        public override Int32 ProtocolId => 188;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Infested_cobblestoneBlock(), player);
        }

    }
}
