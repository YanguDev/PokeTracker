namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonSpeciesGenderDTO
    {
        public int rate;
        public NamedAPIResourceDTO<PokemonSpeciesDTO> pokemon_species;
    }
}
