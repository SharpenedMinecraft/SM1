
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Turtle_eggItem : ItemStack
    {
        public override string Id => "minecraft:turtle_egg";
        public override Int32 ProtocolId => 421;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Turtle_eggBlock(), player);
        }

    }
}
