namespace PokeTracker.API.PokeApi.DTOs
{
    public class VersionGroupDTO
    {
        public int id;
        public string name;
        public int order;
        public NamedAPIResourceDTO<GenerationDTO> generation;
        public NamedAPIResourceDTO<MoveLearnMethodDTO>[] move_learn_methods;
        public NamedAPIResourceDTO<PokedexDTO>[] pokedexes;
        public NamedAPIResourceDTO<RegionDTO>[] regions;
        public NamedAPIResourceDTO<VersionDTO>[] versions;
    }
}
