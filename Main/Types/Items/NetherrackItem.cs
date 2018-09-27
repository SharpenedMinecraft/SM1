
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class NetherrackItem : ItemStack
    {
        public override string Id => "minecraft:netherrack";
        public override Int32 ProtocolId => 177;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new NetherrackBlock(), player);
        }

    }
}
