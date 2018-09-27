
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Enchanting_tableItem : ItemStack
    {
        public override string Id => "minecraft:enchanting_table";
        public override Int32 ProtocolId => 217;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Enchanting_tableBlock(), player);
        }

    }
}
