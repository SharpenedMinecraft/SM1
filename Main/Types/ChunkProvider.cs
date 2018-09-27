using System;
using System.Collections.Generic;
using SharpenedMinecraft.Packets;
using SharpenedMinecraft.Types.WorldGenerators;

namespace SharpenedMinecraft.Types
{
    public class ChunkProvider
    {
        public IWorldGenerator Generator { get; private set; }
        private Dictionary<Vector3, ChunkColumn> chunkColumns { get; set; }

        public ChunkProvider(IWorldGenerator generator)
        {
            Generator = generator;
            chunkColumns = new Dictionary<Vector3, ChunkColumn>();
        }

        public void SetBlock(Vector3 location, Block blockstate, Player causing)
        {
            TypeUtils.WorldToChunkPosition(location, out Vector3 ChunkPos, out Vector3 RelativeChunkPos);
            var y = ChunkPos.Y;
            ChunkPos.Y = 0;
            try
            {
                chunkColumns[ChunkPos].chunkSections[ChunkPos.Y].SetBlock(RelativeChunkPos, blockstate);
                blockstate.OnPlace(location, causing);
                causing.Client.SendToAll(new BlockChangePacket(causing.Client) //Actually, this shoud be in world?
                {
                    Position = location,
                    newblock = blockstate
                }, x => ((MinecraftClient)x).Player != causing && (location.LengthSqr - causing.Transform.Position.LengthSqr) < Math.Sqrt(causing.ViewDistance));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ChunkColumn GetChunkAt(Vector3 chunkPos)
        {
            lock (chunkColumns)
            {
                if (chunkColumns.TryGetValue(chunkPos, out ChunkColumn value))
                {
                    return value;
                }
                else
                {
                    var newchunk = Generator.GenerateChunkAt(chunkPos);
                    chunkColumns.Add(chunkPos, newchunk);
                    return newchunk;
                }
            }
        }
    }
}