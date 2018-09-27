
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class IceItem : ItemStack
    {
        public override string Id => "minecraft:ice";
        public override Int32 ProtocolId => 164;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new IceBlock(), player);
        }

    }
}
