using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public class ChunkColumn
    {
        public ChunkSection[] chunkSections;
        public Biome[,] Biomes = new Biome[Constants.SECTION_WIDTH, Constants.SECTION_DEPTH];
        public long ChunkX => chunkSections[0].ChunkX;
        public long ChunkZ => chunkSections[0].ChunkZ;

        public ChunkColumn(ChunkSection[] sections, Vector3 ChunkPos)
        {
            if (sections == null)
                sections = new ChunkSection[0];

            if (sections.Length > Constants.SECTION_PER_COLUMN)
                throw new Exception("Too many sections");
            else if (sections.Length < Constants.SECTION_PER_COLUMN)
            {
                var v = sections.ToList();
                while (v.Count != Constants.SECTION_PER_COLUMN)
                {
                    var newSec = ChunkSection.Empty;
                    newSec.ChunkX = ChunkPos.X;
                    newSec.ChunkY = v.Count;
                    newSec.ChunkZ = ChunkPos.Z;
                    v.Add(newSec);
                }
                sections = v.ToArray();
            }

            for (int z = 0; z < Constants.SECTION_DEPTH; z++)
            {
                for (int x = 0; x < Constants.SECTION_WIDTH; x++)
                {
                    Biomes[x,z] = Biome.Void;
                }
            }

            this.chunkSections = sections;
        }
    }
}
