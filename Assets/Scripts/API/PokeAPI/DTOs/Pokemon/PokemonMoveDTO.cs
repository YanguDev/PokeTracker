namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonMoveDTO
    {
        public NamedAPIResourceDTO<MoveDTO> move;
        public PokemonMoveVersionDTO[] version_group_details;
    }
}
