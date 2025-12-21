namespace PokeTracker.API.PokeApi.DTOs
{
    public class ContestEffectDTO
    {
        public int id;
        public int appeal;
        public int jam;
        public EffectDTO[] effect_entries;
        public FlavorTextDTO[] flavor_text_entries;
    }
}
