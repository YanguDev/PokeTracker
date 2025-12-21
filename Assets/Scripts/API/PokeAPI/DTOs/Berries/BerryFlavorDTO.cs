namespace PokeTracker.API.PokeApi.DTOs
{
    public class BerryFlavorDTO
    {
        public int id;
        public string name;
        public FlavorBerryMapDTO[] berries;
        public NamedAPIResourceDTO contest_type;
        public NameDTO[] names;
    }
}
