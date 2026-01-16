namespace PokeTracker.API.PokeApi.DTOs
{
    public class ContestComboDetailDTO
    {
        public NamedAPIResourceDTO<MoveDTO>[] use_before;
        public NamedAPIResourceDTO<MoveDTO>[] use_after;
    }
}
