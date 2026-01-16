using UnityEngine;
using PokeTracker.Core.Data;
using PokeTracker.API.HTTPClients;
using PokeTracker.API.PokeApi;
using PokeTracker.API.PokeApi.DTOs;
using PokeTracker.API.PokeApi.Endpoints;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;

namespace PokeTracker.API
{
    public class PokeAPIDataSource : IPokemonDataSource
    {
        private readonly PokeAPIEndpoint pokemonEndpoint;

        public PokeAPIDataSource(IHTTPClient httpClient)
        {
            pokemonEndpoint = new PokeAPIEndpoint("pokemon", httpClient);
        }

        public async UniTask<int> GetPokemonCount()
        {
            string resourceListJson = await pokemonEndpoint.RequestPaginated();
            var dto = JsonConvert.DeserializeObject<NamedAPIResourceListDTO<PokemonDTO>>(resourceListJson);
            return dto.count;
        }

        public async UniTask<PokemonData> GetPokemonDataByID(int id)
        {
            string pokemonJson = await pokemonEndpoint.RequestByID(id);
            return GetPokemonData(pokemonJson);
        }

        public async UniTask<PokemonData> GetPokemonDataByIdentifier(string name)
        {
            string pokemonJson = await pokemonEndpoint.RequestByName(name);
            return GetPokemonData(pokemonJson);
        }

        private PokemonData GetPokemonData(string json)
        {
            Debug.Log(json);
            var dto = JsonConvert.DeserializeObject<PokemonDTO>(json);
            return PokeAPIMapper.MapPokemonData(dto);
        }
    }
}
