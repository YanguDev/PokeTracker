namespace PokeTracker.API.PokeApi.DTOs
{
    public class PastMoveStatValuesDTO
    {
        public int accuracy;
        public int effect_chance;
        public int power;
        public int PP;
        public VerboseEffectDTO[] effect_entries;
        public NamedAPIResourceDTO<TypeDTO> type;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
    }
}
