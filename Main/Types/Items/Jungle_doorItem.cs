
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Jungle_doorItem : ItemStack
    {
        public override string Id => "minecraft:jungle_door";
        public override Int32 ProtocolId => 448;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Jungle_doorBlock(), player);
        }

    }
}
