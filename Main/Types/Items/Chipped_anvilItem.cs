
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Chipped_anvilItem : ItemStack
    {
        public override string Id => "minecraft:chipped_anvil";
        public override Int32 ProtocolId => 242;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Chipped_anvilBlock(), player);
        }

    }
}
