
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cobblestone_wallItem : ItemStack
    {
        public override string Id => "minecraft:cobblestone_wall";
        public override Int32 ProtocolId => 233;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cobblestone_wallBlock(), player);
        }

    }
}
