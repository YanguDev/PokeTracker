namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonHeldItemDTO
    {
        public NamedAPIResourceDTO<ItemDTO> item;
        public PokemonHeldItemVersionDTO[] version_details;
    }
}
