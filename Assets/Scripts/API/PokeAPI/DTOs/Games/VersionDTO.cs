namespace PokeTracker.API.PokeApi.DTOs
{
    public class VersionDTO
    {
        public int id;
        public string name;
        public NameDTO[] names;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
    }
}
