
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Orange_stained_glassItem : ItemStack
    {
        public override string Id => "minecraft:orange_stained_glass";
        public override Int32 ProtocolId => 306;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Orange_stained_glassBlock(), player);
        }

    }
}
