
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dragon_headItem : ItemStack
    {
        public override string Id => "minecraft:dragon_head";
        public override Int32 ProtocolId => 692;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dragon_headBlock(), player);
        }

    }
}
