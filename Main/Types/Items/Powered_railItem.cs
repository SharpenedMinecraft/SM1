
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Powered_railItem : ItemStack
    {
        public override string Id => "minecraft:powered_rail";
        public override Int32 ProtocolId => 66;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Powered_railBlock(), player);
        }

    }
}
