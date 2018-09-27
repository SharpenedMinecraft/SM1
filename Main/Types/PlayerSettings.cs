using SharpenedMinecraft.Types.Enums;

namespace SharpenedMinecraft
{
    public class PlayerSettings
    {
        //TODO: Locale Enum?
        public string Locale { get; set; }
        public int ViewDistance { get; set; }
        public ChatMode ChatMode { get; set; }
        public bool ChatColors { get; set; }
        public DisplayedSkinParts DisplayedSkinParts { get; set; }
        public MainHand MainHand { get; set; }

        public PlayerSettings()
        {
            
        }
    }
}