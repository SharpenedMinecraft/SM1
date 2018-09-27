using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types.WorldGenerators
{
    //TODO: Implement Presets from http://minecraft.tools/en/flat.php?preset=0
    public class FlatWorldGenerator : IWorldGenerator
    {
        public WorldType type => new WorldType(WorldType.Type.flat); //Inefficent

        private static Dictionary<int, Block> DefaultBlocks = new Dictionary<int, Block>()
        {
            //Default Flatworld thing.
            {3, new Grass_blockBlock() }, //Grass
            {2, new DirtBlock() }, //Dirt
            {1, new DirtBlock() }, //Dirt
            {0, new BedrockBlock() }, //Bedrock
        };

        public ChunkColumn GenerateChunkAt(Vector3 ChunkPos)
        {
            ChunkSection[] sections = new ChunkSection[Constants.SECTION_PER_COLUMN];

            for (int SectionY = 0; SectionY < Constants.SECTION_PER_COLUMN; SectionY++)
            {
                Dictionary<Vector3, Block> blocks = new Dictionary<Vector3, Block>();
                for (int y = 0; y < Constants.SECTION_HEIGHT; y++)
                {
                    for (int z = 0; z < Constants.SECTION_WIDTH; z++)
                    {
                        for (int x = 0; x < Constants.SECTION_WIDTH; x++)
                        {
                            var ActualPos = y * SectionY;
                            Block state;
                            if (DefaultBlocks.TryGetValue((int)TypeUtils.ChunkToWorldSpace(y, SectionY), out Block block)) ///AAAAAAH Performance
                                state = block;
                            else
                                state = Block.Air;
                            //state = new BlockState(1, 0);

                            blocks.Add(new Vector3(x, y, z), state);
                        }
                    }
                }
                sections[SectionY] = new ChunkSection(blocks)
                {
                    ChunkX = ChunkPos.X,
                    ChunkY = SectionY,
                    ChunkZ = ChunkPos.Z
                };
            }
            return new ChunkColumn(sections, ChunkPos);
        }
    }
}
