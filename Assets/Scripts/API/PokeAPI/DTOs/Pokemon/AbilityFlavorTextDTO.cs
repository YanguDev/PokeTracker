namespace PokeTracker.API.PokeApi.DTOs
{
    public class AbilityFlavorTextDTO
    {
        public string flavor_text;
        public NamedAPIResourceDTO<LanguageDTO> language;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
    }
}
