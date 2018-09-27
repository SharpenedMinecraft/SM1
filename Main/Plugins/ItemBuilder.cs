using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Plugins
{
    public class ItemBuilder
    {
        private ItemResource _r;

        public ItemBuilder(ItemResource r)
        {
            _r = r;
        }

        public ItemResource Build()
            => _r;
    }
}
