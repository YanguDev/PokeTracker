namespace PokeTracker.API.PokeApi.DTOs
{
    public class TypePokemonDTO
    {
        public int slot;
        public NamedAPIResourceDTO<PokemonDTO> pokemon;
    }
}
