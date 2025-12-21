namespace PokeTracker.API.PokeApi.DTOs
{
    public class BerryDTO
    {
        public int id;
        public string name;
        public int growth_time;
        public int max_harvest;
        public int natural_gift_power;
        public int size;
        public int smoothness;
        public int soil_dryness;
        public NamedAPIResourceDTO firmness;
        public BerryFlavorMapDTO[] flavors;
        public NamedAPIResourceDTO item;
        public NamedAPIResourceDTO natural_gift_type;
    }
}
