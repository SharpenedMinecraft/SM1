using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Commands.Parsers
{
    public class StringArgumentParser : ArgumentParser
    {
        public override String ID
            => "brigadier:string";

        public override Object Parse(CommandContext ctx)
        {
            return ctx.Segments[0];
        }
    }
}
