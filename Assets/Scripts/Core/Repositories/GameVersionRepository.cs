
using System.Collections.Generic;
using PokeTracker.Core.Data;
using Cysharp.Threading.Tasks;

namespace PokeTracker.Core.Repositories
{
    public class GameVersionRepository
    {
        private readonly IGameVersionsDataSource gameVersionsDataSource;

        public GameVersionRepository(IGameVersionsDataSource gameVersionsDataSource)
        {
            this.gameVersionsDataSource = gameVersionsDataSource;
        }

        public UniTask<int> GetCount()
        {
            return gameVersionsDataSource.GetGameVersionsCount();
        }

        public UniTask<IEnumerable<GameVersionData>> GetAll()
        {
            return gameVersionsDataSource.GetAllGameVersions();
        }

        public UniTask<GameVersionData> GetByID(int id)
        {
            return gameVersionsDataSource.GetGameVersionByID(id);
        }

        public UniTask<GameVersionData> GetByIdentifier(string identifier)
        {
            return gameVersionsDataSource.GetGameVersionByIdentifier(identifier);
        }
    }
}
