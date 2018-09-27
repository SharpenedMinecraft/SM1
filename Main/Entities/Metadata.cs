using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Entities
{
    public class Metadata
    {
        public Dictionary<int, MetadataInfo> Infos { get; set; }

        public struct MetadataInfo
        {
            public Type Type;
            public Object value;
        }
    }
}
