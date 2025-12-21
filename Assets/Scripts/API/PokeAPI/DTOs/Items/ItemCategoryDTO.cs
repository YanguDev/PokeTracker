namespace PokeTracker.API.PokeApi.DTOs
{
    public class ItemCategoryDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO[] items;
        public NameDTO[] names;
        public NamedAPIResourceDTO pocket;
    }
}
