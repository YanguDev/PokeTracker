namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokedexDTO
    {
        public int id;
        public string name;
        public bool is_main_series;
        public DescriptionDTO[] descriptions;
        public NameDTO[] names;
        public PokemonEntryDTO[] pokemon_entries;
        public NamedAPIResourceDTO<RegionDTO> region;
        public NamedAPIResourceDTO<VersionGroupDTO>[] version_groups;
    }
}
