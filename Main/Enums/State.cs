using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types.Enums
{
    public enum State : int
    {
        Handshaking = 0,
        Status = 1,
        Login = 2,
        Play = 3
    }
}
