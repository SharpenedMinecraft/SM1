
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Polished_dioriteItem : ItemStack
    {
        public override string Id => "minecraft:polished_diorite";
        public override Int32 ProtocolId => 5;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Polished_dioriteBlock(), player);
        }

    }
}
