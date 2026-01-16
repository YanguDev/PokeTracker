namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveFlavorTextDTO
    {
        public string flavor_text;
        public NamedAPIResourceDTO<LanguageDTO> language;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
    }
}
