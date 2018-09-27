using SharpenedMinecraft;
using SharpenedMinecraft.Plugins;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class ExampleItem : CustomItem
    {
        public override string Id => "example:MyItem";
        public override void OnUse(World world, Vector3 Pos, Player player)
        {
            world.SetBlock(Pos, new ExampleBlock(), player);
        }
    }
}
