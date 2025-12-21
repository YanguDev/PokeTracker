namespace PokeTracker.API.PokeApi.DTOs
{
    public class LocationDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO region;
        public NameDTO[] names;
        public GenerationGameIndexDTO[] game_indices;
        public NamedAPIResourceDTO[] areas;
    }
}
