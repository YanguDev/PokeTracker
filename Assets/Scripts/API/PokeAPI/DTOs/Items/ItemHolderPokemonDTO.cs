namespace PokeTracker.API.PokeApi.DTOs
{
    public class ItemHolderPokemonDTO
    {
        public NamedAPIResourceDTO<PokemonDTO> pokemon;
        public ItemHolderPokemonVersionDetailDTO[] version_details;
    }
}
