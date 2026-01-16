namespace PokeTracker.API.PokeApi.DTOs
{
    public class ItemAttributeDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO<ItemDTO>[] items;
        public NameDTO[] names;
        public DescriptionDTO[] descriptions;
    }
}
