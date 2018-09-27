
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Mushroom_stemItem : ItemStack
    {
        public override string Id => "minecraft:mushroom_stem";
        public override Int32 ProtocolId => 199;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Mushroom_stemBlock(), player);
        }

    }
}
