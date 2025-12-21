namespace PokeTracker.API.PokeApi.DTOs
{
    public class ItemAttributeDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO[] items;
        public NameDTO[] names;
        public DescriptionDTO[] descriptions;
    }
}
