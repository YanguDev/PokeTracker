namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveStatChangeDTO
    {
        public int change;
        public NamedAPIResourceDTO<StatDTO> stat;
    }
}
