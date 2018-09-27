using System.Collections.Generic;

namespace SharpenedMinecraft.Commands
{
    public class CommandNodeBuilder
    {
        private List<CommandNode> commands;
        public CommandNodeBuilder()
        {
            commands = new List<CommandNode>();
        }

        public CommandNodeBuilder With(CommandNode node)
        {
            commands.Add(node);
            return this;
        }

        public CommandNode[] GetCommands()
            => commands.ToArray();
    }
}