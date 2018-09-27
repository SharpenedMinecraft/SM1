using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types.WorldGenerators
{
    public interface IWorldGenerator
    {
        WorldType type { get; }
        ChunkColumn GenerateChunkAt(Vector3 ChunkPos);
    }
}
