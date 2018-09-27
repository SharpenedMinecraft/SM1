
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Lapis_oreItem : ItemStack
    {
        public override string Id => "minecraft:lapis_ore";
        public override Int32 ProtocolId => 59;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Lapis_oreBlock(), player);
        }

    }
}
