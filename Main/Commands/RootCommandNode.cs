using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Commands
{
    public class RootCommandNode : CommandNode
    {
        public override bool RemoveOneSegment => false;
        public RootCommandNode() : base()
        {
        }

        public override Func<CommandContext, Object> NodeFunc
            => ctx =>
            {
                return null;
            };
    }
}
