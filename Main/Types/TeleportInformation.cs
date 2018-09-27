using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public class TeleportInformation
    {
        public DateTime CreateTime;

        public TeleportInformation()
        {
            CreateTime = DateTime.UtcNow;
        }
    }
}
