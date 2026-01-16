namespace PokeTracker.API.PokeApi.DTOs
{
    public class ItemCategoryDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO<ItemDTO>[] items;
        public NameDTO[] names;
        public NamedAPIResourceDTO<ItemPocketDTO> pocket;
    }
}
