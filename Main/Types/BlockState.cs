using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types
{
    public class BlockState
    {
        private Dictionary<string, string> Properties { get; }
        public int Id { get; }

        public BlockState(int Id, Dictionary<string, string> Properties)
        {
            this.Id = Id;
            this.Properties = Properties;
        }
    }
}
