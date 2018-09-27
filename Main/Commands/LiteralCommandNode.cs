using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Commands
{
    public class LiteralCommandNode : CommandNode
    {
        public String name;

        public LiteralCommandNode(string text) : base()
        {
            this.name = text;
        }

        public override Func<CommandContext, Object> NodeFunc
            => ctx =>
            {
                if (ctx.Segments[0] == name)
                    return name;
                else
                    return null;
            };
    }
}
