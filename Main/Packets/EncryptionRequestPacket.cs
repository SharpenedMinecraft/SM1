using SharpenedMinecraft.Cryptography;
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
    public class EncryptionRequestPacket : MinecraftPacket
    {
        public override State State => State.Login;
        public override bool Clientbound => true;
        public override int Id => 0x01;

        public String ServerID = Utils.BaseServerHash;
        public Byte[] PublicKey;
        public Int32 PublicKeyLength;
        public Byte[] VerifyToken;
        public Int32 VerifyTokenLength;

        public EncryptionRequestPacket(MinecraftClient client)
            : base(client)
        {
        }

        public override void Initialize(int length, Stream stream)
        {
            base.Initialize(length, stream);
            VerifyToken = PacketCryptography.GetRandomToken();
            PublicKey = PacketCryptography.PublicKeyToAsn1(Utils.ServerKey);
        }

        public override void WritePacket()
        {
            PublicKeyLength = PublicKey.Length;
            VerifyTokenLength = VerifyToken.Length;
            Write(ServerID);
            Write((VarInt)PublicKeyLength);
            WriteArray(PublicKey);
            Write((VarInt)VerifyTokenLength);
            WriteArray(VerifyToken);
        }
    }
}
