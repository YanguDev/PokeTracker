namespace PokeTracker.API.PokeApi.DTOs
{
    public class EvolutionTriggerDTO
    {
        public int id;
        public string name;
        public NameDTO[] names;
        public NamedAPIResourceDTO[] pokemon_species;
    }
}
