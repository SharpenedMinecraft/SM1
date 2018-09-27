
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Dragon_eggItem : ItemStack
    {
        public override string Id => "minecraft:dragon_egg";
        public override Int32 ProtocolId => 221;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Dragon_eggBlock(), player);
        }

    }
}
