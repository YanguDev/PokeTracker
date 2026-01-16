namespace PokeTracker.API.PokeApi.DTOs
{
    public class ItemPocketDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO<ItemCategoryDTO>[] categories;
        public NameDTO[] names;
    }
}
