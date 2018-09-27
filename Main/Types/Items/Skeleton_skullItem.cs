
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Skeleton_skullItem : ItemStack
    {
        public override string Id => "minecraft:skeleton_skull";
        public override Int32 ProtocolId => 687;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Skeleton_skullBlock(), player);
        }

    }
}
