namespace PokeTracker.API.PokeApi.DTOs
{
    public class GenerationDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO<AbilityDTO>[] abilities;
        public NameDTO[] names;
        public NamedAPIResourceDTO<RegionDTO> main_region;
        public NamedAPIResourceDTO<MoveDTO>[] moves;
        public NamedAPIResourceDTO<PokemonSpeciesDTO>[] pokemon_species;
        public NamedAPIResourceDTO<TypeDTO>[] types;
        public NamedAPIResourceDTO<VersionGroupDTO>[] version_groups;
    }
}
