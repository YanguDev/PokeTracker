namespace PokeTracker.API.PokeApi.DTOs
{
    public class EncounterConditionDTO
    {
        public int id;
        public string name;
        public NameDTO[] names;
        public NamedAPIResourceDTO[] values;
    }
}
