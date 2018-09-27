using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Enums;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpenedMinecraft.Packets
{
    public class PlayerListItem : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override bool Clientbound => true;
        public override int Id => 0x2F;

        public PlayerListItem(MinecraftClient client)
            : base(client)
        {

        }

        public override void Initialize(int length, Stream stream)
        {
            base.Initialize(length, stream);
        }

        public PlayerListAction Action;
        public Player[] players;

        public override void WritePacket()
        {
            Write((VarInt)(int)Action);
            Write((VarInt)players.Length);

            foreach (var v in players)
            {
                Write(v.UUID.ToUInt128());

                var s = "";
                foreach (var v6 in players)
                    s += $"{v6.Name} ({v6.EntityId})";

                switch (Action)

                {
                    case PlayerListAction.AddPlayer:
                        Console.WriteLine("Adding Players " + s);
                        Write(v.Name);
                        Write((VarInt)0);
                        //TODO: Implement Skins here
                        //(here woud go the "properties" array from http://wiki.vg/Mojang_API#UUID_-.3E_Profile_.2B_Skin.2FCape
                        //the "0" above is a 0 for no elements
                        Write((VarInt)(int)v.GameMode);
                        VarInt ping = -1;
                        if (Client.Ping != null)
                            ping = (int)Client.Ping.TotalMilliseconds;
                        Write(ping);
                        if (v.CustomName.Text != v.Name)
                        {
                            Write(true);
                            Write(v.CustomName);
                        }
                        else
                            Write(false);
                        break;

                    case PlayerListAction.UpdateGameMode:
                        Console.WriteLine("Updated Gamemode of " + s);
                        Write((VarInt)(int)v.GameMode);
                        break;
                    case PlayerListAction.UpdateLatency:
                        Console.WriteLine("Updated Latency of " + s);
                        Write((VarInt)(int)Client.Ping.TotalMilliseconds);
                        break;
                    case PlayerListAction.UpdateDisplayName:
                        Console.WriteLine("Updated Name of " + s);
                        // Color?                                           (same above)
                        if (v.CustomName.Text != v.Name) //TODO: Fix this simple
                        {
                            Write(true);
                            Write(v.CustomName);
                        }
                        else
                            Write(false);
                        break;
                    case PlayerListAction.RemovePlayer:
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
