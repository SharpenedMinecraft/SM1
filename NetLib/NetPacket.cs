using System;
using System.IO;

namespace SharpenedMinecraft.NetLib
{
    public class NetPacket : INetPacket
    {
        public int Length { get; set; }

        public virtual void Dispose()
        {
        }
    }
}