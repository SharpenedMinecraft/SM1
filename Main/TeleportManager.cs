using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;

namespace SharpenedMinecraft
{
    public class TeleportManager
    {
        public static Dictionary<int, TeleportInformation> teleports = new Dictionary<int, TeleportInformation>();
        public static Random random = new Random();

        const int maxvalue = 127; //VarInt Block Max, else more bytes = error

        public int StartTeleport(TeleportInformation information)
        {
            while (true)
            {
                var i = random.Next(maxvalue);
                if (!teleports.ContainsKey(i))
                {
                    teleports.Add(i, information);
                    return i;
                }
            }
        }

        public bool EndTeleport(int id)
        {
            var v = teleports.ContainsKey(id);
            if (v)
                teleports.Remove(id);
            return v;
        }
    }
}