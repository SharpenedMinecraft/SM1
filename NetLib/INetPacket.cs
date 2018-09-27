using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.NetLib
{
    public interface INetPacket : IDisposable
    {
        int Length { get; set; }
    }
}
