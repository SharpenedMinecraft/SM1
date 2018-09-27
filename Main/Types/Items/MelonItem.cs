
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class MelonItem : ItemStack
    {
        public override string Id => "minecraft:melon";
        public override Int32 ProtocolId => 202;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new MelonBlock(), player);
        }

    }
}
