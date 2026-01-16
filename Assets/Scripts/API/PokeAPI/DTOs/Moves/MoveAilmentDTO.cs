namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveAilmentDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO<MoveDTO>[] moves;
        public NameDTO[] names;
    }
}
