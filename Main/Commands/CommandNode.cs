using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpenedMinecraft.Commands
{
    public abstract class CommandNode : IEquatable<CommandNode>
    {
        public List<CommandNode> CommandNodes { get; set; }
        public CommandNode RedirectNode { get; set; }
        public abstract Func<CommandContext, Object> NodeFunc { get; }
        public virtual bool RemoveOneSegment => true;
        public CommandNode()
        {
            CommandNodes = new List<CommandNode>();
        }

        public void Execute(CommandContext ctx)
        {
            CommandNode currentNode = this;
            while (currentNode.CommandNodes.Count != 0)
            {
                bool NoneFound = true;
                foreach (var node in currentNode.CommandNodes) //The first, meaning the root, will be skipped
                {
                    var newctx = ctx;
                    if (currentNode.RemoveOneSegment)
                    {
                        var v = newctx.Segments.ToList();
                        v.RemoveAt(0);
                        newctx.Segments = v.ToArray();
                    }
                    if (!(node is LiteralCommandNode))
                    if (node.CommandNodes.All(x => x is FunctionCommandNode))
                    {
                        string s = "";
                        //This is the last 'normal' node
                        foreach (var v in newctx.Segments)
                        {
                            s += v + " ";
                        }
                        s = s.Trim();
                        newctx.Segments = new string[] { s };
                    }
                    var v2 = node.NodeFunc(newctx);
                    if (v2 != null)
                    {
                        newctx.Values.Add(v2);
                        currentNode = node;
                        ctx = newctx;
                        NoneFound = false;
                        break;
                    }
                }
                if (NoneFound)
                {
                    throw new Exception(); //TODO: Argument / Literal exception
                }
            }
        }


        public CommandNode With(CommandNode node)
        {
            CommandNodes.Add(node);
            return this;
        }

        public CommandNode With(Action<CommandNodeBuilder> action)
        {
            var builder = new CommandNodeBuilder();
            action(builder);
            CommandNodes.AddRange(builder.GetCommands());
            return this;
        }

        public T3 As<T3>() where T3 : CommandNode
        {
            return (T3)this;
        }

        public Boolean Equals(CommandNode other)
        {
            if (other.GetType() == other.GetType())
            {
                return other.NodeFunc == this.NodeFunc;
            }
            return false;
        }

        [Flags]
        public enum CommandFlags : byte
        {
            Type_Root = 0x00,
            Type_Literal = 0x01,
            Type_Argument = 0x02,
            IsExecutable = 0x04,
            HasRedirect = 0x08,
            HasCustomSuggestions = 0x10
        }
    }
}
