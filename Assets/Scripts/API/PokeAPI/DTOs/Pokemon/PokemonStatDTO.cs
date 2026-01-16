namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonStatDTO
    {
        public NamedAPIResourceDTO<StatDTO> stat;
        public int effort;
        public int base_stat;
    }
}
