namespace PokeTracker.API.PokeApi.DTOs
{
    public class ContestTypeDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO berry_flavor;
        public ContestNameDTO[] names;
    }
}
