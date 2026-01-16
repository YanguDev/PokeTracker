namespace PokeTracker.API.PokeApi.DTOs
{
    public class RegionDTO
    {
        public int id;
        public NamedAPIResourceDTO<LocationDTO>[] locations;
        public string name;
        public NameDTO[] names;
        public NamedAPIResourceDTO<GenerationDTO> main_generation;
        public NamedAPIResourceDTO<PokedexDTO>[] pokedexes;
        public NamedAPIResourceDTO<VersionGroupDTO>[] version_groups;
    }
}
