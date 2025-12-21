namespace PokeTracker.API.PokeApi.DTOs
{
    public class RegionDTO
    {
        public int id;
        public NamedAPIResourceDTO[] locations;
        public string name;
        public NameDTO[] names;
        public NamedAPIResourceDTO main_generation;
        public NamedAPIResourceDTO[] pokedexes;
        public NamedAPIResourceDTO[] version_groups;
    }
}
