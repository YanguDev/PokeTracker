namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonShapeDTO
    {
        public int id;
        public string name;
        public AwesomeNameDTO[] awesome_names;
        public NameDTO[] names;
        public NamedAPIResourceDTO<PokemonSpeciesDTO>[] pokemon_species;
    }
}
