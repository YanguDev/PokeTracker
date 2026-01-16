namespace PokeTracker.API.PokeApi.DTOs
{
    public class NamedAPIResourceListDTO<T>
    {
        public int count;
        public string next;
        public string previous;
        public NamedAPIResourceDTO<T>[] results;
    }
}
