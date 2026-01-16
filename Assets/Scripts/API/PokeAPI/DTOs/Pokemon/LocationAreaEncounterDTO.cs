namespace PokeTracker.API.PokeApi.DTOs
{
    public class LocationAreaEncounterDTO
    {
        public NamedAPIResourceDTO<LocationAreaDTO> location_area;
        public VersionEncounterDetailDTO[] version_details;
    }
}
