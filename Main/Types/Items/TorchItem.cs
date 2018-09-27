
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class TorchItem : ItemStack
    {
        public override string Id => "minecraft:torch";
        public override Int32 ProtocolId => 134;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new TorchBlock(), player);
        }

    }
}
