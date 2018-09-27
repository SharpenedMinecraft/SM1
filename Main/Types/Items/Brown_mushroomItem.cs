
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Brown_mushroomItem : ItemStack
    {
        public override string Id => "minecraft:brown_mushroom";
        public override Int32 ProtocolId => 102;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Brown_mushroomBlock(), player);
        }

    }
}
