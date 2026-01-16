using Cysharp.Threading.Tasks;
using PokeTracker.API.HTTPClients;
using PokeTracker.API.PokeApi.Endpoints;
using Newtonsoft.Json;
using PokeTracker.API.PokeApi.DTOs;

namespace PokeTracker.API
{
    public class PokeAPIPokedexSource
    {
        private readonly IHTTPClient httpClient;
        private readonly PokeAPIEndpoint pokedexEndpoint;

        public PokeAPIPokedexSource(IHTTPClient httpClient)
        {
            this.httpClient = httpClient;
            pokedexEndpoint = new PokeAPIEndpoint("pokedex", httpClient);
        }
        public async UniTask<int> GetPokedexCount()
        {
            string resourceListJson = await pokedexEndpoint.RequestAll();
            var dto = JsonConvert.DeserializeObject<NamedAPIResourceListDTO<PokedexDTO>>(resourceListJson);
            return dto.count;
        }
    }
}
