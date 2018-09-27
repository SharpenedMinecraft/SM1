
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class BookshelfItem : ItemStack
    {
        public override string Id => "minecraft:bookshelf";
        public override Int32 ProtocolId => 131;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new BookshelfBlock(), player);
        }

    }
}
