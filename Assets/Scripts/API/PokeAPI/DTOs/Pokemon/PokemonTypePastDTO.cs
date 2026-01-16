namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonTypePastDTO
    {
        public NamedAPIResourceDTO<GenerationDTO> generation;
        public PokemonTypeDTO[] types; 
    }
}
