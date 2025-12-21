namespace PokeTracker.API.PokeApi.DTOs
{
    public class ItemPocketDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO[] categories;
        public NameDTO[] names;
    }
}
