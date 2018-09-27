using System;
using System.Collections.Generic;
using SharpenedMinecraft.Commands;
using SharpenedMinecraft.Packets;
using SharpenedMinecraft.Types;

namespace SharpenedMinecraft
{
    public static class ChatManager
    {
        public static void Process(ChatMessage msg, MinecraftClient client)
        {
            if (msg.Text.StartsWith('/'))
            {
                HandleCommand(msg.Text, client);
            }
            else
                client.SendToAll(new ChatMessagePacketClient(client) {
                    msg = msg,
                    position = Types.Enums.ChatPosition.Chat
                });
        }

        public static void Broadcast(ChatMessage v)
        {
            World.Players[0].Client.SendToAll(new ChatMessagePacketClient(null)
            {
                msg = v,
                position = Types.Enums.ChatPosition.Chat
            });
        }

        private static RootCommandNode root;

        static ChatManager()
        {
            root = DefaultCommands.GetCommands();
        }

        private static void HandleCommand(string text, MinecraftClient client)
        {
            if (!text.StartsWith('/'))
                throw new ArgumentException();
            text = text.Remove(0, 1);

            try
            {
                root.Execute(new CommandContext(text, client.Player, client.Player.Transform.Position, client.Player));
            }
            catch
            {
                client.Send(new ChatMessagePacketClient(client)
                {
                    msg = new ChatMessage()
                    {
                        Text = "Error Executing Command",
                        Color = "red"
                    }
                });
            }
        }
    }
}