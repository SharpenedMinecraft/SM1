using SharpenedMinecraft.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Commands.Parsers
{
    // 	A regular message, potentially including selectors. 
    public class MessageArgumentParser : ArgumentParser
    {
        public override string ID => "minecraft:message";

        public override Object Parse(CommandContext ctx)
        {
            String s = ctx.Segments[0];
            string message = "";
            //Find Selectors
            var words = s.Split(' ');
            var selectorParser = new EntityArgumentParser(false, false);
            foreach (var word in words)
            {
                if (word.StartsWith('@'))
                {
                    var res = (List<BaseEntity>)selectorParser.Parse(new CommandContext(ctx) { Segments = new String[] { word } });
                    if (res != null)
                    {
                        foreach (var entity in res)
                        {
                            message += entity.CustomName.Text + ", ";
                        }
                        if (message.EndsWith(", "))
                            message = message.Remove(message.Length - 2, 2);
                        continue;
                    }
                }
                message += word + " ";
                continue;
            }
            message = message.TrimEnd();
            return message;
        }
    }
}
