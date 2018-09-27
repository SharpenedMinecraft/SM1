
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Wither_skeleton_skullItem : ItemStack
    {
        public override string Id => "minecraft:wither_skeleton_skull";
        public override Int32 ProtocolId => 688;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Wither_skeleton_skullBlock(), player);
        }

    }
}
