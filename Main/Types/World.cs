using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpenedMinecraft.Types.WorldGenerators;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Packets;

namespace SharpenedMinecraft.Types
{
    public class World
    {
        public static World Overworld = new World(new FlatWorldGenerator(), 0);

        public static void RemovePlayer(Player player)
        {
            Entities.Remove(player);
            var c = Players.First().Client;
            c.SendToAll(new PlayerListItem(null)
            {
                Action = SharpenedMinecraft.Enums.PlayerListAction.RemovePlayer,
                players = new Player[] { player },
            });
        }
        public static IDProvider<int, World> Worlds { get; set; }
        public static IDProvider<int, BaseEntity> Entities { get; set; }
        public static List<Player> Players => Entities.Where(x => x is Player).Select(x => (Player)x).Where(x => x != null).ToList();

        public int DimensionID { get; set; }
        public Difficulty Difficulty { get; set; }
        public List<Player> WorldPlayers => Players.Where(x => x.Transform.Dimension == this.DimensionID).ToList();
        public List<BaseEntity> WorldEntities => Entities.Where(x => x.Transform.Dimension == this.DimensionID).ToList();
        public WorldType WorldType => _chunkProvider.Generator.type;
        private ChunkProvider _chunkProvider;

        static World()
        {
            Init();
        }

        private static bool Initiated;
        private static void Init()
        {
            if (Initiated) return;
            Worlds = new IDProvider<int, World>(x => x.DimensionID);
            Entities = new IDProvider<int, BaseEntity>(x => x.EntityId);
            Initiated = true;
        }


        public World(IWorldGenerator generator, int Dimension)
        {
            Init();

            this.DimensionID = Dimension;

            Difficulty = Difficulty.Easy;
            this._chunkProvider = new ChunkProvider(generator);
            Worlds.Add(this, Dimension);
        }

        public ChunkColumn GetChunkAt(Vector3 ChunkPos)
            => _chunkProvider.GetChunkAt(ChunkPos);

        public void SetBlock(Vector3 location, Block blockstate, Player causing)
            => _chunkProvider.SetBlock(location, blockstate, causing);
        public void AddEntity(BaseEntity baseEntity)
        {
            Entities.Add(baseEntity);
        }
    }
}
