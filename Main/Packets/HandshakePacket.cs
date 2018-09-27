using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    //http://wiki.vg/Protocol#Handshake
    public class HandshakePacket : MinecraftPacket
    {
        public override State State => State.Handshaking;
        public override bool Serverbound => true;
        public override int Id => 0x00;

        public Int32 ProtocolVersion;
        public String ServerAdress;
        public UInt16 Port;
        public State nextState;

        public HandshakePacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            ProtocolVersion = Read<VarInt>();
            ServerAdress = Read<String>();
            Port = Read<UInt16>();
            nextState = (State)(int)Read<VarInt>();

            if (ProtocolVersion != Utils.ProtocolVersion)
                throw new EndOfStreamException($"Wrong Protocol Version (expected: {Utils.ProtocolVersion} got {ProtocolVersion})");

            //TODO: Port, ProtocolVersion
            Player.UsedServerIP = ServerAdress;
            Client.state = nextState;
        }
    }
}
