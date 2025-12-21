namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokeathlonStatDTO
    {
        public int id;
        public string name;
        public NameDTO[] names;
        public NaturePokeathlonStatAffectSetsDTO affecting_natures;
    }
}
