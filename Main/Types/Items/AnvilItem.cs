
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class AnvilItem : ItemStack
    {
        public override string Id => "minecraft:anvil";
        public override Int32 ProtocolId => 241;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new AnvilBlock(), player);
        }

    }
}
