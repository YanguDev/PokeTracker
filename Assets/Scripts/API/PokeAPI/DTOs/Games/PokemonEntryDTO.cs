namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonEntryDTO
    {
        public int entry_number;
        public NamedAPIResourceDTO<PokemonSpeciesDTO> pokemon_species;
    }
}
