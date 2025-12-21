namespace PokeTracker.API.PokeApi.DTOs
{
    public class NamedAPIResourceListDTO
    {
        public int count;
        public string next;
        public string previous;
        public NamedAPIResourceDTO[] results;
    }
}
