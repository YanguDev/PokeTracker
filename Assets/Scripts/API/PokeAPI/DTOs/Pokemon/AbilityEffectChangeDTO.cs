namespace PokeTracker.API.PokeApi.DTOs
{
    public class AbilityEffectChangeDTO
    {
        public EffectDTO[] effect_entries;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
    }
}
