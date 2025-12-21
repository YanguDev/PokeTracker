namespace PokeTracker.API.PokeApi.DTOs
{
    public class VersionEncounterDetailDTO
    {
        public NamedAPIResourceDTO version;
        public int max_chance;
        public EncounterDTO[] encounter_details;
    }
}
