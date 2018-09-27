
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cyan_woolItem : ItemStack
    {
        public override string Id => "minecraft:cyan_wool";
        public override Int32 ProtocolId => 85;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cyan_woolBlock(), player);
        }

    }
}
