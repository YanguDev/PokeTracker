namespace PokeTracker.API.PokeApi.DTOs
{
    public class PalParkEncounterSpeciesDTO
    {
        public int base_score;
        public int rate;
        public NamedAPIResourceDTO<PokemonSpeciesDTO> pokemon_species;
    }
}
