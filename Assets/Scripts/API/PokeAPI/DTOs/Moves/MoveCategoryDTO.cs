namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveCategoryDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO[] moves;
        public DescriptionDTO[] descriptions;
    }
}
