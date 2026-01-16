namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonSpeciesVarietyDTO
    {
        public bool is_default;
        public NamedAPIResourceDTO<PokemonDTO> pokemon;
    }
}
