using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public class ChunkSection
    {
        public static ChunkSection Empty { get { var v = new ChunkSection(); v.blocks[new Vector3(0, 0, 0)] = new AirBlock(); return v; } }

        public Dictionary<Vector3, Block> blocks = new Dictionary<Vector3, Block>();
        public long ChunkX { get; set; }
        public long ChunkY { get; set; }
        public long ChunkZ { get; set; }
        public bool IsEmpty => blocks.All(x => x.Value.Equals(Block.Air));

        //TODO: End/Nether dont do Skylight
        public bool HasSkylight => true;

        public ChunkSection(Dictionary<Vector3, Block> blocks = null)
        {
            if (blocks == null)
            {
                blocks = new Dictionary<Vector3, Block>();
            }
            for (int x = 0; x < Constants.COLUMN_WIDTH; x++)
            {
                for (int z = 0; z < Constants.COLUMN_DEPTH; z++)
                {
                    for (int y = 0; y < Constants.COLUMN_HEIGHT; y++)
                    {
                        var v = new Vector3(x, y, z);
                        if (!blocks.ContainsKey(v))
                            blocks.Add(v, Block.Air);
                    }
                }
            }
            this.blocks = blocks;
        }

        public void SetBlock(Vector3 pos, Block state)
        {
            blocks[pos] = state;
        }
    }
}
