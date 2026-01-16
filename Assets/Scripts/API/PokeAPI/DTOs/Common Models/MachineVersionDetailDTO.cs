namespace PokeTracker.API.PokeApi.DTOs
{
    public class MachineVersionDetailDTO
    {
        public APIResourceDTO<MachineDTO> machine;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
    }
}
