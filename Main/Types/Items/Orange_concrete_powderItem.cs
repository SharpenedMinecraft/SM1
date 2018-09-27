
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Orange_concrete_powderItem : ItemStack
    {
        public override string Id => "minecraft:orange_concrete_powder";
        public override Int32 ProtocolId => 406;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Orange_concrete_powderBlock(), player);
        }

    }
}
