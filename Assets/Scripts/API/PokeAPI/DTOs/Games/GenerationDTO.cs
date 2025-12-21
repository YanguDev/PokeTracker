namespace PokeTracker.API.PokeApi.DTOs
{
    public class GenerationDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO[] abilities;
        public NameDTO[] names;
        public NamedAPIResourceDTO main_region;
        public NamedAPIResourceDTO[] moves;
        public NamedAPIResourceDTO[] pokemon_species;
        public NamedAPIResourceDTO[] types;
        public NamedAPIResourceDTO[] version_groups;
    }
}
