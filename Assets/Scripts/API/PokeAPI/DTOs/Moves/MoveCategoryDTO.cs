namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveCategoryDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO<MoveDTO>[] moves;
        public DescriptionDTO[] descriptions;
    }
}
