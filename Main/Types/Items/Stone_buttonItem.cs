
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Stone_buttonItem : ItemStack
    {
        public override string Id => "minecraft:stone_button";
        public override Int32 ProtocolId => 162;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Stone_buttonBlock(), player);
        }

    }
}
