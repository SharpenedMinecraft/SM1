
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Redstone_torchItem : ItemStack
    {
        public override string Id => "minecraft:redstone_torch";
        public override Int32 ProtocolId => 161;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Redstone_torchBlock(), player);
        }

    }
}
