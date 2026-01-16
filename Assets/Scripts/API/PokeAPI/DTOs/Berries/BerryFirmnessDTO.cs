namespace PokeTracker.API.PokeApi.DTOs
{
    public class BerryFirmnessDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO<BerryDTO>[] berries;
        public NameDTO[] names;
    }
}
