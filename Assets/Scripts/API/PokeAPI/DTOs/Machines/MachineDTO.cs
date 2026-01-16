namespace PokeTracker.API.PokeApi.DTOs
{
    public class MachineDTO
    {
        public int id;
        public NamedAPIResourceDTO<ItemDTO> item;
        public NamedAPIResourceDTO<MoveDTO> move;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
    }
}
