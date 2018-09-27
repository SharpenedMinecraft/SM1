
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Crafting_tableItem : ItemStack
    {
        public override string Id => "minecraft:crafting_table";
        public override Int32 ProtocolId => 146;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Crafting_tableBlock(), player);
        }

    }
}
