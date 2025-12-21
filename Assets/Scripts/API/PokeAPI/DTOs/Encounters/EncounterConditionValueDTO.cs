namespace PokeTracker.API.PokeApi.DTOs
{
    public class EncounterConditionValueDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO condition;
        public NameDTO[] names;
    }
}
