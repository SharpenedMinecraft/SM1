
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Orange_woolItem : ItemStack
    {
        public override string Id => "minecraft:orange_wool";
        public override Int32 ProtocolId => 77;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Orange_woolBlock(), player);
        }

    }
}
