namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveStatAffectDTO
    {
        public int change;
        public NamedAPIResourceDTO<MoveDTO> move;
    }
}
