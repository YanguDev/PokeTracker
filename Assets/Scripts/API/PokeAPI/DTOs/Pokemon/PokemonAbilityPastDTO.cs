namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonAbilityPastDTO
    {
        public NamedAPIResourceDTO<GenerationDTO> generation;
        public PokemonAbilityDTO[] abilities;
    }
}
