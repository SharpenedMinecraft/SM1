
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class BedrockItem : ItemStack
    {
        public override string Id => "minecraft:bedrock";
        public override Int32 ProtocolId => 25;
      
        
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new BedrockBlock(), player);
        }

    }
}
