
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Mossy_cobblestone_wallItem : ItemStack
    {
        public override string Id => "minecraft:mossy_cobblestone_wall";
        public override Int32 ProtocolId => 234;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Mossy_cobblestone_wallBlock(), player);
        }

    }
}
