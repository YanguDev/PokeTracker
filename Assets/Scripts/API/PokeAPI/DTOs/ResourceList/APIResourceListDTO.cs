namespace PokeTracker.API.PokeApi.DTOs
{
    public class APIResourceListDTO<T>
    {
        public int count;
        public string next;
        public string previous;
        public APIResourceDTO<T>[] results;
    }
}
