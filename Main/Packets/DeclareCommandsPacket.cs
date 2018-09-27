using SharpenedMinecraft.Commands;
using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpenedMinecraft.Packets
{
    public class DeclareCommandsPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x11;

        public DeclareCommandsPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void WritePacket()
        {
            var root = DefaultCommands.GetCommands();
            HashSet<CommandNode> nodes = new HashSet<CommandNode>();
            HashSet<CommandNode> Work = new HashSet<CommandNode>()
            {
                root
            };

            while (Work.Count != 0)
            {
                
                foreach (var v in Work.ToArray())
                {
                    nodes.Add(v);
                    Work.Remove(v);
                    foreach (var v2 in v.CommandNodes)
                        if (v2.GetType() != typeof(FunctionCommandNode))
                            Work.Add(v2);
                }
            }
            var array = nodes.Reverse().ToArray();
            Write((VarInt)array.Length);
            foreach (var v in array)
                WriteNode(v, array);
            var rootI = Array.IndexOf(array, array.First(x => x.GetType() == typeof(RootCommandNode)));
            Write((VarInt)rootI);
        }

        private void WriteNode(CommandNode v, CommandNode[] Other)
        {
            var flags = GetFlags(v);
            Write((byte)flags);
            Write((VarInt)v.CommandNodes.ToArray().Length);
            if ((flags & CommandNode.CommandFlags.IsExecutable) != 0)
            {
                List<int> Indices = new List<int>();
                foreach (var v2 in v.CommandNodes)
                    Indices.Add(Array.IndexOf(Other, v2)); //lets just assume its there
                WriteArray(Indices.ToArray());
            }
            if ((flags & CommandNode.CommandFlags.HasRedirect) != 0)
                Write(Array.IndexOf(Other, v.RedirectNode));
            if (v is LiteralCommandNode)
                Write((v as LiteralCommandNode).name);
            if (v is ArgumentCommandNode)
            {
                var x2 = v as ArgumentCommandNode;
                Write(x2.name);
                Write(x2.parser.ID);
                //TODO: properties of parser
            }

            /*if ((flags & CommandNode.CommandFlags.HasCustomSuggestions) != 0)
                Write(SuggestionType);*/ //TODO: Suggestion Type
        }

        private CommandNode.CommandFlags GetFlags(CommandNode n)
        {
            CommandNode.CommandFlags v;
            if (n is RootCommandNode)
                v = CommandNode.CommandFlags.Type_Root;
            else if (n is ArgumentCommandNode)
                v = CommandNode.CommandFlags.Type_Argument;
            else if (n is LiteralCommandNode)
                v = CommandNode.CommandFlags.Type_Literal;
            //this wont happen
            else
                throw new Exception();

            if (n.RedirectNode != null)
                v |= CommandNode.CommandFlags.HasRedirect;
            if (n.CommandNodes.All(x => x.GetType() == typeof(FunctionCommandNode)))
                v |= CommandNode.CommandFlags.IsExecutable;
            return v;
        }
    }
}
