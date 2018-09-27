using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class ClientSettingsPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x03;

        public String Locale;
        public SByte ViewDistance;
        public ChatMode ChatMode;
        public Boolean ChatColors;
        public DisplayedSkinParts displayedSkinParts;
        public MainHand mainHand;

        public ClientSettingsPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            Locale = Read<string>();
            ViewDistance = Read<SByte>();
            ChatMode = (ChatMode)(int)Read<VarInt>();
            ChatColors = Read<bool>();
            displayedSkinParts = (DisplayedSkinParts)Read<byte>();
            mainHand = (MainHand)(int)Read<VarInt>();
            Player.Locale = Locale;
            Player.ViewDistance = ViewDistance;
            Player.ChatMode = ChatMode;
            Player.ChatColors = ChatColors;
            Player.DisplayedSkinParts = displayedSkinParts;
            Player.MainHand = mainHand;
        }
    }
}
