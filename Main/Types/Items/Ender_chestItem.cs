
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Ender_chestItem : ItemStack
    {
        public override string Id => "minecraft:ender_chest";
        public override Int32 ProtocolId => 225;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Ender_chestBlock(), player);
        }

    }
}
