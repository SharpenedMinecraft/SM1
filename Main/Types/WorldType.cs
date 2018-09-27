using System;
using SharpenedMinecraft.Types.WorldGenerators;

namespace SharpenedMinecraft.Types
{
    public class WorldType
    {
        public WorldType(Type type)
        {
            this.type = type;
        }

        public enum Type
        {
            def,
            flat,
            largeBiomes,
            amplified,
            default_1_1
        }

        public Type type { get; set; }

        public IWorldGenerator GetGenerator()
        {
            switch (this.type)
            {
                case Type.flat:
                    return new FlatWorldGenerator();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}