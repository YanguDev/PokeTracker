namespace PokeTracker.API.PokeApi.DTOs
{
    public class VersionGroupFlavorTextDTO
    {
        public string text;
        public NamedAPIResourceDTO<LanguageDTO> language;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
    }
}
