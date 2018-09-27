using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Commands
{
    public class ArgumentCommandNode : CommandNode
    {
        public String name;
        public ArgumentParser parser;

        public ArgumentCommandNode(string name, ArgumentParser parser) : base()
        {
            this.name = name;
            this.parser = parser;
        }

        public override Func<CommandContext, Object> NodeFunc
            => ctx => parser.Parse(ctx);
    }
}
