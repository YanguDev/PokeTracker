namespace PokeTracker.API.PokeApi.DTOs
{
    public class APIResourceListDTO
    {
        public int count;
        public string next;
        public string previous;
        public APIResourceDTO[] results;
    }
}
