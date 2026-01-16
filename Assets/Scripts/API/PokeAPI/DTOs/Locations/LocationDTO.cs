namespace PokeTracker.API.PokeApi.DTOs
{
    public class LocationDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO<RegionDTO> region;
        public NameDTO[] names;
        public GenerationGameIndexDTO[] game_indices;
        public NamedAPIResourceDTO<LocationAreaDTO>[] areas;
    }
}
