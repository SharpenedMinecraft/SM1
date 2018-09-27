using System;
using System.Collections.Generic;
using System.Text;
using SharpenedMinecraft.Types.Items;

namespace SharpenedMinecraft.Plugins
{
    public abstract class CustomItem : Diamond_hoeItem
    {
        public override abstract string Id { get; } 
        public sealed override Int32 ProtocolId { get; }

        public CustomItem() : base()
        {
        }
    }
}
