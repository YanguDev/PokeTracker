using System.Linq;
using PokeTracker.API.PokeApi.DTOs;
using PokeTracker.Core.Data;
using PokeTracker.Core.Keys;

namespace PokeTracker.API.PokeApi
{
    public static class PokeAPIMapper
    {
        private const string DEFAULT_LANGUAGE = "en";

        public static PokemonData MapPokemonData(PokemonDTO pokemonDTO)
        {
            var data = new PokemonData()
            {
                ID = pokemonDTO.id,
                Name = pokemonDTO.name
            };

            return data;
        }

        public static GameVersionData MapGameVersionData(VersionDTO versionDTO)
        {            
            return new GameVersionData()
            {
                Key = new GameVersionKey(versionDTO.name),
                DisplayName = "Pokemon " + GetLocalizedName(versionDTO.names)
            };
        }

        public static GameVersionGroupData MapGameVersionGroupData(VersionGroupDTO versionGroupDTO)
        {            
            var gameVersions = versionGroupDTO.versions
                .Select(resource => new GameVersionKey(resource.name))
                .ToArray();

            var pokedexes = versionGroupDTO.pokedexes
                .Select(resource => new PokedexKey(resource.name))
                .ToArray();

            return new GameVersionGroupData()
            {
                Key = new GameVersionGroupKey(versionGroupDTO.name),
                GameVersionKeys = gameVersions,
                PokedexKeys = pokedexes
            };
        }

        public static string GetLocalizedName(NameDTO[] names)
        {
            if (names == null || names.Length == 0) return string.Empty;

            foreach (var name in names)
            {
                if (name.language.name == DEFAULT_LANGUAGE)
                {
                    return name.name;
                }
            }

            return string.Empty;
        }
    }
}
