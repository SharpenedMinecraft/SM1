using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using System.Collections.Generic;
using System.Linq;

namespace SharpenedMinecraft.Commands
{
    public struct CommandContext
    {
        public string[] Segments { get; set; }
        public string Message { get; }
        public Vector3D Position { get; set; }
        public BaseEntity Entity { get; set; }
        public List<object> Values { get; set; }
        public Player Caller { get; }

        public CommandContext(CommandContext old)
        {
            this.Message = old.Message;
            this.Segments = old.Segments;
            this.Position = old.Position;
            this.Entity = old.Entity;
            this.Values = old.Values;
            this.Caller = old.Caller;
        }

        public CommandContext(string Message, Player caller, Vector3D Position, BaseEntity entity)
        {
            this.Message = Message;
            this.Segments = Message.Split(' '); //TODO: Ignore spaces in " " ie. names
            this.Position = Position;
            this.Entity = entity;
            this.Values = new List<object>();
            this.Caller = caller;
        }
    }
}