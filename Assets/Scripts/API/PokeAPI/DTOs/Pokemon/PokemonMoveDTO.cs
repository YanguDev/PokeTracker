namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonMoveDTO
    {
        public NamedAPIResourceDTO move;
        public PokemonMoveVersionDTO[] version_group_details;
    }
}
