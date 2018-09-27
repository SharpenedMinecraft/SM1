using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Commands
{
    public class FunctionCommandNode : CommandNode
    {
        public override Func<CommandContext, Object> NodeFunc { get; }

        public FunctionCommandNode(Action<CommandContext> func)
        {
            this.NodeFunc = x =>
            {
                try
                {
                    func(x);
                    return true;
                }
                catch
                {
                    return null;
                }
            };
        }
    }
}
