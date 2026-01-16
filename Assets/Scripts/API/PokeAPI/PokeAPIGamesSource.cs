using System.Collections.Generic;
using PokeTracker.Core.Data;
using PokeTracker.API.HTTPClients;
using PokeTracker.API.PokeApi;
using PokeTracker.API.PokeApi.DTOs;
using PokeTracker.API.PokeApi.Endpoints;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;

namespace PokeTracker.API
{
    public class PokeAPIGamesSource : IGameVersionsDataSource
    {
        private readonly IHTTPClient httpClient;
        private readonly PokeAPIEndpoint versionEndpoint;
        private readonly PokeAPIEndpoint versionGroupEndpoint;

        public PokeAPIGamesSource(IHTTPClient httpClient)
        {
            this.httpClient = httpClient;
            versionEndpoint = new PokeAPIEndpoint("version", httpClient);
            versionGroupEndpoint = new PokeAPIEndpoint("version-group", httpClient);
        }

        public async UniTask<int> GetGameVersionsCount()
        {
            string resourceListJson = await versionEndpoint.RequestAll();
            var dto = JsonConvert.DeserializeObject<NamedAPIResourceListDTO<VersionDTO>>(resourceListJson);
            return dto.count;
        }

        public async UniTask<IEnumerable<GameVersionData>> GetAllGameVersions()
        {
            string resourceListJson = await versionEndpoint.RequestAll();
            var resourceListDTO = JsonConvert.DeserializeObject<NamedAPIResourceListDTO<VersionDTO>>(resourceListJson);

            var games = await PokeAPIResourceResolver.ResolveAll(
                resourceListDTO.results, httpClient, PokeAPIMapper.MapGameVersionData);
            
            return games;
        }

        public async UniTask<GameVersionData> GetGameVersionByID(int id)
        {
            string gameVersionJson = await versionEndpoint.RequestByID(id);
            return GetGameVersionData(gameVersionJson);
        }

        public async UniTask<GameVersionData> GetGameVersionByIdentifier(string identifier)
        {
            string gameVersionJson = await versionEndpoint.RequestByName(identifier);
            return GetGameVersionData(gameVersionJson);
        }

        private GameVersionData GetGameVersionData(string json)
        {
            var dto = JsonConvert.DeserializeObject<VersionDTO>(json);
            return PokeAPIMapper.MapGameVersionData(dto);
        }

        public UniTask<int> GetGameVersionGroupsCount()
        {
            throw new System.NotImplementedException();
        }

        public UniTask<IEnumerable<GameVersionData>> GetAllGameVersionGroups()
        {
            throw new System.NotImplementedException();
        }

        public UniTask<GameVersionData> GetGameVersionGroupByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public UniTask<GameVersionData> GetGameVersionGroupByIdentifier(string identifier)
        {
            throw new System.NotImplementedException();
        }

        private GameVersionGroupData GetGameVersionGroupData(string json)
        {
            var dto = JsonConvert.DeserializeObject<VersionGroupDTO>(json);
            return PokeAPIMapper.MapGameVersionGroupData(dto);
        }
    }
}
