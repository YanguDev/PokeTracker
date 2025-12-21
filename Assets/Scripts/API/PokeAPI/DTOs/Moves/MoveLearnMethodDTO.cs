namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveLearnMethodDTO
    {
        public int id;
        public string name;
        public DescriptionDTO[] descriptions;
        public NameDTO[] names;
        public NamedAPIResourceDTO[] version_groups;
    }
}
