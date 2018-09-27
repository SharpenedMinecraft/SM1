using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types.Enums
{
    [Flags]
    public enum EntityEffect : byte
    {
        NONE = 0x00,
        OnFire = 0x01,
        Crouched = 0x02,
        //Unused = 0x04, (Riding before)
        Sprinting = 0x08,
        //Unused = 0x10, (previously eating/drinking/blocking; use hand state now)
        Invisible = 0x20,
        GlowingEffect = 0x40,
        FlyingElytra = 0x80
    }
}
