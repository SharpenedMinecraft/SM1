using SharpenedMinecraft.Cryptography;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class LoginSuccessPacket : MinecraftPacket
    {
        public override State State => State.Login;
        public override bool Clientbound => true;
        public override int Id => 0x02;

        public string UUID;
        public string Username;

        public LoginSuccessPacket(MinecraftClient client)
            : base(client)
        {
        }

        public override void WritePacket()
        {
            Username = Player.Name;

            if ((Client.Server).Configuration.OnlineMode)
                if (Client.Encryption)
                    Player.UUID = Utils.GetUUID(Player,
                        Utils.GetHash(Utils.BaseServerHash,
                        Client.Crypto.Key,
                        PacketCryptography.PublicKeyToAsn1(Utils.ServerKey)))
                        .Result;
                else
                    Player.UUID = Utils.GetUUID(Player).Result;
            else
                Player.UUID = Utils.NameGuidFromBytes(Encoding.UTF8.GetBytes($"OfflinePlayer:{Player.Name}"));

            UUID = Player.UUID.ToString();
            Write(UUID);
            Write(Username);

            Client.state = State.Play;

            Client.Send(new JoinGamePacket(Client));
            Client.Send(new ServerDifficultyPacket(Client));
            Client.Send(new SpawnPositionPacket(Client));
            Client.Send(new PlayerAbilitiesPacket(Client));
            DoTheChunks();
            DoTheEntities();
            //TODO: Enable Declare Commands
             //Client.Send(new DeclareCommandsPacket(Client));
            Client.Send(new PlayerPositionAndLookPacketClient(Client)
            {
                Flags = TransformFlags.NONE
            });
            DoWelcomeStuff();
        }

        private void DoTheEntities()
        {
            foreach (var v in World.WorldEntities)
            {
                BaseEntity.SummonPacket(v, Client);
                Client.Send(new UpdateEntityMetadataPacket(Client)
                {
                    entity = v,
                    force = true
                });
            }
        }

        private void DoWelcomeStuff()
        {
            Client.Send(new ChatMessagePacketClient(Client)
            {
                msg = new ChatMessage()
                {
                    Text = "Welcome, " + Client.Player.Name,
                    Color = "yellow"
                },
                position = ChatPosition.Chat
            });
            Client.Send(new ChatMessagePacketClient(Client)
            {
                msg = new ChatMessage()
                {
                    Text = $"Hey,\n" +
                    $"{Player.UUID}\n" +
                    $"{Player.Name}\n"
                },
                position = ChatPosition.Chat
            });
            /*var ps = World.Players.Where(x => x != Client.Player).ToArray();
            Client.Send(new PlayerListItem(Client)
            {
                Action = Enums.PlayerListAction.AddPlayer,
                players = ps
            });*/

            //Update others
            Client.SendToAll(new PlayerListItem(null)
            {
                Action = Enums.PlayerListAction.AddPlayer,
                players = new Player[] { Player }
            });
            Client.SendToAll(new SpawnPlayerPacket(null)
            {
                player = Player
            }, x => ((MinecraftClient)x).Player != Player);

            //Update own stuff
            foreach (var p in World.Players)
            {
                if (p == null || p.Client.state != State.Play)
                    continue;
                Client.Send(new PlayerListItem(Client)
                {
                    Action = Enums.PlayerListAction.AddPlayer,
                    players = new Player[] { p }
                });
                if (p != Client.Player)
                    Client.Send(new SpawnPlayerPacket(Client)
                    {
                        player = p
                    });
            }
        }

        private void DoTheChunks()
        {
            //7x7 Chunks
            TypeUtils.WorldToChunkPosition(Player.Transform.Position, out Vector3 ChunkPos, out Vector3 RelativeChunkPos);
            ChunkPos.Y = 0;
            for (int x = 0; x <= 6; x++)
            {
                for (int z = 0; z <= 6; z++)
                {
                    var x2 = x - 3;
                    var z2 = z - 3;
                    Client.Send(new ChunkDataPacket(Client)
                    {
                        GroundUpContinuous = true,
                        chunk = World.GetChunkAt(ChunkPos + new Vector3(x2, 0, z2))
                    });
                    Client.Send(new ChatMessagePacketClient(Client)
                    {
                        msg = $"Loaded Chunk At X:{x2}, Z:{z2}",
                        position = ChatPosition.Chat
                    });
                }
            }
        }
    }
}
