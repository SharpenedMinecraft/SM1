using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Plugins;
using SharpenedMinecraft.SDK;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Blocks;
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class ExamplePlugin : McPlugin
    {
        public override string Name => "Example Plugin";

        public ExamplePlugin()
        {
            BaseEntity.RegisterEntityType(new ExampleEntity());
            ItemStack.RegisterItem(new ExampleItem());
            Block.RegisterBlock(new ExampleBlock());
            ResourceManager.Provider.Modify(builder =>
            {
                builder.ModifyItem<Iron_swordItem>(item =>
                {
                    item.ModifyModel(model =>
                    {
                        model.Parent = "";
                        model.
                    });
                });
            });
        }
    }
}
