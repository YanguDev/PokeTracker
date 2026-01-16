namespace PokeTracker.API.PokeApi.DTOs
{
    public class BerryFlavorDTO
    {
        public int id;
        public string name;
        public FlavorBerryMapDTO[] berries;
        public NamedAPIResourceDTO<ContestTypeDTO> contest_type;
        public NameDTO[] names;
    }
}
