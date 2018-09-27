
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class JukeboxItem : ItemStack
    {
        public override string Id => "minecraft:jukebox";
        public override Int32 ProtocolId => 168;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new JukeboxBlock(), player);
        }

    }
}
