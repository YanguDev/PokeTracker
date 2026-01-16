namespace PokeTracker.API.PokeApi.DTOs
{
    public class NatureStatChangeDTO
    {
        public int max_change;
        public NamedAPIResourceDTO<PokeathlonStatDTO> pokeathlon_stat;
    }
}
