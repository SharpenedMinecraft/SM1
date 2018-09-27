
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Damaged_anvilItem : ItemStack
    {
        public override string Id => "minecraft:damaged_anvil";
        public override Int32 ProtocolId => 243;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Damaged_anvilBlock(), player);
        }

    }
}
