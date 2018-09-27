using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftChatMessage : MinecraftType<ChatMessage>
    {
        public MinecraftChatMessage(Stream stream) : base(stream)
        {
        }

        public override ChatMessage Read()
        {
            var v = new MinecraftString(Stream).Read();
            var v2 = ChatMessage.FromJson(v);
            return v2;
        }

        public override void Write(ChatMessage value)
        {
            new MinecraftString(Stream).Write(value.ToJson());
        }
    }
}
