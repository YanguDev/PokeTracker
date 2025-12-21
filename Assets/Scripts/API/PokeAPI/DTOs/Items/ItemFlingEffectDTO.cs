namespace PokeTracker.API.PokeApi.DTOs
{
    public class ItemFlingEffectDTO
    {
        public int id;
        public string name;
        public EffectDTO[] effect_entries;
        public NamedAPIResourceDTO[] items;
    }
}
