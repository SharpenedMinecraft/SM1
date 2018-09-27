using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types
{
    public class TypeUtils
    {
        public static Vector3 ChunkToWorldPosition(Vector3 ChunkSpace, ChunkSection chunk)
        {
            return new Vector3(ChunkSpace.X + (long)Math.Floor((double)(chunk.ChunkX * Constants.CHUNK_NUM)),
                ChunkSpace.Y + (long)Math.Floor((double)(chunk.ChunkY * Constants.CHUNK_NUM)),
                ChunkSpace.Z + (long)Math.Floor((double)(chunk.ChunkZ * Constants.CHUNK_NUM)));
        }

        public static long ChunkToWorldSpace(long relative, long relativeTo)
        {
            return relative + (long)Math.Floor((double)(relativeTo * Constants.CHUNK_NUM));
        }

        public static void WorldToChunkPosition(Vector3 WorldSpace, out Vector3 ChunkPos, out Vector3 RelativeChunkPos)
        {
            ChunkPos = new Vector3(
                (long)Math.Floor((double)WorldSpace.X / Constants.CHUNK_NUM),
                (long)Math.Floor((double)WorldSpace.Y / Constants.CHUNK_NUM),
                (long)Math.Floor((double)WorldSpace.Z / Constants.CHUNK_NUM));

            RelativeChunkPos = new Vector3((WorldSpace.X - ChunkPos.X * Constants.CHUNK_NUM),
                (WorldSpace.Y - ChunkPos.Y * Constants.CHUNK_NUM),
                (WorldSpace.Z - ChunkPos.Z * Constants.CHUNK_NUM));

        }
        public static void WorldToChunkSpace(long absolute, out long relativeTo, out long relative)
        {
            relativeTo = absolute / Constants.CHUNK_NUM;
            relative = (absolute - relativeTo * Constants.CHUNK_NUM);
        }
    }
}
