namespace PokeTracker.API.PokeApi.DTOs
{
    public class VersionGroupDTO
    {
        public int id;
        public string name;
        public int order;
        public NamedAPIResourceDTO generation;
        public NamedAPIResourceDTO[] move_learn_methods;
        public NamedAPIResourceDTO[] pokedexes;
        public NamedAPIResourceDTO[] regions;
        public NamedAPIResourceDTO[] versions;
    }
}
