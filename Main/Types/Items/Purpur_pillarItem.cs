
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Purpur_pillarItem : ItemStack
    {
        public override string Id => "minecraft:purpur_pillar";
        public override Int32 ProtocolId => 139;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Purpur_pillarBlock(), player);
        }

    }
}
