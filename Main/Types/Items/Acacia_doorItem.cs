
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Acacia_doorItem : ItemStack
    {
        public override string Id => "minecraft:acacia_door";
        public override Int32 ProtocolId => 449;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Acacia_doorBlock(), player);
        }

    }
}
