
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Jungle_buttonItem : ItemStack
    {
        public override string Id => "minecraft:jungle_button";
        public override Int32 ProtocolId => 238;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Jungle_buttonBlock(), player);
        }

    }
}
