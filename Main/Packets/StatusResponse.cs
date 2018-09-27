using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class StatusResponse : MinecraftPacket
    {
        public override State State => State.Status;
        public override bool Clientbound => true;
        public override int Id => 0x00;

        //public StatusResponsePayload payload;
        public string payload;

        public StatusResponse(MinecraftClient client)
            : base(client)
        {
        }

        public override void Initialize(int length, Stream stream) 
        { 
            base.Initialize(length, stream);
            //payload = new StatusResponsePayload();
            //payload.Version = new Entities.Version();
            //payload.Version.Protocol = Utils.ProtocolVersion;
            //payload.Version.Name = "CS.1.12.2";
            //payload.Players = new Players();
            //payload.Players.Max = 10000;
            //payload.Players.Online = PacketFactory.World.Players.Count;
            //payload.Description = new Description();
            //payload.Description.Text = "Hallo, Ich bin ein C# Minecraft Server!";

            string Version = Utils.UserFriendlyName;
            string ProtocolVersion = Utils.ProtocolVersion.ToString();
            string OnlinePlayers = World.WorldPlayers.Count.ToString();
            string MaxPlayer = "1000";
            string MOTD = "Hallo, Ich bin ein C# Minecraft Server!";
            payload = "{\r\n    \"version\": {\r\n        \"name\": \"" + Version
            + "\",\r\n        \"protocol\": " + ProtocolVersion
            + "\r\n    },\r\n    \"players\": {\r\n        \"max\": " + MaxPlayer
            + ",\r\n        \"online\": " + OnlinePlayers
            + "\r\n    },\t\r\n    \"description\": {\r\n        \"text\": \"" + MOTD
            + "\"\r\n    }\r\n}";
        }

        public override void WritePacket()
        {
            //var s = payload.ToJson();
            //stream.WriteString8(s);

            Write(payload);
        }
    }
}
