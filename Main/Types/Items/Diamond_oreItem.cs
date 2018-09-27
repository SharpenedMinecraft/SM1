
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Diamond_oreItem : ItemStack
    {
        public override string Id => "minecraft:diamond_ore";
        public override Int32 ProtocolId => 144;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Diamond_oreBlock(), player);
        }

    }
}
