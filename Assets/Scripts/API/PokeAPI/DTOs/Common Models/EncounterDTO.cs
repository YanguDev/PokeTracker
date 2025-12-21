namespace PokeTracker.API.PokeApi.DTOs
{
    public class EncounterDTO
    {
        public int min_level;
        public int max_level;
        public NamedAPIResourceDTO condition_values;
        public int chance;
        public NamedAPIResourceDTO method;
    }
}
