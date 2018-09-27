using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types
{
    public static class Extensions
    {
        public static string GetString(this WorldType.Type value)
        {
            switch (value)
            {
                case WorldType.Type.def:
                    return "default";
                case WorldType.Type.default_1_1:
                    return "default_1_1";
                case WorldType.Type.flat:
                    return "flat";
                case WorldType.Type.largeBiomes:
                    return "largeBiomes";
                case WorldType.Type.amplified:
                    return "amplified";
            }
            throw new Exception(); //lol?
        }

        public static WorldType.Type FromString(string value)
        {
            switch (value)
            {
                case "default":
                    return WorldType.Type.def;
                case "default_1_1":
                    return WorldType.Type.default_1_1;
                case "flat":
                    return WorldType.Type.flat;
                case "largeBiomes":
                    return WorldType.Type.largeBiomes;
                case "amplified":
                    return WorldType.Type.amplified;
            }
            throw new ArgumentException("WorldType Not Found!");
        }
    }
}
