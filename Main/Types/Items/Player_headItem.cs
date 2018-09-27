
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class Player_headItem : ItemStack
    {
        public override string Id => "minecraft:player_head";
        public override Int32 ProtocolId => 689;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new Player_headBlock(), player);
        }

    }
}
