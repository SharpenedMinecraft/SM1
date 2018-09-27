
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Cyan_shulker_boxItem : ItemStack
    {
        public override string Id => "minecraft:cyan_shulker_box";
        public override Int32 ProtocolId => 366;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Cyan_shulker_boxBlock(), player);
        }

    }
}
