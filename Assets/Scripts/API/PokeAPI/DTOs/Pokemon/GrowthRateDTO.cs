namespace PokeTracker.API.PokeApi.DTOs
{
    public class GrowthRateDTO
    {
        public int id;
        public string name;
        public string formula;
        public DescriptionDTO[] descriptions;
        public GrowthRateExperienceLevelDTO[] levels;
        public NamedAPIResourceDTO<PokemonSpeciesDTO>[] pokemon_species;
    }
}
