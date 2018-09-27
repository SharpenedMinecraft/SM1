
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Bone_blockItem : ItemStack
    {
        public override string Id => "minecraft:bone_block";
        public override Int32 ProtocolId => 353;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Bone_blockBlock(), player);
        }

    }
}
