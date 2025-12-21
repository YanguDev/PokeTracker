namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonHabitatDTO
    {
        public int id;
        public string name;
        public NameDTO[] names;
        public NamedAPIResourceDTO[] pokemon_species;
    }
}
