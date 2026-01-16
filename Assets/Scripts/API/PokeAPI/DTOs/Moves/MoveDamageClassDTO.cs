namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveDamageClassDTO
    {
        public int id;
        public string name;
        public DescriptionDTO[] descriptions;
        public NamedAPIResourceDTO<MoveDTO>[] moves;
        public NameDTO[] names;
    }
}
