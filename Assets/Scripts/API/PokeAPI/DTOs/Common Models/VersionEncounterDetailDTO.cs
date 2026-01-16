namespace PokeTracker.API.PokeApi.DTOs
{
    public class VersionEncounterDetailDTO
    {
        public NamedAPIResourceDTO<VersionDTO> version;
        public int max_chance;
        public EncounterDTO[] encounter_details;
    }
}
