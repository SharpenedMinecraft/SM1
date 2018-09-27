using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types.Enums
{
    [Flags]
    public enum DisplayedSkinParts : byte
    {
        Cape = 0x01,
        Jacket = 0x02,
        Left_Sleeve = 0x04,
        Right_Sleeve = 0x08,
        Left_Pants_Leg = 0x10,
        Right_Pants_Leg = 0x20,
        Hat = 0x40
    }
}
