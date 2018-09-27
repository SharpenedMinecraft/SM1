using SharpenedMinecraft.Commands.Parsers;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.Text;
using SharpenedMinecraft.Packets;

namespace SharpenedMinecraft.Commands
{
    public static class DefaultCommands
    {
        public static RootCommandNode GetCommands()
        {
            return new RootCommandNode()
                .With(builder =>
                {
                    builder
                    .With(new LiteralCommandNode("say")
                        .With(new ArgumentCommandNode("message", new MessageArgumentParser())
                            .With(new FunctionCommandNode(x
                                => ChatManager.Broadcast($"[{x.Caller.Name}] {x.Values[1]}")))));

                    builder.With(new LiteralCommandNode("ping")
                        .With(new FunctionCommandNode(x => x.Caller.Client.Send(new ChatMessagePacketClient(x.Caller.Client)
                        {
                            msg = new ChatMessage()
                            {
                                Text = $"Your Ping is: {x.Caller.Client.Ping.TotalMilliseconds}ms"
                            }
                        }))));
                    #region DEBUG Command
                    builder.With(new LiteralCommandNode("debug")
                        .With(new FunctionCommandNode(ctx =>
                        {
                            var client = ctx.Caller.Client;
                            if (DebugInfos.TryGetValue(ctx.Caller.UUID, out DebugCommandInfo info))
                            {
                                info.Stop(out TimeSpan time, out long Ticks);
                                client.Send(new ChatMessagePacketClient(client)
                                {
                                    msg = new ChatMessage()
                                    {
                                        Text = $"Stopped Debugging: {Environment.NewLine}" +
                                        $"You Debugged for {time.TotalSeconds} seconds.{Environment.NewLine}" +
                                        $"With an Average TPS of {Ticks / time.TotalSeconds} (Total: {Ticks}",
                                    }
                                });
                                DebugInfos.Remove(ctx.Caller.UUID);
                            }
                            else
                            {
                                var info2 = new DebugCommandInfo();
                                info2.Start();
                                client.Send(new ChatMessagePacketClient(client)
                                {
                                    msg = new ChatMessage()
                                    {
                                        Text = $"Started Debugging",
                                    }
                                });
                                DebugInfos.Add(ctx.Caller.UUID, info2);
                            }
                        })));
                    #endregion

                    builder.With(new LiteralCommandNode("summon")
                        .With(new ArgumentCommandNode("entityId", new StringArgumentParser())
                            .With(new FunctionCommandNode(x => BaseEntity.Summon((string)x.Values[1], x.Position)))));


                }).As<RootCommandNode>();
        }

        private class DebugCommandInfo
        {
            public DateTime Started;
            public long Ticks;

            public void Start()
            {
                Tick.OnTick += OnTick;
                Started = DateTime.UtcNow;
                Ticks = 0;
            }

            public void Stop(out TimeSpan time, out long Ticks)
            {
                Tick.OnTick -= OnTick;
                time = DateTime.UtcNow - Started;
                Ticks = this.Ticks;
                return;
            }

            private void OnTick()
            => Ticks++;
        }
        private static Dictionary<Guid, DebugCommandInfo> DebugInfos = new Dictionary<Guid, DebugCommandInfo>();
    }
}
