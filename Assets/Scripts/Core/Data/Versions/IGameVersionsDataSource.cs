using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace PokeTracker.Core.Data
{
    public interface IGameVersionsDataSource
    {
        public UniTask<int> GetGameVersionsCount();
        public UniTask<IEnumerable<GameVersionData>> GetAllGameVersions();
        public UniTask<GameVersionData> GetGameVersionByID(int id);
        public UniTask<GameVersionData> GetGameVersionByIdentifier(string identifier);
        
        public UniTask<int> GetGameVersionGroupsCount();
        public UniTask<IEnumerable<GameVersionData>> GetAllGameVersionGroups();
        public UniTask<GameVersionData> GetGameVersionGroupByID(int id);
        public UniTask<GameVersionData> GetGameVersionGroupByIdentifier(string identifier);
    }
}
