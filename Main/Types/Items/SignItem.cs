
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class SignItem : ItemStack
    {
        public override string Id => "minecraft:sign";
        public override Int32 ProtocolId => 525;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new SignBlock(), player);
        }

    }
}
