
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Note_blockItem : ItemStack
    {
        public override string Id => "minecraft:note_block";
        public override Int32 ProtocolId => 65;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Note_blockBlock(), player);
        }

    }
}
