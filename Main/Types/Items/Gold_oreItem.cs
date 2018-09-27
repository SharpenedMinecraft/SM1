
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Gold_oreItem : ItemStack
    {
        public override string Id => "minecraft:gold_ore";
        public override Int32 ProtocolId => 29;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Gold_oreBlock(), player);
        }

    }
}
