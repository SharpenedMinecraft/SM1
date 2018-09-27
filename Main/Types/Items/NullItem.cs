using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{
    public class NullItem : ItemStack
    {
        public override string Id => "custom:NULL";
        public override Int32 ProtocolId => -1;
    }
}
