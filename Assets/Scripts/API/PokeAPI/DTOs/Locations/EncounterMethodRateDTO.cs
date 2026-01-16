namespace PokeTracker.API.PokeApi.DTOs
{
    public class EncounterMethodRateDTO
    {
        public NamedAPIResourceDTO<EncounterMethodDTO> encounter_method;
        public EncounterVersionDetailsDTO[] version_details;
    }
}
