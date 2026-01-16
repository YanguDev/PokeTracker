namespace PokeTracker.API.PokeApi.DTOs
{
    public class NamedAPIResourceDTO<T> : APIResourceDTO<T>
    {
        public string name;
    }
}
