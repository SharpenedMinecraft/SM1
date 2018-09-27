using SharpenedMinecraft.Cryptography;
using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class EncryptionResponsePacket : MinecraftPacket
    {
        public override State State => State.Login;
        public override bool Serverbound => true;
        public override int Id => 0x01;


        public Byte[] SharedSecret;
        public Int32 SharedSecretLength;
        public Byte[] VerifyToken;
        public Int32 VerifyTokenLength;

        public EncryptionResponsePacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            SharedSecretLength = Read<VarInt>();
            SharedSecret = ReadArray<byte>(SharedSecretLength);
            VerifyTokenLength = Read<VarInt>();
            VerifyToken = ReadArray<byte>(VerifyTokenLength);

            VerifyToken = PacketCryptography.Decrypt(VerifyToken);

            if (!VerifyToken.SequenceEqual(PacketCryptography.VerifyToken))
            {
                Client.Send(new DisconnectLoginPaket(Client)
                {
                    Reason = new ChatMessage()
                    {
                        Text = "Verification Failed"
                    }
                });
                return;
            }

            SharedSecret = PacketCryptography.Decrypt(SharedSecret);

            var v = Utils.GetUUID(Player, (Utils.GetHash(Utils.BaseServerHash,
                SharedSecret,
                PacketCryptography.PublicKeyToAsn1(Utils.ServerKey))));

            Client.Crypto = PacketCryptography.GenerateAes(SharedSecret);

            var v2 = v.GetAwaiter().GetResult();
            if (v2 == null)
            {
                Client.Send(new DisconnectLoginPaket(Client)
                {
                    Reason = new ChatMessage()
                    {
                        Text = "Coud not get UUID"
                    }
                });
                return;
            }
            else
                Player.UUID = v2;

            Client.Send(new LoginSuccessPacket(Client));
        }
    }
}
